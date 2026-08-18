using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Dark.Lunar_necklace;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Dark.Star_necklace;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Dark.Galaxy_necklace;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Dark.Planet_necklace;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Dark.Black_Hole_necklace;
using UnityEngine;

namespace project_pkdsim.USysUItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Dark
{
	public class Dark_Necklace : MonoBehaviour
	{
		private Lunar_NecklaceItem Lunar_NecklaceItem;
		private Star_NecklaceItem Star_NecklaceItem;
		private Galaxy_NecklaceItem Galaxy_NecklaceItem;
		private Planet_NecklaceItem Planet_NecklaceItem;
		private Black_Hole_NecklaceItem Black_Hole_NecklaceItem;

		public void Get_LunarNecklace()
		{
			Lunar_NecklaceItem.GetBuilder();
		}
	}
}