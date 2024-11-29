using System.Collections.Generic;
using UnityEngine;
using project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Gifts.Necklaces.I.Base_Properties;


namespace project_pkdsim.Assets.USys.ITEMSSys.ITEMS.ItemsScripts.Gifts.Necklaces.Brick_necklace
{
    public class Brick_necklaceItem : MonoBehaviour
    {
        public List<Sys_Properties> SYS_properties { get; set; }

        public class Sys_Properties
        {
            public LoveEffectPropertiesBase SYS_properties { get; set; }
        }
        public class Br_necklace_Item
        {

        }
    }
}