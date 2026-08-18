using project_pkdsim.USys.TCMSys.Modules.TabChangeManagerSys.Modules.LoadNewGame;
using project_pkdsim.USys.TCMSys.Modules.TabChangeManagerSys.Modules.LoadSavedGame;
using project_pkdsim.USys.TCMSys.Modules.TabChangeManagerSys.Modules.QuitSavedGame;
using UnityEngine;

namespace project_pkdsim.USys.TCMSys.Modules.TabChangeManagerSys.Modules
{
    public class TABChangeManageSysI : MonoBehaviour
    {
        protected LoadNGame loadNewGame;
        protected LoadSGame loadSavedGame;
        protected QuitGame loadQuitGame;

        public void LNG()
        {
            loadNewGame.LoadNewGameI();
        }

        public void LSG()
        {
            loadSavedGame.LoadSavedGameI();
        }

        public void LQG()
        {
            loadQuitGame.LoadQuitGameI();
        }

        public void TCMSys_I()
        {
            LQG();
            LSG();
            LNG();
        }
    }
}
