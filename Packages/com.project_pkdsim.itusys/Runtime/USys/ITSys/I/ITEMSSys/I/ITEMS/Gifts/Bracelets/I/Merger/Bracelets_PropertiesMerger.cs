using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Bracelets.Modules.LoadJson;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Bracelets.Modules.Properties;
using UnityEngine;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Bracelets.Modules.Merger
{
	public class Bracelets_PropertiesMerger : MonoBehaviour
	{
		private BraceletsPropertiesI BraceletsPropertiesI;

		private LoadBraceletsJson LoadBraceletsJsons;

		public void LoadProperties(string value)
		{
			BraceletsPropertiesI.Bracelets_LoadPropertiesBase(value);
		}
		public void Load_Bracelets_Jsons()
		{
			LoadBraceletsJsons.LoadBraceletsJsons();
		}
	}
}