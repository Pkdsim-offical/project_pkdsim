using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Fairy.Heart_necklace;
using UnityEngine;

namespace project_pkdsim.USysUItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Fairy
{
	public class Fairy_Necklace : MonoBehaviour
	{
		private Heart_NecklaceItem Heart_NecklaceItem;

		public void Get_HeartNecklace()
		{
			Heart_NecklaceItem.GetBuilder();
		}
	}
}