using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Electric.Bolt_necklace;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Electric.Spark_necklace;
using UnityEngine;

namespace project_pkdsim.USysUItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Electric
{
	public class Electric_Necklace : MonoBehaviour
	{
		private Bolt_NecklaceItem Bolt_NecklaceItem;
		private Spark_NecklaceItem Spark_NecklaceItem;

		public void Get_BoltNecklace()
		{
			Bolt_NecklaceItem.GetBuilder();
		}
		public void Get_SparkNecklace()
		{
			Spark_NecklaceItem.GetBuilder();
		}
	}
}