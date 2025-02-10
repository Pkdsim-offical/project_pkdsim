using project_pkdsim.Assets.USys.HTPSys.I;
using UnityEngine.SceneManagement;

namespace project_pkdsim.Assets.USys.HTPSys
{
    public class HTPSys : HTPSys_I
    {
        public void LoadScene(string project_pkdsim)
        {
            SceneManager.LoadScene(project_pkdsim);
        }
        public void HTPSysI()
        {
            LoadScene("project_pkdsim");
        }
    }
}