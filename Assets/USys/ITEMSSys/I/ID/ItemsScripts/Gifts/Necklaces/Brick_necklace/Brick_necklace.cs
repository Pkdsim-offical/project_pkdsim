using UnityEngine;

namespace project_pkdsim.Assets.USys.USystemsSys.ID.ItemsScripts.Gifts.Necklaces.Brick_necklace
{
    public class Brick_NecklaceItemID : MonoBehaviour
    {
        public string CustomUUID { get; private set; }
        private string Name { get; set; }
        private string Category { get; set; }

        public void Brick_Necklace_ID()
        {
            // 2277744422255 = Brick
            // 22 = B
            // 777 = r
            // 444 = i
            // 222 = c
            // 55 = k
            CustomUUID = "2277744422255-663322255555222233";
            Name = "Brick Necklace";
            Category = "Necklace";    
        }
    }
}