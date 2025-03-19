using project_pkdsim.Assets.USys.SceneManagerSys.I;
using UnityEngine.SceneManagement;

namespace project_pkdsim.Assets.USys.SceneManagerSys
{
    public class SCMSys : SCMSysI
    {
        public void LoadScene(string project_pkdsim)
        {
            SceneManager.LoadScene(project_pkdsim);
        }
        public void SCMSysI()
        {
            LoadScene("project_pkdsim");
        }
    }
}