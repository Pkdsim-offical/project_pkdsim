using System.Collections.Generic;
using UnityEngine;
using project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Gifts.Necklaces.I.Base_Properties;

namespace project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Gifts.Necklaces.PunchingBag_necklace
{
    public class PunchingBag_NecklaceItem : MonoBehaviour
    {
        // Make `SYS_properties` a public property so it can be accessed from other classes
        public List<Sys_Properties> SYS_properties { get; set; }

        public class Sys_Properties
        {
            public LoveEffectPropertiesBase SYS_properties { get; set; }
        }

        public class PBag_Necklace_Item
        {
            public List<Sys_Properties> SYS_properties { get; set; }
        }
    }
}
