
namespace project_pkdsim.Assets.USys.TCMSys.splitter
{
    public class TCMSysI
    {
        protected LoadNGame.LoadNGame loadNewGame;
        protected LoadSGame.LoadSGame loadSavedGame;

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
