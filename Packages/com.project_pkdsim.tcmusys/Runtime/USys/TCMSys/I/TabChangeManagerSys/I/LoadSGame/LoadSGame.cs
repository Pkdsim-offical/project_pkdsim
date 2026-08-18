using UnityEngine.SceneManagement;
using UnityEngine;

namespace project_pkdsim.USys.TCMSys.Modules.TabChangeManagerSys.Modules.LoadSavedGame
{
    public class LoadSGame : MonoBehaviour
    {
        public void LoadSavedGameI()
        {
            // Add logic for loading a saved game if applicable
            SceneManager.LoadScene("SavedGameScene"); // Replace with your saved game scene name
        }
    }
}