using UnityEngine;

namespace project_pkdsim.Assets.USys.ITEMSSys.ID.ItemsScripts.Gifts.Necklaces.Spark_necklace
{
    public class Spark_NecklaceItemID : MonoBehaviour
    {
        public string CustomUUID { get; private set; }
        private string Name { get; set; }
        private string Category { get; set; }
        public void Spark_Necklace_ID()
        {
            // 77777277755 = Spark
            // 7777 = s
            // 7 = p
            // 2 = a
            // 777 = r
            // 55 = k
            CustomUUID = "77777277755-663322255555222233";
            Name = "Spark Necklace";
            Category = "Necklace";
        }
    }
}