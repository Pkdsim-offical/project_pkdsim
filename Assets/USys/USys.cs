using UnityEngine;

namespace project_pkdsim.Assets.USys
{
    public class USys : MonoBehaviour
    {
        private AIRoutesSys.AIRSys AIRSys;

        private HDSys.HDSys HolidaySys;

        private ITEMSSys.ITEMSSys Itemssys;

        private StockSys.StockSys StockSys;
        private LOVESys.LOVESys LoveSys;

        private UPSSys.UPSSys UPSSys;

        private TCMSys.TCMSys TCMSys;

        private TABSys.TABSys TABSys;

        private SCMSys.SCMSys SCMSys;

        private PriceSys.PriceSys PriceSys;

        protected USys()
        {
            AIRSys = new AIRoutesSys.AIRSys();
            HolidaySys = new HDSys.HDSys();
            Itemssys = new ITEMSSys.ITEMSSys();
            LoveSys = new LOVESys.LOVESys();
            UPSSys = new UPSSys.UPSSys();
            TCMSys = new TCMSys.TCMSys();
            TABSys = new TABSys.TABSys();
            SCMSys = new SCMSys.SCMSys();
            StockSys = new StockSys.StockSys();
            PriceSys = new PriceSys.PriceSys();
        }
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
            LoadStockSys();
            LoadPriceSys();
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
        private void LoadStockSys()
        {
            StockSys.StockSysI();
        }
        private void LoadPriceSys()
        {
            PriceSys.PriceSysI();
        }
    }
}