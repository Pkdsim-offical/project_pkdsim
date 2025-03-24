using project_pkdsim.Assets.USys.USystemsSys.ITEMS.ItemsScripts;

namespace project_pkdsim.Assets.USys.USystemsSys.I
{
	public class ITEMSDatabaseSys : ITEMS_Main
	{
		protected void Get_Items(string value)
		{
			ITEM_Inventory();
			ITEM_Holiday();
			ITEM_GIFTS(value);
		}
		public void ITEMSSysI() 
		{

		}
	}
}