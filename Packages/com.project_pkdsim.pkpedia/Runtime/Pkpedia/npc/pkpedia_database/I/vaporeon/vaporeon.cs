using System;
using UnityEngine;

namespace project_pkdsim.Pkpedia.Npc.pkpedia_database.Modules.Vaporeon
{
    public class VaporeonDex : MonoBehaviour
    {
        // Update is called once per frame
        private void Update()
        {
            Pkpedia_link();
        }

        public void Pkpedia_link()
        {
            Vaporeon();
        }

        private void Vaporeon()
        {
            Console.WriteLine("Personality: Vaporeon is known for her calm and adaptable nature, making them the guardian of fluidity and tranquility. she thrive on maintaining peace and balance in aquatic environments, confronting challenges with unwavering resilience.");
            Console.WriteLine("Parental Relationship: Vaporeon's Mother, a Milotic, An elegant and serene figure, she values beauty and grace in both movement and personality.She instills in Vaporeon the importance of tranquility and harmony, emphasizing that true strength lies in calmness. /n Father(Gyarados): A powerful and tempestuous figure, he teaches Vaporeon about the importance of strength in the face of adversity, even if it means showing force when necessary. His protective nature often clashes with the mother’s calmer approach");
            Console.WriteLine("gender: female ");
            Console.WriteLine("Backstory: Vaporeon has a backstory that is steeped in the legacy of aquatic guardians, tasked with safeguarding water in all its forms. she has been chosen to maintain the balance of serene lakes and raging seas, ensuring the preservation of aquatic ecosystems.");
        }
    }
}