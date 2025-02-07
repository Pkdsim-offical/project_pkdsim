using project_pkdsim.Assets.USys.SCMSys.I;
using UnityEngine.SceneManagement;

namespace project_pkdsim.Assets.USys.SCMSys
{
    public class SCMSys : SCMSys_I
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