using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.ID.ItemsScripts.Gifts.Necklaces.WaterDroplet_necklace
{
    public class WaterDroplet_NecklaceItemID : MonoBehaviour
    {
        public string CustomUUID { get; set; }
        private string Name { get; set; }
        private string Category { get; set; }
        public void WaterDroplet_Necklace_ID()
        {
            // 92833737776667555338 = WaterDroplet
            // 9 = w
            // 2 = a
            // 8 = t
            // 33 = e
            // 7 = r
            // 3 = d
            // 777 = r
            // 666 = o
            // 7 = p
            // 555 = l
            // 33 = e
            // 8 = t
            CustomUUID = "99222222227766655544433-663322255555222233";
            Name = "WaterDroplet Necklace";
            Category = "Necklace";
        }
    }
}