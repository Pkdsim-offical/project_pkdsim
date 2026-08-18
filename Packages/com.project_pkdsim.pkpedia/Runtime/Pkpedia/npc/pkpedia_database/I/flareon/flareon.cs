using System;
using UnityEngine;

namespace project_pkdsim.Pkpedia.Npc.pkpedia_database.Modules.Flareon
{
    public class FlareonDex : MonoBehaviour
    {
        // Update is called once per frame
        private void Update()
        {
            Pkpedia_link();
        }
        
        public void Pkpedia_link()
        {
            Flareon();
        }

        private void Flareon()
        {
            Console.WriteLine("Personality: Flareon is an extroverted, fun-loving character who is always eager to make new friends. she's full of enthusiasm and known for her charismatic charm. Flareon's personality revolves around themes of determination, warmth, and a love for adventure and outdoor activities.");
            Console.WriteLine("Parental Relationship: Flareon's Mother, a Ninetales, Mysterious and elegant, she teaches Flareon the importance of inner fire and emotional balance.Though proud of Flareon’s fiery spirit, she emphasizes control over power, a quality she believes to be more crucial than raw strength. /n Father, a Arcanine, Noble and brave, he encourages Flareon to embrace its power and burn brightly.His courage and leadership influence Flareon to take charge and be bold in every situation, inspiring confidence and determination.");
            Console.WriteLine("gender: female ");
            Console.WriteLine("Backstory: Flareon b has a backstory relates to her species' fiery spirit. Her species grew up in a community that celebrated fire festivals and had a long tradition of taming the flames. Flareon has embraced her species' role as a torchbearer for these festivals, symbolizing hope and courage.");
        }
    }
}