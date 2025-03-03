using project_pkdsim.Assets.USys.MONEYSys.PRICESys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.MONEYSys.PRICESys.ChangePrices.I.ChangePrices
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