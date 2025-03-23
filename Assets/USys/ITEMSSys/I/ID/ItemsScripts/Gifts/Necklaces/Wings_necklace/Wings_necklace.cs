using UnityEngine;

namespace project_pkdsim.Assets.USys.USystemsSys.ID.ItemsScripts.Gifts.Necklaces.Wings_necklace
{
    public class Wings_NecklaceItemID : MonoBehaviour
    {
        public string CustomUUID { get; set; }
        private string Name { get; set; }
        private string Category { get; set; }
        public void Wings_Necklace_ID()
        {
            // 94446647777 = Wings
            // 9 = w
            // 444 = i
            // 66 = n
            // 4= g
            // 7777 = s
            CustomUUID = "94446647777-663322255555222233";
            Name = "Wings Necklace";
            Category = "Necklace";
        }
    }
}