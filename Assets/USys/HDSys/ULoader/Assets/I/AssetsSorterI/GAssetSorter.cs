using project_pkdsim.Assets.USys.HDSys.ULoader.Assets.AssetsSorter.BlackFriday;
using project_pkdsim.Assets.USys.HDSys.ULoader.Assets.AssetsSorter.Christmas;
using project_pkdsim.Assets.USys.HDSys.ULoader.Assets.AssetsSorter.Columbus_Day;
using project_pkdsim.Assets.USys.HDSys.ULoader.Assets.AssetsSorter.CyberMonday;
using project_pkdsim.Assets.USys.HDSys.ULoader.Assets.AssetsSorter.Easter;
using project_pkdsim.Assets.USys.HDSys.ULoader.Assets.AssetsSorter.Fathers_Day;
using project_pkdsim.Assets.USys.HDSys.ULoader.Assets.AssetsSorter.Halloween;
using project_pkdsim.Assets.USys.HDSys.ULoader.Assets.AssetsSorter.Independence_Day;
using project_pkdsim.Assets.USys.HDSys.ULoader.Assets.AssetsSorter.Labor_Day;
using project_pkdsim.Assets.USys.HDSys.ULoader.Assets.AssetsSorter.MartinLutherKing_Day;
using project_pkdsim.Assets.USys.HDSys.ULoader.Assets.AssetsSorter.Memorial_Day;
using project_pkdsim.Assets.USys.HDSys.ULoader.Assets.AssetsSorter.Mothers_Day;
using project_pkdsim.Assets.USys.HDSys.ULoader.Assets.AssetsSorter.NewYear;
using project_pkdsim.Assets.USys.HDSys.ULoader.Assets.AssetsSorter.Presidents_Day;
using project_pkdsim.Assets.USys.HDSys.ULoader.Assets.AssetsSorter.Thanksgiving;
using project_pkdsim.Assets.USys.HDSys.ULoader.Assets.AssetsSorter.Valentines_Day;
using project_pkdsim.Assets.USys.HDSys.ULoader.Assets.AssetsSorter.Veterans_Day;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HDSys.ULoader.Assets.I.AssetsSorterI
{
	public class GAssetSorter : MonoBehaviour
	{
		private BlackFriday_GAssets BlackFriday;
		private Christmas_GAssets Christmas;
		private Easter_GAssets Easter;
		private NewYears_GAssets NewYears;
		private Thanksgiving_GAssets Thanksgiving;
		private Columbus_Day_GAssets ColumbusDay;
		private Independence_Day_GAssets IndependenceDay;
		private Memorial_Day_GAssets MemorialDay;
		private Labor_Day_GAssets LaborDay;
		private MartinLutherKing_Day_GAssets MartinLutherKingDay;
		private Presidents_Day_GAssets PresidentsDay;
		private Veterans_Day_GAssets VeteransDay;
		private Valentines_Day_GAssets ValentinesDay;
		private CyberMonday_GAssets CyberMonday;
		private Halloween_GAssets Halloween;
		private Fathers_Day_GAssets FathersDay;
		private Mothers_Day_GAssets MothersDay;

		protected void LoadAllHolidays()
		{
			LoadSpecificHolidays();
		}

		protected void LoadSpecificHolidays()
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

		protected void LoadBlackFriday() => BlackFriday_GAssets.loadBlackFridayHAssets();
		protected void LoadEaster() => Easter_GAssets.LoadEasterHAssets();
		protected void LoadChristmas() => Christmas_GAssets.loadChristmasHAssets();
		protected void LoadNewYear() => NewYears_GAssets.loadNewYearsHAssets();
		protected void LoadColumbusDay() => Columbus_Day_GAssets.loadColumbusHAssets();
		protected void LoadIndependenceDay() => Independence_Day_GAssets.loadIndependence_DayHAssets();
		protected void LoadMemorialDay() => Memorial_Day_GAssets.loadMemorial_DayHAssets();
		protected void LoadLaborDay() => Labor_Day_GAssets.loadLabor_DayHAssets();
		protected void LoadMartinLutherKingDay() => MartinLutherKing_Day_GAssets.loadMartinLutherKingDayHAssets();
		protected void LoadPresidentsDay() => Presidents_Day_GAssets.loadPresidents_DayHAssets();
		protected void LoadVeteransDay() => Veterans_Day_GAssets.loadVeterans_DayHAssets();
		protected void LoadThanksgivingDay() => Thanksgiving_GAssets.loadThanksgivingHAssets();
		protected void LoadValentinesDay() => Valentines_Day_GAssets.loadValentines_DayHAssets();
		protected void LoadCyberMonday() => CyberMonday_GAssets.loadCyberMondayHAssets();
		protected void LoadHalloween() => Halloween_GAssets.loadHalloweenHAssets();
		protected void LoadFathersDay() => Fathers_Day_GAssets.loadFathers_DayHAssets();
		protected void LoadMothersDay() => Mothers_Day_GAssets.loadMothers_DayHAssets();
	}
}
