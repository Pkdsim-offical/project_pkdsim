using project_pkdsim.Assets.USys.HDSys.Toggler.Asset;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HDSys.Toggler
{
	public class HD_toggler : MonoBehaviour
	{
		private HDHoliday_Toggler HDH_Toggler;
		private HDAsset_Toggler HDA_Toggler;

		protected void Get_HDH_Toggler()
		{
			HDH_Toggler = GetComponent<HDHoliday_Toggler>();
			HDH_Toggler.Toggler_Holiday();
		}
		protected void Get_HDA_Toggler()
		{
			HDA_Toggler = GetComponent<HDAsset_Toggler>();
			HDA_Toggler.Asset_Toggler();
		}
	}
}
