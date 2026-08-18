using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Ground.Crust_necklace;
using UnityEngine;

namespace project_pkdsim.USysUItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Ground
{
	public class Ground_Necklace : MonoBehaviour
	{
		private Crust_NecklaceItem Crust_NecklaceItem;

		public void Get_CrustNecklace()
		{
			Crust_NecklaceItem.GetBuilder();
		}
	}
}