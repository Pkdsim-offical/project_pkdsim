using UnityEditor;
using UnityEditor.AddressableAssets.Settings;
using UnityEngine;

namespace project_pkdsim.Assets.Editor.AASys.AA_CASys
{
	public class ClearAddressablesCache : MonoBehaviour
	{
		[MenuItem("Addressables/Clear Cache")]
		public static void ClearCache()
		{
			AddressableAssetSettings.CleanPlayerContent();
			Debug.Log("Addressables cache cleared.");
		}
	}
}