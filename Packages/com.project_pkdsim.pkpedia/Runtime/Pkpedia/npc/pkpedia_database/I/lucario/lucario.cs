using System;
using UnityEngine;

namespace project_pkdsim.Pkpedia.Npc.pkpedia_database.Modules.Lucario
{
    public class LucarioDex : MonoBehaviour
    {
        // Update is called once per frame
        private void Update()
        {
            Pkpedia_link();
        }

        public void Pkpedia_link()
        {
            Lucario();
        }

        private void Lucario()
        {
            Console.WriteLine("Personality: Lucario has a noble and disciplined character with a strong sense of justice. she is known for her wisdom and inner strength, as well as her commitment to upholding righteousness. Lucario's personality revolves around themes of discipline, introspection, and a desire to maintain balance in all things.");
            Console.WriteLine("Parental Relationship: Lucario's Mother a Blaziken, Strong and passionate, she teaches Lucario to rely on both heart and skill in battle. She values determination and fiery passion in every challenge faced. /n Father, a Machamp, A disciplined and tough figure, he trains Lucario in martial arts and discipline. He values honor and respect, teaching that strength must be tempered with responsibility.");
            Console.WriteLine("gender: female ");
            Console.WriteLine("Backstory: Lucario has a backstory tied to her role as a guardian of aura and inner strength. she went though rigorous training to master her aura abilities and develop her combat skills, eventually emerging as a formidable protector of her community.");
        }
    }
}