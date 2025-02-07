using UnityEngine;
using project_pkdsim.Assets.USys.TABSys.I;

namespace project_pkdsim.Assets.USys.TABSys
{
    public class TABSys : MonoBehaviour
    {
        private TABSysI TabSysI;
        public void TABSysI()
        {
            TabSysI.TABSys_PkPhoneApps();
        }
    }
}