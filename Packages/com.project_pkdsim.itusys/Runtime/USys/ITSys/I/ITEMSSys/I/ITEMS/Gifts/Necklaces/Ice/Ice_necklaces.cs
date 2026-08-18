using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Ice.Snowflake_necklace;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Ice.Snowball_necklace;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Ice.Ice_Cube_necklace;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Ice.Ice_Spikes_necklace;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Ice.Ice_Reactor_necklace;
using UnityEngine;

namespace project_pkdsim.USysUItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Ice
{
	public class Ice_Necklaces : MonoBehaviour
	{
		private Snowflake_NecklaceItem Snowflake_NecklaceItem;
		private Snowball_NecklaceItem Snowball_NecklaceItem;
		private Ice_Cube_NecklaceItem Ice_Cube_necklaceItem;
		private Ice_Spikes_NecklaceItem Ice_Spikes_necklaceItem;
		private Ice_Reactor_NecklaceItem Ice_Reactor_necklaceItem;

		public void Get_SnowflakeNecklace()
		{
			Snowflake_NecklaceItem.GetBuilder();
		}
		public void Get_SnowballNecklace()
		{
			Snowball_NecklaceItem.GetBuilder();
		}
		public void Get_IceCubeNecklace()
		{
			Ice_Cube_necklaceItem.GetBuilder();
		}
		public void Get_IceSpikesNecklace()
		{
			Ice_Spikes_necklaceItem.GetBuilder();
		}
		public void Get_IceReactorNecklace()
		{
			Ice_Reactor_necklaceItem.GetBuilder();
		}
	}
}