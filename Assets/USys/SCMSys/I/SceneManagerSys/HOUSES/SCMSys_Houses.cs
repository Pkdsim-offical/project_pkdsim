using UnityEngine;
using project_pkdsim.Assets.USys.SceneManagerSys.HOUSES.NPC;
using project_pkdsim.Assets.USys.SceneManagerSys.HOUSES.PLAYER;

namespace project_pkdsim.Assets.USys.HOUSES
{
    public class SCMSys_Houses: MonoBehaviour
    {
        protected SCMSys_Player_House_I Player_FamilyScene;
        protected SCMSys_NPC_Houses NPC_FamiliesScenes;
        public void NPC_FamiliesScenesI() {
            NPC_FamiliesScenes.SCMSys_NPC_HousesI("family");
        }
        public void Player_FamilyScenesI()
        {
            Player_FamilyScene.Load_Player_FamilyScene();
        }
    }
}

