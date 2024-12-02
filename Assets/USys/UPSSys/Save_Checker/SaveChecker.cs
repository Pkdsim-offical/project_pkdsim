using UnityEngine;
using UnityEngine.UI;
using System.IO;

namespace project_pkdsim.Assets.USys.UPSSys.Save_Checker
{
	public class SaveChecker : MonoBehaviour
	{
		private class PData
		{
			public static int Build_Version = 2; // Updated Build Version
		}

		private int playerDataVersion = 1; // Default player version, to be loaded from file

		public GameObject outdatedPanel;
		public Text outdatedText;

		private string saveFilePath;

		private void Start()
		{
			saveFilePath = Application.persistentDataPath + "/savegame.json"; // File path
			LoadPlayerData();
			PlayerData_Checker();  // Call the version checker
		}

		// Method to check if the player's data is outdated
		public void PlayerData_Checker()
		{
			// Check if the player's version is less than the current build version
			if (playerDataVersion < PData.Build_Version)
			{
				Show_OutdatedVersion();  // Show the warning panel
			}
			else
			{
				Hide_OutdatedVersion();  // Hide the panel if up-to-date
			}
		}

		// Method to display the outdated version panel
		private void Show_OutdatedVersion()
		{
			if (outdatedPanel != null && outdatedText != null)
			{
				outdatedPanel.SetActive(true);  // Enable the UI panel
				outdatedText.text = "Your save file is outdated. Please update to the latest version.";  // Set the warning message
			}
		}

		// Method to hide the outdated version panel if the version is current
		private void Hide_OutdatedVersion()
		{
			if (outdatedPanel != null)
			{
				outdatedPanel.SetActive(false);  // Disable the UI panel
			}
		}

		// Load the player's version data from a save file
		private void LoadPlayerData()
		{
			if (File.Exists(saveFilePath))
			{
				string json = File.ReadAllText(saveFilePath);
				PlayerSaveData saveData = JsonUtility.FromJson<PlayerSaveData>(json);

				// Set the playerDataVersion to the version in the save file
				playerDataVersion = saveData.playerVersion;
			}
			else
			{
				Debug.LogWarning("Save file not found. Default version will be used.");
			}
		}

		// Class representing player save data (include version)
		[System.Serializable]
		private class PlayerSaveData
		{
			public int playerVersion = 1;  // Default version for old saves
		}
	}
}
