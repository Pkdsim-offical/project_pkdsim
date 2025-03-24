using UnityEngine;

namespace project_pkdsim.Assets.USys.USystemsSys.ITEMS.ItemsScripts.PkPhone
{
	public class PkPhone_Item : MonoBehaviour
	{
		private GameObject pkphone;
		public void Get_Game_object()
		{
			pkphone = GameObject.Find("PkPhone");
		}
	}
}