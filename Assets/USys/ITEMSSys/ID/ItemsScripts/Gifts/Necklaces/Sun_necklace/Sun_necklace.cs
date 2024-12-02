using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.ID.ItemsScripts.Gifts.Necklaces.Sun_necklace
{
    public class Sun_NecklaceItemID : MonoBehaviour
    {
        public string CustomUUID { get; private set; }
        private string Name { get; set; }
        private string Category { get; set; }
        public void Sun_Necklace_ID()
        {
            // 77778866 = Sun
            // 777 = s
            // 88 = u
            // 66 = n
            CustomUUID = "77778866-663322255555222233";
            Name = "Sun Necklace";
            Category = "Necklace";
        }
    }
}