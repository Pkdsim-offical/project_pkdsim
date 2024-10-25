using project_pkdsim.Assets.USys.SCMSys.HOUSES.NPC;
using project_pkdsim.Assets.USys.SCMSys.HOUSES.PLAYER;

namespace project_pkdsim.Assets.USys.SCMSys.I
{
    public class SCMSys_I
    {
        protected SCMSys_NPC_Houses SCMSys_NPC_Houses;
        protected SCMSys_Player_House_I SCMSys_Player_House;
        public void SCMSys_Houses() {
            NPC_Houses();
            Player_House();
        }
        protected void NPC_Houses()
        {
            SCMSys_NPC_Houses.SCMSys_NPC_HousesI("family");
        }
        protected void Player_House()
        {
            SCMSys_Player_House.SCMSys_Player_FamilySceneI();
        }
    }
}