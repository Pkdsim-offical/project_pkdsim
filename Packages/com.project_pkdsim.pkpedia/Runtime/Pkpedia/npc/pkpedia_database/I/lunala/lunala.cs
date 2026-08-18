using System;
using UnityEngine;

namespace project_pkdsim.Pkpedia.Npc.pkpedia_database.Modules.Lunala
{
    public class LunalaDex : MonoBehaviour
    {
        // Update is called once per frame
        private void Update()
        {
            Pkpedia_link();
        }
        public void Pkpedia_link()
        {
            Lunala();
        }
        private void Lunala()
        {
            Console.WriteLine(" this will be in a later version");
            Console.WriteLine("Personality: ");
            Console.WriteLine("Parental Relationship: ");
            Console.WriteLine("Gender: ");
            Console.WriteLine("Backstory: ");
        }
    }
}