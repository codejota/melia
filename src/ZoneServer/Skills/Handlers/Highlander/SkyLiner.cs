﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Highlander
{
	/// <summary>
	/// Handler for the Highlander skill SkyLiner.
	/// </summary>
	[SkillHandler(SkillId.Highlander_SkyLiner)]
	public class SkyLiner : IGroundSkillHandler, IDynamicCasted
	{
		private const int TotalHits = 4;
		private bool keepAttacking = false;
		public void StartDynamicCast(Skill skill, ICombatEntity caster)
		{			
			keepAttacking = true;
			Send.ZC_PLAY_SOUND(caster, "voice_archer_multishot_cast"); // Probably not the right voice clip
		}

		/// <summary>
		/// Called when the user stops casting the skill.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		public void EndDynamicCast(Skill skill, ICombatEntity caster)
		{
			keepAttacking = false; // Prevents further attacks from executing
			Send.ZC_STOP_SOUND(caster, "voice_archer_multishot_cast");
		}


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

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 50, width: 100, angle: 90);
			var splashArea = skill.GetSplashArea(SplashType.Fan, splashParam); // DB states that this should be Square

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

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
			var hits = new List<SkillHitInfo>();
			var hitDelay = TimeSpan.FromMilliseconds(30);
			var damageDelay1 = TimeSpan.FromMilliseconds(50);
			var damageDelay2 = TimeSpan.FromMilliseconds(80);
			var delayBetweenHits = TimeSpan.FromMilliseconds(250);
			var delayBetweenRepeats = TimeSpan.FromMilliseconds(470);
			var skillHitDelay = TimeSpan.Zero;

			for (var i = 0; i < TotalHits; ++i)
			{
				await Task.Delay(hitDelay);

				var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

				foreach (var target in targets.LimitBySDR(caster, skill))
				{
					var skillHitResult = SCR_SkillHit(caster, target, skill);
					target.TakeDamage(skillHitResult.Damage, caster);

					var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay1, skillHitDelay);
					skillHit.HitEffect = HitEffect.Impact;
					hits.Add(skillHit);
					Send.ZC_SKILL_HIT_INFO(caster, hits);
				}

				await Task.Delay(delayBetweenHits);
				hits.Clear();

				foreach (var target in targets.LimitBySDR(caster, skill))
				{
					var skillHitResult2 = SCR_SkillHit(caster, target, skill);
					target.TakeDamage(skillHitResult2.Damage, caster);

					var skillHit2 = new SkillHitInfo(caster, target, skill, skillHitResult2, damageDelay2, skillHitDelay);
					skillHit2.HitEffect = HitEffect.Impact;
					hits.Add(skillHit2);
					Send.ZC_SKILL_HIT_INFO(caster, hits);
				}

				if (i < TotalHits - 1)
					await Task.Delay(delayBetweenRepeats);

				hits.Clear();

				if (!keepAttacking) break;
			}

			Send.ZC_SKILL_DISABLE(caster as Character);
		}
	}
}
