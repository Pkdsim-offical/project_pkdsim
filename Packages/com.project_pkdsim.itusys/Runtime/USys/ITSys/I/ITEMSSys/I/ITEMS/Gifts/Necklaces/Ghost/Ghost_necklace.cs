using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Ghost.Soul_necklace;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Ghost.Wisp_necklace;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Ghost.Shadow_necklace;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Ghost.Spirit_necklace;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Ghost.Bone_necklace;
using UnityEngine;

namespace project_pkdsim.USysUItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Ghost
{
	public class Ghost_Necklace : MonoBehaviour
	{
		private Soul_NecklaceItem Soul_NecklaceItem;
		private Wisp_NecklaceItem Wisp_NecklaceItem;
		private Shadow_NecklaceItem Shadow_NecklaceItem;
		private Spirit_NecklaceItem Spirit_NecklaceItem;
		private Bone_NecklaceItem Bone_NecklaceItem;

		public void Get_SoulNecklace()
		{
			Soul_NecklaceItem.GetBuilder();
		}

		public void Get_WispNecklace()
		{
			Wisp_NecklaceItem.GetBuilder();
		}

		public void Get_ShadowNecklace()
		{
			Shadow_NecklaceItem.GetBuilder();
		}

		public void Get_SpiritNecklace()
		{
			Spirit_NecklaceItem.GetBuilder();
		}

		public void Get_BoneNecklace()
		{
			Bone_NecklaceItem.GetBuilder();
		}
	}
}