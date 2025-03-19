using project_pkdsim.Assets.USys.USystemsSys.ITEMS.ItemsScripts.Gifts;
using project_pkdsim.Assets.USys.USystemsSys.ITEMS.ItemsScripts.Holiday.HolidayITEM;
using project_pkdsim.Assets.USys.USystemsSys.ITEMS.ItemsScripts.PkPhone;
using UnityEngine;
namespace project_pkdsim.Assets.USys.USystemsSys.ITEMS.ItemsScripts
{
    public class ITEMS_Main : MonoBehaviour
    {
        protected PkPhone_Item pkphone;
        protected HolidayItem HolidayItem;

        protected GIfts gifts;
        protected void ITEM_Inventory() 
        { 
            pkphone.Get_Game_object();
        }
        protected void ITEM_Holiday()
        {
            HolidayItem.LoadItems();
        }
        protected void ITEM_GIFTS(string value)
        {
            gifts.LoadGifts(value);
        }
    }
}