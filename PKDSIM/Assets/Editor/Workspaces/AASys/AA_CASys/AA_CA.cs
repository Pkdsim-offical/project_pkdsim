using UnityEditor;
using UnityEditor.AddressableAssets.Settings;
using UnityEngine;

namespace project_pkdsim.Assets.Editor.Workspaces.AASys.ClearAddressablesCacheSys
{
	public class AA_CASys : MonoBehaviour
	{
		[MenuItem("Jobs/Tools/Addressables/Clear Cache")]
		private void ClearCache()
		{
			AddressableAssetSettings.CleanPlayerContent();
			Debug.Log("Addressables cache cleared.");
		}
		public void AASys_ClearCacheInitializer()
		{
			ClearCache();
		}
	}
}