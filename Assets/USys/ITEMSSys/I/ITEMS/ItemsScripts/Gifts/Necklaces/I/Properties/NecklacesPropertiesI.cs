using project_pkdsim.Assets.USys.USystemsSys.ITEMS.ItemsScripts.Gifts.Necklaces.I.Base_Properties;
using UnityEngine;

namespace project_pkdsim.Assets.USys.USystemsSys.ITEMS.ItemsScripts.Gifts.Necklaces.I.Properties
{
	public class NecklacesPropertiesI : MonoBehaviour
	{
		private LoveEffectPropertiesBase Base_Properties;
		public void Necklaces_LoadPropertiesBase(string value)
		{
			Base_Properties.LoadValues(value);
		}
	}
}