using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts;

namespace project_pkdsim.USys.UItemsSystemSys.Modules
{
	public class ITEMSDatabaseSys : ITEMS_Main
	{
		protected void Get_Items(string gifts, string holiday, string inventory)
		{
			ITEM_Inventory(inventory);
			ITEM_Holiday(holiday);
			ITEM_GIFTS(gifts);
		}
		public void ITEMSSysI() 
		{
			// Load Items
			// gifts, holiday, inventory
			Get_Items("", "", "");
		}
	}
}