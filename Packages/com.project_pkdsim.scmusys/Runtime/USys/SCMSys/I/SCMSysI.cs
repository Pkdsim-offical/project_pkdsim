using project_pkdsim.USys.SCMSys.Modules.SceneManagerSys;
namespace project_pkdsim.USys.SCMSys.Modules
{
    public class SCMSysI
    {
        SceneManagementSys sceneManagerSys;
        public void SCMSys_I()
        {
            GetSceneManagementSys();
        }

        public void GetSceneManagementSys()
        {
            sceneManagerSys.SceneManagementSysI();
        }
    }
}