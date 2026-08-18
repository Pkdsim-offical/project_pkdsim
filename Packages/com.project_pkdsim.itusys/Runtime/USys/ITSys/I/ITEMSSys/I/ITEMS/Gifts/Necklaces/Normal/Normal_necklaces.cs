using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Normal.Cat_necklace;
using UnityEngine;

namespace project_pkdsim.USysUItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Normal
{
	public class Normal_Necklaces : MonoBehaviour
	{
		private Cat_NecklaceItem Cat_NecklaceItem;

		public void Get_CatNecklace()
		{
			Cat_NecklaceItem.GetBuilder();
		}
	}
}