using System;
using UnityEngine;

namespace project_pkdsim.Pkpedia.Npc.pkpedia_database.Modules.Pheromosa
{
    public class PheromosaDex : MonoBehaviour
    {
        // Update is called once per frame
        private void Update()
        {
            Pkpedia_link();
        }
        
        public void Pkpedia_link()
        {
            Pheromosa();
        }
        
        private void Pheromosa()
        {
            Console.WriteLine(" this will be in a later version");
            Console.WriteLine("Personality: ");
            Console.WriteLine("Parental Relationship: ");
            Console.WriteLine("gender: female ");
            Console.WriteLine("Backstory: ");
        }
    }
}