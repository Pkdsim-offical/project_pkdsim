using project_pkdsim.Assets.Models.pkpedia.Npc.pkpedia_database;

namespace project_pkdsim.Assets.Models.pkpedia.Npc.pkpedia_database.I_Data.Lopunny
{
    public class lopunny : Pkpedia_database
    {
        // Update is called once per frame
        private void Update()
        {
            Pkpedia_link();
        }
        protected void Pkpedia_link()
        {
            Lopunny();
        }
    }
}