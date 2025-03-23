using System.Collections.Generic;
using UnityEngine;
using project_pkdsim.Assets.USys.USystemsSys.ITEMS.ItemsScripts.Gifts.Necklaces.I.Base_Properties;

namespace project_pkdsim.Assets.USys.USystemsSys.ITEMS.ItemsScripts.Gifts.Necklaces.Spark_necklace
{
    public class Spark_NecklaceItem : MonoBehaviour
    {
        public List<Sys_Properties> SYS_properties { get; set; }

        public class Sys_Properties
        {
            public LoveEffectPropertiesBase SYS_properties { get; set; }
        }
        
        private class Sp_Necklace_Item
        {
            public List<Sys_Properties> SYS_properties { get; set; }
        }
    }
}