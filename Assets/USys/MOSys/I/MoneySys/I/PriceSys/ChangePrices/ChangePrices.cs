using project_pkdsim.Assets.USys.MoneySys.I.PRICESys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.MoneySys.I.PRICESys.ChangePrices.I.ChangePrices
{
	public class ChangePrice : MonoBehaviour
	{
		// Use this for initialization
		private ChangePricesI ChangePrices;
		public void ChangePricesI() 
		{
			ChangePrices.LoadPrice();
		}
	}
}