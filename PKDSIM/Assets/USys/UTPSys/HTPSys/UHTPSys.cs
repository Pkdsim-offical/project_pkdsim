using project_pkdsim.Assets.USys.UTPSys.UHousesTeleporterSys.I;
using UnityEngine.SceneManagement;

namespace project_pkdsim.Assets.USys.UTPSys.UHousesTeleporterSys
{
    public class UHTeleporterSys : UHTPSysI
    {
        public void LoadScene(string Street)
        {
            SceneManager.LoadScene(Street);
        }
        public void UHTPSysI()
        {
            LoadScene("Street");
        }
    }
}