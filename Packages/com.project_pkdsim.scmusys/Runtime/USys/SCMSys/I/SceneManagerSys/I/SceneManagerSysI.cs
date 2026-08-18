using project_pkdsim.USys.SCMSys.Modules.SceneManagerSys.HOUSES.NPC;
using project_pkdsim.USys.SCMSys.Modules.SceneManagerSys.HOUSES.PLAYER;

namespace project_pkdsim.USys.SCMSys.Modules.SceneManagerSys.Modules
{
    public class SceneManagementSysI
    {
        protected SCMSys_NPC_Houses SCMSys_NPC_Houses;
        protected SCMSys_Player_House_I SCMSys_Player_House;
        public void SCMSys_Houses()
        {
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