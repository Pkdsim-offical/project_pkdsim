using UnityEngine;
using project_pkdsim.Assets.USys.TabSys.I;

namespace project_pkdsim.Assets.USys.TabSys
{
    public class TABSys : MonoBehaviour
    {
        private TABSysI TabSys;
        public void TABSysI()
        {
            TabSys.TABSys_PkPhoneAppsI();
        }
    }
}