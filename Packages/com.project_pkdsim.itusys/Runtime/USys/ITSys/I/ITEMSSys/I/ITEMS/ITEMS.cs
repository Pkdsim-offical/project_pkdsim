using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Gifts;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Holiday;
using project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.PkPhone;
using UnityEngine;
namespace project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts
{
    public class ITEMS_Main : MonoBehaviour
    {
        protected PkPhone_Item pkphone;
        protected HolidayItem HolidayItem;

        protected GIfts gifts;
        protected void ITEM_Inventory(string inventory) 
        { 
            pkphone.Get_Inventory(inventory);
        }
        protected void ITEM_Holiday(string holiday)
        {
            HolidayItem.LoadItems(holiday);
        }
        protected void ITEM_GIFTS(string value)
        {
            gifts.LoadGifts(value);
        }
    }
}