using System.Collections.Generic;
using UnityEngine;
using project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Gifts.Necklaces.I.Base_Properties;

namespace project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Gifts.Necklaces.Soul_necklace
{
    public class Soul_NecklaceItem : MonoBehaviour
    {
        public List<Sys_Properties> SYS_properties { get; set; }

        public class Sys_Properties
        {
            public LoveEffectPropertiesBase SYS_properties { get; set; }
        }
        
        private class So_Necklace_Item
        {
            public List<Sys_Properties> SYS_properties { get; set; }
        }
    }
}