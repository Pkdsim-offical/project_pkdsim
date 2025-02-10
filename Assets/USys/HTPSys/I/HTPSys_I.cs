using project_pkdsim.Assets.USys.HTPSys.HOUSES.NPC;
using project_pkdsim.Assets.USys.HTPSys.HOUSES.PLAYER;

namespace project_pkdsim.Assets.USys.HTPSys.I
{
    public class HTPSys_I
    {
        protected HTPSys_NPC_FamilyTeleporter HTPSys_NPC_FamilyTeleporter;
        protected HTPSys_Player_FamilyTeleporter HTPSys_Player_FamilyTeleporter;
        public void HTPSys_HTPSys_NPC_FamilyTeleporter() {
            NPC_HTPSys_NPC_FamilyTeleporterI();
            HTPSys_Player_FamilyTeleporterI();
        }
        protected void NPC_HTPSys_NPC_FamilyTeleporterI()
        {
            HTPSys_NPC_FamilyTeleporter.HTPSys_NPC_FamilySceneTeleporter("family");
        }
        protected void HTPSys_Player_FamilyTeleporterI()
        {
            HTPSys_Player_FamilyTeleporter.HTPSys_Player_FamilySceneTeleporter();
        }
    }
}