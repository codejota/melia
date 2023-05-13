﻿using Melia.Zone.Network;
using Melia.Zone.Skills.Base;
using Melia.Zone.World.Entities;
using Melia.Shared.Tos.Const;

namespace Melia.Zone.Skills.General
{
	/// <summary>
	/// Targeted skill handler implmentation when the client provides a target
	/// </summary>
	public class TargetedSkillHandler : ITargetedSkillHandler
	{
		public void Handle(Skill skill, Character caster, ICombatEntity target)
		{
			if (skill.SpendSp > 0)
				caster.ModifySp(-skill.SpendSp);

			skill.IncreaseOverheat();

			if (target == null)
			{
				Send.ZC_SKILL_FORCE_TARGET(caster, null, skill, 0);
				return;
			}

			var damage = caster.GetRandomAtk(skill);
			target.TakeDamage(damage, caster);

			Send.ZC_SKILL_FORCE_TARGET(caster, target, skill, damage);

			if (target.IsDead)
				Send.ZC_SKILL_CAST_CANCEL(caster, target);
		}
	}
}
