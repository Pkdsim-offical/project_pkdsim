using project_pkdsim.USys.TABSys.Modules.TabManagerSys;

namespace project_pkdsim.USys.TABSys.Modules
{
    public class TABSSysI
    {
        private TABSManagerSys TABSManagerSys;
        public void TABSSys_I()
        {
            GetTABSSys();
        }
        private void GetTABSSys()
        {
            TABSManagerSys.TABSSysI();
        }
    }
}