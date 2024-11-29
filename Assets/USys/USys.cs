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
        }
    }
}