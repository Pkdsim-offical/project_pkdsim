using UnityEngine;
using project_pkdsim.Assets.USys.TCMSys.splitter;

namespace project_pkdsim.Assets.USys.TCMSys
{
    public class TCMSys : MonoBehaviour {

        private TCMSysI TCMSys_I;
        public void LoadNewGame()
        {
            TCMSys_I.LNG(); // Replace "Level1" with the name of your new game scene
        }

        public void LoadSavedGame()
        {
            // Add logic for loading a saved game if applicable
            TCMSys_I.LSG(); // Replace with your saved game scene name
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    }
}