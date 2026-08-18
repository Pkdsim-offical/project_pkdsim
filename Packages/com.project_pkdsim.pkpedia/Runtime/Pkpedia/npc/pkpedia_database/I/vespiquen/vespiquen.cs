using System;
using UnityEngine;

namespace project_pkdsim.Pkpedia.Npc.pkpedia_database.Modules.Vespiquen
{
    public class VespiquenDex : MonoBehaviour
    {
        private void Update()
        {
            Pkpedia_link();
        }

        public void Pkpedia_link()
        {
            Vespiquen();
        }

        private void Vespiquen()
        {
            Console.WriteLine(" this will be in a later version");
            Console.WriteLine("Personality: ");
            Console.WriteLine("Parental Relationship: ");
            Console.WriteLine("gender: female ");
            Console.WriteLine("Backstory: ");
        }
    }
}