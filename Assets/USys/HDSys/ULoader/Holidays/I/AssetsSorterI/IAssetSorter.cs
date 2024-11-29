using project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.BlackFriday;
using project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.Christmas;
using project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.Columbus_Day;
using project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.CyberMonday;
using project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.Easter;
using project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.Fathers_Day;
using project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.Halloween;
using project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.Independence_Day;
using project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.Labor_Day;
using project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.MartinLutherKing_Day;
using project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.Memorial_Day;
using project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.Mothers_Day;
using project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.NewYear;
using project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.Presidents_Day;
using project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.Thanksgiving;
using project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.Valentines_Day;
using project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.Veterans_Day;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.I.AssetsSorterI
{
	public class IAssetSorter : MonoBehaviour
	{
		private BlackFriday_IAssets BlackFriday;
		private Christmas_IAssets Christmas;
		private Easter_IAssets Easter;
		private NewYears_IAssets NewYears;
		private Thanksgiving_IAssets Thanksgiving;
		private Columbus_Day_IAssets ColumbusDay;
		private Independence_Day_IAssets IndependenceDay;
		private Memorial_Day_IAssets MemorialDay;
		private Labor_Day_IAssets LaborDay;
		private MartinLutherKing_Day_IAssets MartinLutherKingDay;
		private Presidents_Day_IAssets PresidentsDay;
		private Veterans_Day_IAssets VeteransDay;
		private Valentines_Day_IAssets ValentinesDay;
		private CyberMonday_IAssets CyberMonday;
		private Halloween_IAssets Halloween;
		private Fathers_Day_IAssets FathersDay;
		private Mothers_Day_IAssets MothersDay;

		protected static void LoadAllHolidays()
		{
			LoadSpecificHolidays();
		}

		protected static void LoadSpecificHolidays()
		{
			LoadBlackFriday();
			LoadEaster();
			LoadChristmas();
			LoadNewYear();
			LoadIndependenceDay();
			LoadMemorialDay();
			LoadLaborDay();
			LoadMartinLutherKingDay();
			LoadPresidentsDay();
			LoadVeteransDay();
			LoadThanksgivingDay();
			LoadValentinesDay();
			LoadCyberMonday();
			LoadHalloween();
			LoadFathersDay();
			LoadMothersDay();
			LoadColumbusDay();
		}

		protected static void LoadBlackFriday() => BlackFriday_IAssets.LoadBlackFridayHAssets();
		protected static void LoadEaster() => Easter_IAssets.LoadEasterHAssets();
		protected static void LoadChristmas() => Christmas_IAssets.LoadChristmasHAssets();
		protected static void LoadNewYear() => NewYears_IAssets.LoadNewYearsHAssets();
		protected static void LoadColumbusDay() => Columbus_Day_IAssets.LoadColumbusHAssets();
		protected static void LoadIndependenceDay() => Independence_Day_IAssets.LoadIndependence_DayHAssets();
		protected static void LoadMemorialDay() => Memorial_Day_IAssets.LoadMemorial_DayHAssets();
		protected static void LoadLaborDay() => Labor_Day_IAssets.LoadLabor_DayHAssets();
		protected static void LoadMartinLutherKingDay() => MartinLutherKing_Day_IAssets.LoadMartinLutherKingDayHAssets();
		protected static void LoadPresidentsDay() => Presidents_Day_IAssets.LoadPresidents_DayHAssets();
		protected static void LoadVeteransDay() => Veterans_Day_IAssets.LoadVeterans_DayHAssets();
		protected static void LoadThanksgivingDay() => Thanksgiving_IAssets.LoadThanksgivingHAssets();
		protected static void LoadValentinesDay() => Valentines_Day_IAssets.LoadValentines_DayHAssets();
		protected static void LoadCyberMonday() => CyberMonday_IAssets.LoadCyberMondayHAssets();
		protected static void LoadHalloween() => Halloween_IAssets.LoadHalloweenHAssets();
		protected static void LoadFathersDay() => Fathers_Day_IAssets.LoadFathers_DayHAssets();
		protected static void LoadMothersDay() => Mothers_Day_IAssets.LoadMothers_DayHAssets();
	}
}
