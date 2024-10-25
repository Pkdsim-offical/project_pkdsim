using UnityEngine;
namespace project_pkdsim.Assets.USys.ITEMSSys.ITEMS
{
    public class ITEMS : MonoBehaviour
    {
        protected PkPhone_Item pkphone;
        protected void ITEM_Inventory() 
        { 
            pkphone.Get_Game_object();
        }
    }
}