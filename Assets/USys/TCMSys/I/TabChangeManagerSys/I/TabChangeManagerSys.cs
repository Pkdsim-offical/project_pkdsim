using project_pkdsim.Assets.USys.TabChangeManagerSys.I.LoadNewGame;
using project_pkdsim.Assets.USys.TabChangeManagerSys.I.LoadSavedGame;

namespace project_pkdsim.Assets.USys.TabChangeManagerSys.I
{
    public class TCMSysI
    {
        protected LoadNGame loadNewGame;
        protected LoadSGame loadSavedGame;

        public void LNG()
        {
            loadNewGame.LoadNewGameI();
        }

        public void LSG()
        {
            loadSavedGame.LoadSavedGameI();
        }
    }
}
