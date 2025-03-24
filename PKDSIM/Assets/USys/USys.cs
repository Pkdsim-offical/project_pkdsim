using project_pkdsim.Assets.USys.AIRoutesSys;
using project_pkdsim.Assets.USys.AnimatedTexturesSys;
using project_pkdsim.Assets.USys.AntiDateAndTimeSys;
using project_pkdsim.Assets.USys.AUDIOSys;
using project_pkdsim.Assets.USys.DialogueSys;
using project_pkdsim.Assets.USys.HolidaySys;
using project_pkdsim.Assets.USys.LoveSys;
using project_pkdsim.Assets.USys.MoneySys;
using project_pkdsim.Assets.USys.SceneManagerSys;
using project_pkdsim.Assets.USys.SkyboxSys;
using project_pkdsim.Assets.USys.TabChangeManagerSys;
using project_pkdsim.Assets.USys.TabSys;
using project_pkdsim.Assets.USys.UnityPlayerSaveSys;
using project_pkdsim.Assets.USys.USystemsSys;
using project_pkdsim.Assets.USys.UTeleporterSys;
using UnityEngine;


namespace project_pkdsim.Assets.USys
{
    public class USys : MonoBehaviour
    {
        private AIRSys AIRSys;

        private HDSys HolidaySys;

        private ITEMSys ItemsSys;
        
        private LOVERSys LoveSys;

        private UPSSys UPSSys;

        private TCMSys TCMSys;

        private TABSys TABSys;

        private SCMSys SCMSys;

        private UnityTeleporterSys UTPSys;

        private MOSys MoneySys;

        private DialSys DialogueSys;

        private AudioSys AudioSys;

        private ADATSys ADATSys;

        private ATSys ATSys;

        private SBSys SBSys;

        private void LoadUSys()
        {
            LoadAIRSys();
            LoadHDSys();
            LoadITEMSSys();
            LoadLOVESys();
            LoadUPSSys();
            LoadTCMSys();
            LoadTABSys();
            LoadSCMSys();
            LoadMoneySys();
            LoadHTPSys();
            LoadDialogueSys();
            LoadAudioSys();
            LoadADATSys();
            LoadATSys();
            LoadSBSys();
        }
        private void LoadAIRSys()
        {
            AIRSys.AIRoutesSysI();
        }
        private void LoadHDSys()
        {
            HolidaySys.HDSysI();
        }
        private void LoadITEMSSys()
        {
            ItemsSys.ITEMSSysI();
        }
        private void LoadLOVESys()
        {
            LoveSys.LoveSysI();
        }
        private void LoadUPSSys()
        {
            UPSSys.UPSSysI();
        }
        private void LoadTCMSys()
        {
            TCMSys.TCMSysI();
        }
        private void LoadTABSys()
        {
            TABSys.TABSysI();
        }
        private void LoadSCMSys()
        {
            SCMSys.SCMSysI();
        }
        private void LoadHTPSys() 
        {
            UTPSys.UTPSysI();
        }
        private void LoadMoneySys()
        {
            MoneySys.MoneySysI();
        }
        private void LoadDialogueSys()
        {
            DialogueSys.DialogueSysI();
        }
        private void LoadAudioSys()
        {
            AudioSys.AudioSysI();
        }
        private void LoadADATSys()
        {
            ADATSys.ADATSysI();
        }
        private void LoadATSys() 
        {
            ATSys.ATSysI();
        }
        private void LoadSBSys() 
        {
            SBSys.SBSysI();
        }
    }
}