using UnityEngine;
using project_pkdsim.Assets.USys.TabSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_SettingsLink.I;

namespace project_pkdsim.Assets.USys.TabSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_SettingsLink
{
    public class TABSys_SettingsLinker: MonoBehaviour
    {
        private TABSys_SettingsLINK TABSys_SettingsLinkI;
        public void TABSys_settingsLink() 
        {
            TABSys_SettingsLinkI.TABSys_SettingsMenuI();
        }
    }
}