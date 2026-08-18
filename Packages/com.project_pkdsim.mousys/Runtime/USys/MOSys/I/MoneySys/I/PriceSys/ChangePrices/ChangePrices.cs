using project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.PRICESys.ChangePrices.Modules.ChangePrices;
using UnityEngine;

namespace project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.PRICESys.ChangePrices.Modules.ChangePrices
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