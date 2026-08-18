using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Rings.Modules.Properties;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.RIngs.Modules.LoadJson;
using UnityEngine;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Rings.Modules.Merger
{
	public class Rings_PropertiesMerger : MonoBehaviour
	{
		private RingsPropertiesI RingsPropertiesI;

		private LoadRIngsJson LoadRingsJsons;

		public void LoadProperties(string value)
		{
			RingsPropertiesI.Rings_LoadPropertiesBase(value);
		}
		public void Load_Rings_Jsons()
		{
			LoadRingsJsons.LoadRIngsJsons();
		}
	}
}