using UnityEngine;
using project_pkdsim.Assets.USys.TABSys.I;

namespace project_pkdsim.Assets.USys.TABSys
{
    public class TABLoaderSys : MonoBehaviour
    {
        private TABSysI TabSys;
        public void TABSysI()
        {
            TabSys.TABSys_PkPhoneAppsI();
        }
    }
}