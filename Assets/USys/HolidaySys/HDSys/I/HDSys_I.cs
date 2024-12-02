
using project_pkdsim.Assets.USys.HDSys.HDataSys.HolidayDatabase;
using project_pkdsim.Assets.USys.HDSys.ULoader;
using project_pkdsim.Assets.USys.HSys.Base;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HDSys.I
{
	public class HDSys_I : MonoBehaviour
	{
		private Holiday_Base HDSys_Base;

		private HolidayDatabase HDatabaseSys;

		private HDSys_Loader HDSys_Loader;

		private void Awake()
		{
			HDatabaseSys = new HolidayDatabase();
			HDSys_Loader = new HDSys_Loader();
			HDSys_Base = new Holiday_Base();
		}
	}
}