using System;
using UnityEngine;

namespace project_pkdsim.Pkpedia.Npc.pkpedia_database.Modules.Sylveon
{
    public class SylveonDex : MonoBehaviour
    {
        // Update is called once per frame
        private void Update()
        {
            Pkpedia_link();
        }

        public void Pkpedia_link()
        {
            Sylveon();
        }

        private void Sylveon()
        {
            Console.WriteLine("Personality: Sylveon has a caring and emotionally perceptive character. Sylveon excels at understanding and nurturing the relationships between people and Pokémon. Sylveon's personality revolves around themes of empathy, a understanding, and has a passion for fostering connections between the people around her. Sylveon is also a natural leader and empathetic friend.");
            Console.WriteLine("parental relationship: Sylveon's Mother, a Gardevoir, Gentle and empathetic, she encourages Sylveon to use its kindness and charm to resolve conflicts. She teaches Sylveon the power of love and emotional connection, believing in the strength that comes from compassion. /n Father, a Togekiss, Optimistic and protective, he believes in peace and spreading joy. He teaches Sylveon to always look for the positive and to use its abilities to brighten others’ lives, reinforcing emotional support as a strength.");
            Console.WriteLine("gender: female ");
            Console.WriteLine("backstory: Sylveon has a backstory of a peacemaker within her community. Sylveon has a unique ability to sense and resolve conflicts among Pokémon, humans, and the environment. her presence serves as a force of unity, emphasizing the importance of emotional bonds.");
        }
    }
}