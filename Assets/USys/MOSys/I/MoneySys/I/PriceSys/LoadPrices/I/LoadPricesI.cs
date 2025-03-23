using project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.BlackFriday;
using project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.Christmas;
using project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.Halloween;
using project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.NewYear;
using project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.CyberMonday;
using project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.Mothers_Day;
using project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.Fathers_Day;
using project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.Independence_Day;
using project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.Thanksgiving;
using project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.Labor_Day;
using project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.Memorial_Day;
using project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.Columbus_Day;
using project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.Veterans_Day;
using project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.Presidents_Day;
using project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.Easter;
using project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.Valentines_Day;
using project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.CincoDeMayo;
using UnityEngine;
using System;
using System.Collections.Generic;
using project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.MartinLutherKing_Day;
using project_pkdsim.Assets.USys.MoneySys.I.PRICESys.ChangePrices.I.NormalPrices;

namespace project_pkdsim.Assets.USys.MoneySys.I.PRICESys.ChangePrices.I.LoadPrices.I
{
	public class Load_PricesI : ChangePricesI
	{
		private PriceSys_NormalPrices PriceSys_NormalPrices;
		public void LoadPriceI()
		{
			bool holidayAssetLoaded = false;

			foreach (var holiday in holidayPriceMap)
			{
				var (assetLoader, priceLoader) = holiday.Value;
				var loadResult = assetLoader;

				if (loadResult == true)
				{
					priceLoader();
					holidayAssetLoaded = true;
					break;
				}
			}

			if (!holidayAssetLoaded)
			{
				if ((bool)AllHolidayAssetsNull())
				{
					Debug.Log("No holiday assets loaded.");
				}
				else
				{
					Load_NormalPrices();
				}
			}
		}

        private readonly Dictionary<string, (bool? loader, Action priceLoader)> holidayPriceMap;

        protected bool? LoadBlackFridaySalesWrapper()
		{
			var BlackFriday_IAssetLoader = new BlackFriday_IAssetLoader();
			BlackFriday_IAssetLoader.LoadBlackFridaySales();
			return true;
		}

		protected bool? LoadChristmasSalesWrapper()
		{
			var Christmas_IAssetLoader = new Christmas_IAssetLoader();
			Christmas_IAssetLoader.LoadChristmasSales();
			return true;
		}

		protected bool? LoadHalloweenSalesWrapper()
		{
			var Halloween_IAssetLoader = new Halloween_IAssetLoader();
			Halloween_IAssetLoader.LoadHalloweenSales();
			return true;
		}

		protected bool? LoadNewYearsSalesWrapper()
		{
			var NewYears_IAssetsLoader = new NewYears_IAssetsLoader();
			NewYears_IAssetsLoader.LoadNewYearsSales();
			return true;
		}

		protected bool? LoadCyberMondaySalesWrapper()
		{
			var CyberMonday_IAssetLoader = new CyberMonday_IAssetLoader();
			CyberMonday_IAssetLoader.LoadCyberMondaySales();
			return true;
		}

		protected bool? LoadMothers_DaySalesWrapper()
		{
			var Mothers_Day_IAssetsLoader = new Mothers_Day_IAssetsLoader();
			Mothers_Day_IAssetsLoader.LoadMothers_DaySales();
			return true;
		}

		protected bool? LoadFathers_DaySalesWrapper()
		{
			var Fathers_Day_IAssetsLoader = new Fathers_Day_IAssetsLoader();
			Fathers_Day_IAssetsLoader.LoadFathers_DaySales();
			return true;
		}

		protected bool? LoadIndependence_DaySalesWrapper()
		{
			var Independence_Day_IAssetsLoader = new Independence_Day_IAssetsLoader();
			Independence_Day_IAssetsLoader.LoadIndependence_DaySales();
			return true;
		}

		protected bool? LoadMemorial_DaySalesWrapper()	
		{
			var Memorial_Day_IAssetsLoader = new Memorial_Day_IAssetsLoader();
			Memorial_Day_IAssetsLoader.LoadMemorial_DaySales();
			return true;
		}

		protected bool? LoadThanksgivingSalesWrapper()
		{
			var Thanksgiving_IAssetsLoader = new Thanksgiving_IAssetsLoader();
			Thanksgiving_IAssetsLoader.LoadThanksgivingSales();
			return true;
		}

		protected bool? LoadCincoDeMayoHAssetsWrapper()
		{
			var CincoDeMayo_IAssetsLoader = new CincoDeMayo_IAssetsLoader();
			CincoDeMayo_IAssetsLoader.LoadCincoDeMayoHAssets();
			return true;
		}

		protected bool? LoadMartinLutherKingDayHAssetsWrapper()
		{
			var MartinLutherKing_Day_IAssetsLoader = new MartinLutherKing_Day_IAssetsLoader();
			MartinLutherKing_Day_IAssetsLoader.LoadMartinLutherKing_DaySales();
			return true;
		}
		protected bool? LoadVeterans_DaySalesWrapper()
		{
			var Veterans_Day_IAssetsLoader = new Veterans_Day_IAssetsLoader();
			Veterans_Day_IAssetsLoader.LoadVeterans_DaySales();
			return true;
		}

		protected bool? LoadPresidents_DaySalesWrapper()
		{
			var Presidents_Day_IAssetsLoader = new Presidents_Day_IAssetsLoader();
			Presidents_Day_IAssetsLoader.LoadPresidents_DaySales();
			return true;
		}

		protected bool? LoadValentines_DaySalesWrapper()
		{
			var Valentines_Day_IAssetsLoader = new Valentines_Day_IAssetsLoader();
			Valentines_Day_IAssetsLoader.LoadValentines_DaySales();
			return true;
		}
		
		protected bool? LoadLabor_DaySalesWrapper()
		{
			var Labor_Day_IAssetsLoader = new Labor_Day_IAssetsLoader();
			Labor_Day_IAssetsLoader.LoadLabor_DaySales();
			return true;
		}
		protected bool? LoadEasterSalesWrapper()
		{
			var Easter_IAssetsLoader = new Easter_IAssetsLoader();
			Easter_IAssetsLoader.LoadEasterSales();
			return true;
		}
		protected bool? LoadColumbus_DaySalesWrapper()
		{
			var Columbus_Day_IAssetsLoader = new Columbus_Day_IAssetsLoader();
			Columbus_Day_IAssetsLoader.LoadColumbus_DaySales();
			return true;
		}
		protected bool? AllHolidayAssetsNull()
		{
			foreach (var holiday in holidayPriceMap)
			{
				if (holiday.Value.loader != null) 
				return false;
			}
			return true;
		}

		public void Load_NormalPrices()
		{
			PriceSys_NormalPrices.LoadNormalPrices();
		}
		
		private bool? LoadHolidaySales<T>(Action<T> loadAction) where T : new()
		{
			var loader = new T();
			loadAction(loader);
			return true;
		}
	}
}
