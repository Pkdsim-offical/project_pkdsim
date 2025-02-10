using project_pkdsim.Assets.USys.MoneySys.PriceSys.LoadPrices;
using UnityEngine;

namespace project_pkdsim.Assets.USys.MoneySys.PriceSys.ChangePrices.I
{
	public class ChangePricesI : MonoBehaviour
	{
		private Load_Prices LoadPrices;
		private void LoadBlackFridayPrices()
		{
			LoadPrices.LoadBlackFridayPrices();
		}

		private void LoadChristmasPrices()
		{
			LoadPrices.LoadChristmasPrices();
		}

		private void LoadHalloweenPrices()
		{
			LoadPrices.LoadHalloweenPrices();
		}

		private void LoadNormalPrices()
		{
			LoadPrices.LoadNormalPrices();
		}

		private void LoadNewYearPrices()
		{
			LoadPrices.LoadNewYearPrices();
		}
		
		private void LoadCyberMondayPrices()
		{
			LoadPrices.LoadCyberMondayPrices();
		}

		private void LoadMothers_DayPrices()
		{
			LoadPrices.LoadMothers_DayPrices();
		}

		private void LoadFathers_DayPrices() 
		{
			LoadPrices.LoadFathers_DayPrices();
		}

		private void LoadThanksgivingPrices()
		{
			LoadPrices.LoadThanksgivingPrices();
		}

		private void LoadIndependence_DayPrices()
		{
			LoadPrices.LoadIndependence_DayPrices();
		}

		private void LoadMemorial_DayPrices()
		{
			LoadPrices.LoadMemorial_DayPrices();
		}

		private void LoadCincoDeMayoPrices()
		{
			LoadPrices.LoadCincoDeMayoPrices();
		}

		private void LoadMartinLutherKingDayPrices()
		{
			LoadPrices.LoadMartinLutherKingDayPrices();
		}

		private void LoadValentines_DayPrices()
		{
			LoadPrices.LoadValentines_DayPrices();
		}

		private void LoadVeterans_DayPrices()
		{
			LoadPrices.LoadVeterans_DayPrices();
		}


		private void LoadPresidents_DayPrices()
		{
			LoadPrices.LoadPresidents_DayPrices();
		}

		private void LoadLabor_DayPrices()
		{
			LoadPrices.LoadLabor_DayPrices();
		}
		private void LoadEasterPrices()
		{
			LoadPrices.LoadEasterPrices();
		}

		private void LoadColumbus_DayPrices()
		{
			LoadPrices.LoadColumbus_DayPrices();
		}
		public void LoadPrice()
		{
			LoadBlackFridayPrices();
			LoadChristmasPrices();
			LoadHalloweenPrices();
			LoadNewYearPrices();
			LoadCyberMondayPrices();
			LoadMothers_DayPrices();
			LoadFathers_DayPrices();
			LoadThanksgivingPrices();
			LoadIndependence_DayPrices();
			LoadMemorial_DayPrices();
			LoadCincoDeMayoPrices();
			LoadMartinLutherKingDayPrices();
			LoadValentines_DayPrices();
			LoadVeterans_DayPrices();
			LoadPresidents_DayPrices();
			LoadLabor_DayPrices();
			LoadEasterPrices();
		}
	}
}