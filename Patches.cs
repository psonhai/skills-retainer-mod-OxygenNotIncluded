using HarmonyLib;
using System.Collections.Generic;

namespace Skill_Retainer
{
    public class Patches
    {
        [HarmonyPatch(typeof(MinionResume), "ResetSkillLevels")]
        class MinionResume_ResetSkillLevels_Patch
        {
            public static void Postfix(MinionResume __instance)
            {
                var spawnSkills = __instance.GrantedSkillIDs;
                foreach (string skillId in spawnSkills) {
                    __instance.MasterSkill(skillId);
                }
            }
        }
    }
}
