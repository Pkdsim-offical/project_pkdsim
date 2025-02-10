using System.Collections;
using UnityEngine;

namespace project_pkdsim.Assets.USys
{
    public class USys : MonoBehaviour
    {
        private AIRoutesSys.AIRSys AIRSys;

        private HDSys.HDSys HolidaySys;

        private ITEMSSys.ITEMSSys Itemssys;
        
        private LOVESys.LOVESys LoveSys;

        private UPSSys.UPSSys UPSSys;

        private TCMSys.TCMSys TCMSys;

        private TABSys.TABSys TABSys;

        private SCMSys.SCMSys SCMSys;

        private HTPSys.HTPSys HTPSys;

        private MoneySys.MoneySys MoneySys;

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
            HTPSys.HTPSysI();
        }
        private void LoadMoneySys()
        {
            MoneySys.MoneySysI();
        }
    }
}