using project_pkdsim.Assets.USys.UTPSys.UHousesTeleporterSys;
using UnityEngine;

namespace project_pkdsim.Assets.USys.TeleporterSys
{
	public class UnityTeleporterSys : MonoBehaviour 
	{
		private UHTeleporterSys UHTeleporterSys;
		public void UTPSysI()
		{
			UHTeleporterSys.UHTPSysI();
		}
	}
}