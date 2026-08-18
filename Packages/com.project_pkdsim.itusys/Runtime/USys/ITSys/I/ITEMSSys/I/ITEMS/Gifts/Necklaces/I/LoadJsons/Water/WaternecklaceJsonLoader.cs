using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson.Water.WaterDrop_necklace;
using UnityEngine;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson.Water
{
	public class WaternecklaceJsonLoader : MonoBehaviour
	{
		private WaterDroplet_necklaceJsonLoader WaterDroplet_necklaceJsonLoader;
	
		private void Awake()
		{
			WaterDroplet_necklaceJsonLoader.LoadJson();
		}
	}
}