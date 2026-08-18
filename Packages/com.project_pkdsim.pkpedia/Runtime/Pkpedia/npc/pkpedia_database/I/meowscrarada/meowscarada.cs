using System;
using UnityEngine;

namespace project_pkdsim.Pkpedia.Npc.pkpedia_database.Modules.Meowscarada
{
    public class MeowscaradaDex : MonoBehaviour
    {
        // Update is called once per frame
        private void Update()
        {
            Pkpedia_link();
        }
        public void Pkpedia_link()
        {
            Meowscarada();
        }
        
        private void Meowscarada()
        {
            Console.WriteLine(" this will be in a later version");
            Console.WriteLine("Personality: ");
            Console.WriteLine("Parental Relationship: ");
            Console.WriteLine("gender: female ");
            Console.WriteLine("Backstory: ");
        }
    }
}