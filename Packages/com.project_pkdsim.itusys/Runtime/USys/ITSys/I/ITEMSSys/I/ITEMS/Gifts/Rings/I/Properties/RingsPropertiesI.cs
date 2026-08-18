using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Rings.Modules.Base_Properties;
using UnityEngine;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts.Rings.Modules.Properties
{
	public class RingsPropertiesI : MonoBehaviour
	{
		private RingsLoveEffectPropertiesBase Base_Properties;
		public void Rings_LoadPropertiesBase(string value)
		{
			Base_Properties.LoadValues(value);
		}
	}
}