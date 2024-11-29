using project_pkdsim.Assets.Models.USys.PriceSys.LoadPrices.I;


namespace project_pkdsim.Assets.USys.PriceSys.LoadPrices
{
	public class Load_Prices : Load_PricesI
	{
		public static void LoadPrices()
		{
			LoadPriceI();
		}

		public static void Load_Normal_Prices()
		{
			Load_PricesI.Load_NormalPrices();
		}
	}
}