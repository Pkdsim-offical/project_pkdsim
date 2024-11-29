using project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.Labor_Day;
using project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.Memorial_Day;
using project_pkdsim.Assets.USys.ITEMSSys.ITEMS.Holiday.Assets.AssetsSorter.Halloween;
using project_pkdsim.Assets.USys.ITEMSSys.ITEMS.Holiday.Assets.AssetsSorter.Independence_Day;
using project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Holiday.Assets.AssetsSorter.BlackFriday;
using project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Holiday.Assets.AssetsSorter.CincoDeMayo;
using project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Holiday.Assets.AssetsSorter.Columbus_Day;
using project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Holiday.AssetsSorter.Christmas;
using project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Holiday.AssetsSorter.CyberMonday;
using project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Holiday.AssetsSorter.Easter;
using project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Holiday.AssetsSorter.Fathers_Day;
using project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Holiday.AssetsSorter.Labor_Day;
using project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Holiday.AssetsSorter.MartinLutherKing_Day;
using project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Holiday.AssetsSorter.Memorial_Day;
using project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Holiday.AssetsSorter.Mothers_Day;
using project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Holiday.AssetsSorter.NewYear;
using project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Holiday.AssetsSorter.Valentines_Day;
using project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Holiday.AssetsSorter.Veterans_Day;
using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Holiday.HolidayITEM
{
	public class HolidayItem : MonoBehaviour
	{
		private BlackFriday_ITAssets BlackFriday_ITAssets;

		private Christmas_ITAssets Christmas_ITAssets;

		private CincoDeMayo_ITAssets CincoDeMayo_ITAssets;

		private Columbus_Day_ITAssets Columbus_Day_ITAssets;

		private CyberMonday_ITAssets CyberMonday_ITAssets;

		private Easter_ITAssets Easter_ITAssets;

		private Fathers_Day_ITAssets Fathers_Day_ITAssets;

		private Halloween_ITAssets Halloween_ITAssets;

		private Independence_Day_ITAssets Independence_Day_ITAssets;

		private Labor_Day_ITAssets Labor_Day_ITAssets;

		private MartinLutherKing_Day_ITAssets MartinLutherKing_Day_ITAssets;

		private Memorial_Day_ITAssets Memorial_Day_ITAssets;
		
		private Mothers_Day_ITAssets Mothers_Day_ITAssets;

		private NewYears_ITAssets NewYears_ITAssets;

		private Valentines_Day_ITAssets Valentine_Day_ITAssets;

		private Veterans_Day_ITAssets VeteransDay_ITAssets;

		public void LoadItems()
		{
			Get_Items();
		}
		private void Get_Items()
		{
			Get_BlackFriday_ITAssets();
			Get_Christmas_ITAssets();
			Get_CincoDeMayo_ITAssets();
			Get_Columbus_Day_ITAssets();
			Get_CyberMonday_ITAssets();
			Get_Easter_ITAssets();
			Get_Fathers_Day_ITAssets();
			Get_Halloween_ITAssets();
			Get_Independence_Day_ITAssets();
			Get_Labor_Day_ITAssets();
			Get_MartinLutherKing_Day_ITAssets();
			Get_Memorial_Day_ITAssets();
			Get_Mothers_Day_ITAssets();
			Get_NewYears_ITAssets();
			Get_Valentines_Day_ITAssets();
			Get_Veterans_Day_ITAssets();
		}
		private void Get_BlackFriday_ITAssets()
		{
			BlackFriday_ITAssets.LoadBlackFridayITHAssets();
		}

		private void Get_Christmas_ITAssets() 
		{
			Christmas_ITAssets.LoadChristmas_ITHAssets();
		}

		private void Get_CincoDeMayo_ITAssets()
		{
			CincoDeMayo_ITAssets.LoadCincoDeMayo_ITHAssets();
		}

		private void Get_Columbus_Day_ITAssets()
		{
			Columbus_Day_ITAssets.LoadColumbus_DayITHAssets();
		}

		private void Get_CyberMonday_ITAssets()
		{
			CyberMonday_ITAssets.LoadCyberMonday_ITHAssets();
		}

		private void Get_Easter_ITAssets()
		{
			Easter_ITAssets.LoadEaster_ITHAssets();
		}

		private void Get_Fathers_Day_ITAssets()
		{
			Fathers_Day_ITAssets.LoadFathers_DayITHAssets();
		}

		private void Get_Halloween_ITAssets()
		{
			Halloween_ITAssets.LoadHalloweenITHAssets();
		}

		private void Get_Independence_Day_ITAssets()
		{
			Independence_Day_ITAssets.LoadIndependence_DayITHAssets();
		}

		private void Get_Labor_Day_ITAssets()
		{
			Labor_Day_ITAssets.LoadLabor_DayITHAssets();
		}

		private void Get_MartinLutherKing_Day_ITAssets()
		{
			MartinLutherKing_Day_ITAssets.LoadMartinLutherKing_DayITHAssets();
		}

		private void Get_Memorial_Day_ITAssets()
		{
			Memorial_Day_ITAssets.LoadMemorial_DayITHAssets();
		}

		private void Get_Mothers_Day_ITAssets()
		{
			Mothers_Day_ITAssets.LoadMothers_DayITHAssets();
		}

		private void Get_NewYears_ITAssets()
		{
			NewYears_ITAssets.LoadNewYears_ITHAssets();
		}

		private void Get_Valentines_Day_ITAssets()
		{
			Valentines_Day_ITAssets.LoadValentines_DayITHAssets();
		}

		private void Get_Veterans_Day_ITAssets()
		{
			Veterans_Day_ITAssets.LoadVeterans_DayITHAssets();	
		}
	}
}