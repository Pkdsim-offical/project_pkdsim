using project_pkdsim.Assets.USys.UTPSys.UHousesTeleporterSys.HOUSES.NPC;
using project_pkdsim.Assets.USys.UTPSys.UHousesTeleporterSys.HOUSES.PLAYER;
using UnityEngine;

namespace project_pkdsim.Assets.USys.UTPSys.UHousesTeleporterSys.I
{
    public class UHTPSysI: MonoBehaviour
    {
        protected UHTPSys_NPC_FamilyTeleporter HTPSys_NPC_FamilyTeleporter;
        protected UHTPSys_Player_FamilyTeleporter HTPSys_Player_FamilyTeleporter;
        public void HTPSys_HTPSys_NPC_FamilyTeleporter() {
            NPC_HTPSys_NPC_FamilyTeleporterI();
            HTPSys_Player_FamilyTeleporterI();
        }
        protected void NPC_HTPSys_NPC_FamilyTeleporterI()
        {
            HTPSys_NPC_FamilyTeleporter.UHTPSys_NPC_FamilySceneTeleporter("family");
        }
        protected void HTPSys_Player_FamilyTeleporterI()
        {
            HTPSys_Player_FamilyTeleporter.UHTPSys_Player_FamilySceneTeleporter();
        }
    }
}