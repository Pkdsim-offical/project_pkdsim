using Unity.Services.CloudSave.Models;

namespace project_pkdsim.Assets.USys.ITEMSSys.INVENTORY 
{
	public class InventorySystem : ITEMSSys
	{
		public void Get_Inventory(string value) 
		{
			Get_Items(value);
		}
	}
}