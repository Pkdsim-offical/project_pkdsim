using System;
using UnityEngine;

namespace project_pkdsim.Pkpedia.Npc.pkpedia_database.Modules.Primarina
{
    public class PrimarinaDex : MonoBehaviour
    {
        // Update is called once per frame
        private void Update()
        {
            Pkpedia_link();
        }

        public void Pkpedia_link()
        {
            Primarina();
        }

        private void Primarina()
        {
            Console.WriteLine(" this will be in a later version");
            Console.WriteLine("Personality: ");
            Console.WriteLine("Parental Relationship: ");
            Console.WriteLine("gender: female ");
            Console.WriteLine("Backstory: ");






            // archive before version
            // Console.WriteLine("Personality: Salazzle, has a clever and charismatic character with a strong sense of strategy. she is known for her ability to charm and manipulate situations to her advantage, often using her wits to outsmart opponents.");
            // Console.WriteLine("Parental Relationship: Salazzle has a close relationship with her mother, a powerful and respected Salazzle who passed down the knowledge of strategy and the importance of using her abilities wisely. mother has shared stories of her own cunning exploits and the significance of maintaining control and influence.");
            // Console.WriteLine("gender: female ");
            // Console.WriteLine("Backstory: Salazzle has a backstory tied to her role as a guardian of strategy and allure within her community. she was chosen as a protector, using her cunning nature and venomous abilities to defend her territory and maintain control over her environment.");
        }
    }
}