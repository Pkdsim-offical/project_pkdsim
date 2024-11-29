using project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.BlackFriday;
using project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.Christmas;
using project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.CyberMonday;
using project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.Fathers_Day;
using project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.Halloween;
using project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.Independence_Day;
using project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.Mothers_Day;
using project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.NewYear;
using project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.Thanksgiving;
using project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.Memorial_Day;
using project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.CincoDeMayo;
using project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.MartinLutherKing_Day;
using project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.Veterans_Day;
using project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.Presidents_Day;
using project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.Valentines_Day;
using project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.Labor_Day;

using project_pkdsim.Assets.USys.PriceSys.ChangePrices.I;
using UnityEngine;
using System.Collections.Generic;
using System;
using project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.Veterans_Day;
using project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.Valentines_Day;
using project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.Presidents_Day;
using project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.Easter;

namespace project_pkdsim.Assets.Models.USys.PriceSys.LoadPrices.I
{
	public class Load_PricesI : ChangePricesI
	{
		protected static bool? LoadBlackFridaySalesWrapper()
		{
			BlackFriday_IAssetLoader.LoadBlackFridaySales();
			return true;
		}

		protected static bool? LoadChristmasSalesWrapper()
		{
			Christmas_IAssetLoader.LoadChristmasSales();
			return true;
		}

		protected static bool? LoadHalloweenSalesWrapper()
		{
			Halloween_IAssetLoader.LoadHalloweenSales();
			return true;
		}

		protected static bool? LoadNewYearsSalesWrapper()
		{
			NewYears_IAssetsLoader.LoadNewYearsSales();
			return true;
		}

		protected static bool? LoadCyberMondaySalesWrapper()
		{
			CyberMonday_IAssetLoader.LoadCyberMondaySales();
			return true;
		}

		protected static bool? LoadMothers_DaySalesWrapper()
		{
			Mothers_Day_IAssetsLoader.LoadMothers_DaySales();
			return true;
		}

		protected static bool? LoadFathers_DaySalesWrapper()
		{
			Fathers_Day_IAssetsLoader.LoadFathers_DaySales();
			return true;
		}

		protected static bool? LoadIndependence_DaySalesWrapper()
		{
			Independence_Day_IAssetsLoader.LoadIndependence_DaySales();
			return true;
		}

		protected static bool? LoadMemorial_DaySalesWrapper()	
		{
			Memorial_Day_IAssetsLoader.LoadMemorial_DaySales();
			return true;
		}

		protected static bool? LoadThanksgivingSalesWrapper()
		{
			Thanksgiving_IAssetsLoader.LoadThanksgivingSales();
			return true;
		}

		protected static bool? LoadCincoDeMayoHAssetsWrapper()
		{
			CincoDeMayo_IAssetsLoader.LoadCincoDeMayoHAssets();
			return true;
		}

		protected static bool? LoadMartinLutherKingDayHAssetsWrapper()
		{
			MartinLutherKing_Day_IAssetsLoader.LoadMartinLutherKingDayHAssets();
			return true;
		}
		protected static bool? LoadVeterans_DaySalesWrapper()
		{
			Veterans_Day_IAssetsLoader.LoadVeterans_DaySales();
			return true;
		}

		protected static bool? LoadPresidents_DaySalesWrapper()
		{
			Presidents_Day_IAssetsLoader.LoadPresidents_DaySales();
			return true;
		}

		protected static bool? LoadValentines_DaySalesWrapper()
		{
			Valentines_Day_IAssetsLoader.LoadValentines_DaySales();
			return true;
		}
		
		protected static bool? LoadLabor_DaySalesWrapper()
		{
			Labor_Day_IAssetsLoader.LoadLabor_DaySales();
			return true;
		}
		protected static bool? LoadEasterSalesWrapper()
		{
			Easter_IAssetsLoader.LoadEasterSales();
			return true;
		}
		private static readonly Dictionary<string, (Func<bool?> loader, Action priceLoader)> holidayPriceMap = new()
		{
			{ "BlackFriday", ((Func<bool?>)LoadBlackFridaySalesWrapper, (Action)ChangePricesI.LoadBlackFridayPrices) },
			{ "Christmas", ((Func<bool?>)LoadChristmasSalesWrapper, (Action)ChangePricesI.LoadChristmasPrices) },
			{ "Halloween", ((Func<bool?>)LoadHalloweenSalesWrapper, (Action)ChangePricesI.LoadHalloweenPrices) },
			{ "NewYears", ((Func<bool?>)LoadNewYearsSalesWrapper, (Action)ChangePricesI.LoadNewYearPrices) },
			{ "CyberMonday", ((Func<bool?>)LoadCyberMondaySalesWrapper, (Action)ChangePricesI.LoadCyberMondayPrices) },
			{ "MothersDay", ((Func<bool?>)LoadMothers_DaySalesWrapper, (Action)ChangePricesI.LoadMothers_DayPrices) },
			{ "FathersDay", ((Func<bool?>)LoadFathers_DaySalesWrapper, (Action)ChangePricesI.LoadFathers_DayPrice) },
			{ "IndependenceDay", ((Func<bool?>)LoadIndependence_DaySalesWrapper, (Action)ChangePricesI.LoadIndependence_DayPrices) },
			{ "MemorialDay", ((Func<bool?>)LoadMemorial_DaySalesWrapper, (Action)ChangePricesI.LoadMemorial_DayPrices) },
			{ "Thanksgiving", ((Func<bool?>)LoadThanksgivingSalesWrapper, (Action)ChangePricesI.LoadThanksgivingPrices) },
			{ "CincoDeMayo", ((Func<bool?>)LoadCincoDeMayoHAssetsWrapper, (Action)ChangePricesI.LoadCincoDeMayoPrices) },
			{ "MartinLutherKingDay", ((Func<bool?>)LoadCincoDeMayoHAssetsWrapper, (Action)ChangePricesI.LoadMartinLutherKingDayPrices) },
			{ "VeteransDay", ((Func<bool?>)LoadVeterans_DaySalesWrapper, (Action)ChangePricesI.LoadVeterans_DayPrice) },
			{ "PresidentsDay", ((Func<bool?>)LoadPresidents_DaySalesWrapper, (Action)ChangePricesI.LoadPresidents_DayPrice) },
			{ "LaborDay", ((Func<bool?>)LoadLabor_DaySalesWrapper, (Action)ChangePricesI.LoadLabor_DayPrices) },
			{ "Easter", ((Func<bool?>)LoadEasterSalesWrapper, (Action)ChangePricesI.LoadEasterPrices) },
			{ "ValentinesDay", ((Func<bool?>)LoadValentines_DaySalesWrapper, (Action)ChangePricesI.LoadValentines_DayPrices) }
		};

		public static void LoadPriceI()
		{
			bool holidayAssetLoaded = false;

			foreach (var holiday in holidayPriceMap)
			{
				var (assetLoader, priceLoader) = holiday.Value;
				var loadResult = assetLoader();

				if (loadResult == true)
				{
					priceLoader();
					holidayAssetLoaded = true;
					break;
				}
			}

			if (!holidayAssetLoaded)
			{
				if (AllHolidayAssetsNull())
				{
					Debug.Log("No holiday assets loaded.");
				}
				else
				{
					Load_NormalPrices();
				}
			}
		}

		protected static bool AllHolidayAssetsNull()
		{
			foreach (var holiday in holidayPriceMap)
			{
				if (holiday.Value.loader() != null) return false;
			}
			return true;
		}

		public static void Load_NormalPrices()
		{
			ChangePricesI.LoadNormalPrices();
		}
	}
}
