using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.LoadJson;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.Properties;
using UnityEngine;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Necklaces.Modules.Merger
{
	public class Necklaces_PropertiesMerger : MonoBehaviour
	{
		private NecklacesPropertiesI necklacesPropertiesI;

		private LoadNecklacesJson LoadNecklacesJsons;

		public void LoadProperties(string value)
		{
			necklacesPropertiesI.Necklaces_LoadPropertiesBase(value);
		}
		public void Load_Necklaces_Jsons()
		{
			LoadNecklacesJsons.LoadNecklacesJsons();
		}
	}
}