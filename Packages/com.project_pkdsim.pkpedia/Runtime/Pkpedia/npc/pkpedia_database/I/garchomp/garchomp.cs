using System;
using UnityEngine;

namespace project_pkdsim.Pkpedia.Npc.pkpedia_database.Modules.Garchomp
{
    public class GarchompDex : MonoBehaviour
    {
        // Update is called once per frame
        private void Update()
        {
            Pkpedia_link();
        }
        
        public void Pkpedia_link()
        {
            Garchomp();
        }

        private void Garchomp()
        {
            Console.WriteLine("Personality: Garchomp has a determined and noble character with a strong sense of justice. She is known for her bravery and unwavering commitment to protecting those in need. Garchomp's personality revolves around themes of courage, loyalty, and a desire to stand up for what is right.");
            Console.WriteLine("Parental Relationship: Mother, a Gabite, Protective and tenacious, she teaches Garchomp to fight for what they believe in. She values perseverance, pushing Garchomp to achieve their potential through hard work and toughness. /n Father a Salamence, Fierce and proud, he encourages Garchomp to embrace their raw power. He teaches the importance of strength in both body and spirit, always pushing Garchomp to strive for dominance.");
            Console.WriteLine("gender: female");
            Console.WriteLine("Backstory: Garchomp has a backstory tied to her role as a guardian of the skies and the defender of the weak. She has been chosen as a protector, using her incredible speed and strength to patrol the skies and keep her community safe from harm.");
        }
    }
}