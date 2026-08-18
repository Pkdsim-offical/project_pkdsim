using project_pkdsim.USys.UItemsSystemSys.Modules;

namespace project_pkdsim.USys.UItemsSystemSys.INVENTORY 
{
	public class InventorySystem : ITEMSDatabaseSys
	{
		public void Get_Inventory() 
		{
			Get_Items("", "", "");
		}
	}
}