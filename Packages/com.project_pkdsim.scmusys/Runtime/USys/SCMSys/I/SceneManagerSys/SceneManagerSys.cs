using project_pkdsim.USys.SCMSys.Modules.SceneManagerSys.Modules;
using UnityEngine.SceneManagement;

namespace project_pkdsim.USys.SCMSys.Modules.SceneManagerSys
{
    public class SceneManagementSys : SceneManagementSysI
    {
        public void LoadScene(string project_pkdsim)
        {
            SceneManager.LoadScene(project_pkdsim);
        }
        public void SceneManagementSysI()
        {
            LoadScene("project_pkdsim");
        }
    }
}