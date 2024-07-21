﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Buffs.Handlers;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsman.Hoplite
{
	/// <summary>
	/// Handler for the Hoplite Skill Synchro Thrusting.
	/// </summary>
	[SkillHandler(SkillId.Hoplite_SynchroThrusting)]
	public class Hoplite_SynchroThrusting : IGroundSkillHandler
	{
		private readonly static TimeSpan BlockDuration = TimeSpan.FromMilliseconds(400);

		/// <summary>
		/// Handles skill, damaging targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 70, width: 25, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Square, splashParam);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

			if (caster is Character character)
			{
				var lhItem = character.Inventory.GetItem(EquipSlot.LeftHand);
				if (lhItem.Data.EquipType1 == EquipType.Shield)
					character.StartBuff(BuffId.Skill_MomentaryBlock_Buff, BlockDuration);
			}
			
			this.Attack(skill, caster, splashArea);
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async void Attack(Skill skill, ICombatEntity caster, ISplashArea splashArea)
		{
			var hitDelay = TimeSpan.FromMilliseconds(330);
			var damageDelay = TimeSpan.FromMilliseconds(20);
			var skillHitDelay = TimeSpan.Zero;

			await Task.Delay(hitDelay);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var hits = new List<SkillHitInfo>();

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var hitCount = 3;
				var forcedCritical = false;

				if (caster.TryGetBuff(BuffId.Skill_MomentaryBlock_Buff, out var buff))
				{
					if (Skill_MomentaryBlock_Buff.WasAttackBlocked(buff))
					{
						forcedCritical = true;
					}
				}

				var modifier = SkillModifier.MultiHit(hitCount);
				modifier.ForcedCritical = forcedCritical;

				if (caster is Character character)
				{
					var lhItem = character.Inventory.GetItem(EquipSlot.LeftHand);
					if (lhItem.Data.EquipType1 != EquipType.Shield)
						modifier.BonusPAtk = lhItem.Data.Def * 0.3f;
				}

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);

				if (skillHitResult.Result == HitResultType.Crit && caster.Components.TryGet<SkillComponent>(out var skills)
					&& skills.TryGet(SkillId.Hoplite_SharpSpear, out var sharpSpear))
				{
					skillHitResult.Damage += skillHitResult.Damage *= (0.1f + sharpSpear.Level * 0.02f);
				}

				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;
				hits.Add(skillHit);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}
	}
}
