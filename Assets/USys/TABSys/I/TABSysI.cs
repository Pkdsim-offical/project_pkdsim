namespace project_pkdsim.Assets.USys.TABSys.I
{
    public class TABSysI
    {
        private project_pkdsim.Assets.USys.TABSys.TABSys_PkpediaLink.TABSys_PkpediaLink TABSys_PkPhoneUI_PkpediaAPP;
        private project_pkdsim.Assets.USys.TABSys.TABSys_SettingsLink.TABSys_SettingsLink TABSys_PkPhoneUI_SettingsAPP;
        public void PkPhone_pkpediaAPP()
        {
            TABSys_PkPhoneUI_PkpediaAPP.TABSys_pkpediaLink();
        }
        public void PkPhone_SetAPP()
        {
            TABSys_PkPhoneUI_SettingsAPP.TABSys_settingsLink();
        }
        public void TABSys_PkPhoneApps()
        {
            TABSys_PkPhoneUI_PkpediaAPP = new project_pkdsim.Assets.USys.TABSys.TABSys_PkpediaLink.TABSys_PkpediaLink();
            TABSys_PkPhoneUI_SettingsAPP = new project_pkdsim.Assets.USys.TABSys.TABSys_SettingsLink.TABSys_SettingsLink();
        }
    }
}