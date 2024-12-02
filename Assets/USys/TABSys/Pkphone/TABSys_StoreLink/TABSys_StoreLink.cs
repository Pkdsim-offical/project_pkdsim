using project_pkdsim.Assets.USys.TABSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_StoreLink.I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.TABSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_StoreLink
{
	public class TABSys_StoreLinker : MonoBehaviour 
	{
		private TABSys_StoreLINK TABSys_StoreLinkI;
		
		public void TABSys_storeLink() 
		{
			TABSys_StoreLinkI.TABSys_StoreMenuI();
		}
	}
}