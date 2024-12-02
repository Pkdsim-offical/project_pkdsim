using project_pkdsim.Assets.USys.AUDIOSys;
using project_pkdsim.Assets.USys.DSys;
using project_pkdsim.Assets.USys.HDSys;
using project_pkdsim.Assets.USys.ITEMSSys;
using project_pkdsim.Assets.USys.LOVESys;
using project_pkdsim.Assets.USys.SCMSys;
using project_pkdsim.Assets.USys.TABSys;
using project_pkdsim.Assets.USys.TCMSys;
using project_pkdsim.Assets.USys.UPSSys;
using project_pkdsim.Assets.USys.AIRoutesSys;
using project_pkdsim.Assets.USys.TeleporterSys;
using project_pkdsim.Assets.USys.MONEYSys;
using project_pkdsim.Assets.USys.AntiDateAndTimeSys;
using UnityEngine;


namespace project_pkdsim.Assets.USys
{
    public class USys : MonoBehaviour
    {
        private AIRSys AIRSys;

        private HolidaySys HolidaySys;

        private ITEMSDatabaseSys Itemssys;
        
        private LOVERSys LoveSys;

        private UnityPlayerSaveSys UPSSys;

        private TabChangeManagerSys TCMSys;

        private TABLoaderSys TABSys;

        private SceneManagerSys SCMSys;

        private UnityTeleporterSys UTPSys;

        private MoneySys MoneySys;

        private DialogueSys DialogueSys;

        private AudioSys AudioSys;

        private ADATSys ADATSys;

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
            Itemssys.ITEMSSysI();
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
    }
}