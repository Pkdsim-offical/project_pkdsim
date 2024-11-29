using project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts;

namespace project_pkdsim.Assets.USys.ITEMSSys
{
	public class ITEMSSys : ITEMS_Main
	{
		protected void Get_Items(string value)
		{
			ITEM_Inventory();
			ITEM_Holiday();
			ITEM_GIFTS(value);
		}
	}
}