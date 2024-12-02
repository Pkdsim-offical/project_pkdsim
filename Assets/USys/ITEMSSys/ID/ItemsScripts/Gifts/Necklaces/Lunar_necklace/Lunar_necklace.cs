using UnityEngine;


namespace project_pkdsim.Assets.USys.ITEMSSys.ID.ItemsScripts.Gifts.Necklaces.Lunar_necklace
{
    public class Lunar_NecklaceItemID : MonoBehaviour
    {
        public string CustomUUID { get; private set; }
        private string Name { get; set; }
        private string Category { get; set; }
        public void Lunar_Necklace_ID()
        {
            // 55588662777 = Lunar
            // 555 = l
            // 88 = u
            // 66 = n
            // 2 =  a
            // 777 = r
            CustomUUID = "55588662777-663322255555222233";
            Name = "Lunar Necklace";
            Category = "Necklace";
        }
    }
}
