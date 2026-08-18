using System;
using UnityEngine;

namespace project_pkdsim.Pkpedia.Npc.pkpedia_database.Modules.Gardevoir
{
    public class GardevoirDex : MonoBehaviour
    {
        // Update is called once per frame
        private void Update()
        {
            Pkpedia_link();
        }

        public void Pkpedia_link()
        {
            Gardevoir();
        }

        private void Gardevoir()
        {
            Console.WriteLine("Personality: Gardevoir has a compassionate and caring character with powerful psychic abilities. She excels at understanding the emotions and needs of others, and she has a strong desire to protect and guide those she cares about. Gardevoir's personality revolves around themes of empathy, protection, and a deep sense of responsibility for the well-being of her friends.");
            Console.WriteLine("Parental Relationship: Gardevoir's Mother, a Kirlia, A loving and understanding figure, she believes in the importance of empathy and care for others. She teaches her the significance of protecting those they love with both strength and grace. /n Father, a Gallade, A knight-like protector, he emphasizes chivalry and courage. He teaches her to be a guardian for others, blending compassion with the ability to fight for what’s right.");
            Console.WriteLine("gender: female ");
            Console.WriteLine("Backstory: Gardevoir has a backstory that relates to her role as a guardian of her community's well-being. she has been chosen as the protector, using her psychic powers to help resolve conflicts and guide her community towards harmony.");
        }
    }
}