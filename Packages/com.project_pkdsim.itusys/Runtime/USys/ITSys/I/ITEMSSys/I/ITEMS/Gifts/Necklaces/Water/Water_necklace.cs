using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Water.Water_Droplet_necklace;
using UnityEngine;

namespace project_pkdsim.USysUItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Water
{
	public class Water_necklace : MonoBehaviour
	{
		private Water_Droplet_NecklaceItem WaterDroplet_NecklaceItem;

		public void Get_WaterDropletNecklace()
		{
			WaterDroplet_NecklaceItem.GetBuilder();
		}
	}
}