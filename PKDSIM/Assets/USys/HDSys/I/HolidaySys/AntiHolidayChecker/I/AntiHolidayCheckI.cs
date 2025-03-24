using project_pkdsim.Assets.USys.HolidaySys.AntiHolidayChecker.Fathers_Day;
using project_pkdsim.Assets.USys.HolidaySys.AntiHolidayChecker.Veterans_Day;
using project_pkdsim.Assets.USys.HolidaySys.AntiHolidayChecker.Thanksgiving;
using project_pkdsim.Assets.USys.HolidaySys.AntiHolidayChecker.Presidents_Day;
using project_pkdsim.Assets.USys.HolidaySys.AntiHolidayChecker.NewYears;
using project_pkdsim.Assets.USys.HolidaySys.AntiHolidayChecker.Valentines_Day;
using project_pkdsim.Assets.USys.HolidaySys.AntiHolidayChecker.Halloween;
using project_pkdsim.Assets.USys.HolidaySys.AntiHolidayChecker.BlackFriday;
using project_pkdsim.Assets.USys.HolidaySys.AntiHolidayChecker.Mothers_Day;
using project_pkdsim.Assets.USys.HolidaySys.AntiHolidayChecker.Columbus_Day;
using project_pkdsim.Assets.USys.HolidaySys.AntiHolidayChecker.Labor_Day;
using project_pkdsim.Assets.USys.HolidaySys.AntiHolidayChecker.Memorial_Day;
using project_pkdsim.Assets.USys.HolidaySys.AntiHolidayChecker.CyberMonday;
using project_pkdsim.Assets.USys.HolidaySys.AntiHolidayChecker.CincoDeMayo;
using project_pkdsim.Assets.USys.HolidaySys.AntiHolidayChecker.Easter;
using project_pkdsim.Assets.USys.HolidaySys.AntiHolidayChecker.Christmas;
using project_pkdsim.Assets.USys.HolidaySys.AntiHolidayChecker.MartinLutherKing_Day;
using project_pkdsim.Assets.USys.HolidaySys.AntiHolidayChecker.Independence_Day;
using UnityEngine;



namespace project_pkdsim.Assets.USys.AntiHolidayCheck.I
{
	public class AntiHolidayCheckI : MonoBehaviour 
	{
		private Memorial_Day_AHDSys_IAssetsLoader memorial_Day_AHDSys_IAssetsLoader;
		private Veterans_Day_AHDSys_IAssetsLoader veterans_Day_AHDSys_IAssetsLoader;
		private Thanksgiving_AHDSys_IAssetsLoader thanksgiving_AHDSys_IAssetsLoader;
		private Presidents_Day_AHDSys_IAssetsLoader presidents_Day_AHDSys_IAssetsLoader;
		private	NewYears_AHDSys_IAssetsLoader newYears_Day_AHDSys_IAssetsLoader;
		private	Valentines_Day_AHDSys_IAssetsLoader valentines_Day_AHDSys_IAssetsLoader;
		private	Halloween_AHDSys_IAssetsLoader halloween_AHDSys_IAssetsLoader;
		private	BlackFriday_AHDSys_IAssetsLoader blackFriday_AHDSys_IAssetsLoader;
		private	Mothers_Day_AHDSys_IAssetsLoader mothers_Day_AHDSys_IAssetsLoader;
		private	Labor_Day_AHDSys_IAssetsLoader labor_Day_AHDSys_IAssetsLoader;
		private	Columbus_Day_AHDSys_IAssetsLoader columbus_Day_AHDSys_IAssetsLoader;
		private	Easter_AHDSys_IAssetsLoader easter_AHDSys_IAssetsLoader;
		private	Christmas_AHDSys_IAssetsLoader christmas_AHDSys_IAssetsLoader;
		private CincoDeMayo_AHDSys_IAssetsLoader cincoDeMayo_AHDSys_IAssetsLoader;
		private CyberMonday_AHDSys_IAssetsLoader cyberMonday_AHDSys_IAssetsLoader;
		private Fathers_Day_AHDSys_IAssetsLoader fathers_Day_AHDSys_IAssetsLoader;
		private MartinLutherKing_Day_AHDSys_IAssetsLoader martinLutherKing_Day_AHDSys_IAssetsLoader;
		private Independence_Day_AHDSys_IAssetsLoader independence_Day_AHDSys_IAssetsLoader;


		// private	St_Patrick_Day_AHDSys_IAssetsLoader
		public void AntiHolidayCheck_I() 
		{
			Get_AntiHolidayCheck_BlackFriday();
			Get_AntiHolidayCheck_Easter();
			Get_AntiHolidayCheck_Fathers_Day();
			Get_AntiHolidayCheck_Halloween();
			Get_AntiHolidayCheck_Independence_Day();
			Get_AntiHolidayCheck_Labor_Day();
			Get_AntiHolidayCheck_Memorial_Day();
			Get_AntiHolidayCheck_Mothers_Day();
			Get_AntiHolidayCheck_NewYears();
			Get_AntiHolidayCheck_Presidents_Day();
			Get_AntiHolidayCheck_Thanksgiving();
			Get_AntiHolidayCheck_Valentines_Day();
			Get_AntiHolidayCheck_Veterans_Day();
			Get_AntiHolidayCheck_CyberMonday();
			Get_AntiHolidayCheck_Columbus_Day();
			Get_AntiHolidayCheck_Christmas();
			Get_AntiHolidayCheck_CincoDeMayo();
			Get_AntiHolidayCheck_MartinLutherKing_Day();
		}
		private void Get_AntiHolidayCheck_Memorial_Day() 
		{
			memorial_Day_AHDSys_IAssetsLoader.Memorial_Day_AHDSys_IAssetLoader();
		}
		private void Get_AntiHolidayCheck_CyberMonday() 
		{
			cyberMonday_AHDSys_IAssetsLoader.CyberMonday_AHDSys_IAssetLoader();
		}
		private void Get_AntiHolidayCheck_Fathers_Day() 
		{
			fathers_Day_AHDSys_IAssetsLoader.Fathers_Day_AHDSys_IAssetLoader();
		}
		private void Get_AntiHolidayCheck_Mothers_Day() 
		{
			mothers_Day_AHDSys_IAssetsLoader.Mothers_Day_AHDSys_IAssetLoader();
		}
		private void Get_AntiHolidayCheck_CincoDeMayo() 
		{
			cincoDeMayo_AHDSys_IAssetsLoader.CincoDeMayo_AHDSys_IAssetLoader();
		}
		private void Get_AntiHolidayCheck_Christmas() 
		{
			christmas_AHDSys_IAssetsLoader.Christmas_AHDSys_IAssetLoader();
		}
		private void Get_AntiHolidayCheck_BlackFriday() 
		{
			blackFriday_AHDSys_IAssetsLoader.BlackFriday_AHDSys_IAssetLoader();
		}
		private void Get_AntiHolidayCheck_Easter() 
		{
			easter_AHDSys_IAssetsLoader.Easter_AHDSys_IAssetLoader();
		}
		private void Get_AntiHolidayCheck_Halloween() 
		{
			halloween_AHDSys_IAssetsLoader.Halloween_AHDSys_IAssetLoader();
		}
		private void Get_AntiHolidayCheck_Independence_Day() 
		{
			independence_Day_AHDSys_IAssetsLoader.Independence_Day_AHDSys_IAssetLoader();
		}
		private void Get_AntiHolidayCheck_MartinLutherKing_Day() 
		{
			martinLutherKing_Day_AHDSys_IAssetsLoader.MartinLutherKing_Day_AHDSys_IAssetLoader();
		}
		private void Get_AntiHolidayCheck_Columbus_Day() 
		{
			columbus_Day_AHDSys_IAssetsLoader.Columbus_Day_AHDSys_IAssetLoader();
		}
		private void Get_AntiHolidayCheck_NewYears() 
		{
			newYears_Day_AHDSys_IAssetsLoader.NewYears_AHDSys_IAssetLoader();
		}
		private void Get_AntiHolidayCheck_Labor_Day() 
		{
			labor_Day_AHDSys_IAssetsLoader.Labor_Day_AHDSys_IAssetLoader();
		}
		private void Get_AntiHolidayCheck_Veterans_Day() 
		{
			veterans_Day_AHDSys_IAssetsLoader.Veterans_Day_AHDSys_IAssetLoader();
		}
		private void Get_AntiHolidayCheck_Valentines_Day() 
		{
			valentines_Day_AHDSys_IAssetsLoader.Valentines_Day_AHDSys_IAssetLoader();
		}
		private void Get_AntiHolidayCheck_Presidents_Day() 
		{
			presidents_Day_AHDSys_IAssetsLoader.Presidents_Day_AHDSys_IAssetLoader();
		}
		private void Get_AntiHolidayCheck_Thanksgiving() 
		{
			thanksgiving_AHDSys_IAssetsLoader.Thanksgiving_AHDSys_IAssetLoader();
		}
	}
}