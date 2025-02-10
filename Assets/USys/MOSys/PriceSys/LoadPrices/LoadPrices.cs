using System;
using project_pkdsim.Assets.USys.MoneySys.PriceSys.LoadPrices.I;


namespace project_pkdsim.Assets.USys.MoneySys.PriceSys.LoadPrices
{
	public class Load_Prices : Load_PricesI
	{
		public void LoadPrices()
		{
			LoadPriceI();
		}

		public void Load_Normal_Prices()
		{
			Load_NormalPrices();
		}
    }
}