using project_pkdsim.Assets.USys.USystemsSys.I;

namespace project_pkdsim.Assets.USys.USystemsSys.INVENTORY 
{
	public class InventorySystem : ITEMSDatabaseSys
	{
		public void Get_Inventory(string value) 
		{
			Get_Items(value);
		}
	}
}