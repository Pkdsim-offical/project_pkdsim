using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace project_pkdsim.Assets.Editor.Workspaces.AASys.CloudSaveInitializerSys
{
    public class AA_CLSASys : MonoBehaviour
    {
        private async void Start()
        {
            // Initialize Unity Services
            await UnityServices.InitializeAsync();

            // Sign in anonymously
            await SignInAnonymously();

            // Save data to Cloud Save
            await SaveDataAsync();
        }

        private async Task SignInAnonymously()
        {
            // Check if the player is already signed in
            if (AuthenticationService.Instance.IsSignedIn) 
            {
                return;
            }
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                Debug.Log("Signed in anonymously.");
            }
            catch (System.Exception e)
            {
                Debug.LogError($"Failed to sign in: {e.Message}");
            }
        }

        private async Task SaveDataAsync()
        {
            var data = new Dictionary<string, object>
            {
                { "MySaveKey", "HelloWorld" }
            };

            try
            {
                await CloudSaveService.Instance.Data.Player.SaveAsync(data);
                Debug.Log("Data saved successfully.");
            }
            catch (System.Exception e)
            {
                Debug.LogError($"Failed to save data: {e.Message}");
            }
        }
            private async void CloudSaveInitializer()
            {
                if (UnityServices.State == ServicesInitializationState.Initialized)
                {
                    await SignInAnonymously();
                    await SaveDataAsync();
                }
            }
            public void AASys_CloudSaveInitializer()
            {
                CloudSaveInitializer();
            }
        
    }
}