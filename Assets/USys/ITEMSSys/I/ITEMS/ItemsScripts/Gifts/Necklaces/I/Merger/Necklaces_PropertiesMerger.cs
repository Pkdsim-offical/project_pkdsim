using project_pkdsim.Assets.USys.USystemsSys.ITEMS.ItemsScripts.Gifts.Necklaces.I.LoadJson;
using project_pkdsim.Assets.USys.USystemsSys.ITEMS.ItemsScripts.Gifts.Necklaces.I.Properties;
using UnityEngine;

namespace project_pkdsim.Assets.USys.USystemsSys.ITEMS.ItemsScripts.Gifts.Necklaces.I.Merger
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