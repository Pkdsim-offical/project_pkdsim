using System;
using UnityEngine;

namespace project_pkdsim.Pkpedia.Npc.pkpedia_database.Modules.Dragapult
{
    public class DragapultDex : MonoBehaviour
    {
        // Update is called once per frame
        private void Update()
        {
            Pkpedia_link();
        }
        
        public void Pkpedia_link()
        {
            Dragapult();
        }
        
        private void Dragapult()
        {
            Console.WriteLine("Personality: Dragapult, has a fierce and protective character with a strong sense of loyalty. she are known for her bravery and willingness to defend her friends at all costs. Dragapult's personality revolve around themes of vigilance, determination, and a deep bond with her allies.");
            Console.WriteLine("Parental Relationship: Dragapult's Mother, a Gengar, she taught Dragapult how to harness its ghostly powers and remain unseen. She encouraged Dragapult to use fear as a weapon but also to protect the vulnerable. /m Father, a Salamence, he a fierce dragon, instilled in Dragapult the importance of strength and speed. His teachings emphasized the use of raw power and flight to outmaneuver opponents.");
            Console.WriteLine("gender: female ");
            Console.WriteLine("Backstory: Dragapult has a backstory tied to her role as a guardian of the night sky and the protector of her allies. she has been chosen as a protector, using her swift movements and powerful attacks to keep her community safe from harm.");
        }
    }
}