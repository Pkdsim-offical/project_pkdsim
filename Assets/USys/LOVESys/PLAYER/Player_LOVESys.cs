using System.Collections.Generic;
using UnityEngine;

namespace project_pkdsim.Assets.USys.LOVESys.PLAYER
{
	public class Player_LOVESys : MonoBehaviour 
	{
		public Absol_LL absol_LL;
		public Beedrill_LL beedrill_LL;
		public Blaziken_LL blaziken_LL;
		public Braixen_LL braixen_LL;
		public Cinderace_LL cinderace_LL;
		public Delphox_LL delphox_LL;
		public Dragapult_LL dragapult_LL;
		public Espeon_LL espeon_LL;
		public Flareon_LL flareon_LL;
		public Frostlass_LL frostlass_LL;
		public Garchomp_LL garchomp_LL;
		public Gardevoir_LL gardevoir_LL;
		public Glaceon_LL glaceon_LL;
		public Hatterene_LL hatterene_LL;
		public Jolteon_LL jolteon_LL;
		public Leafeon_LL leafeon_LL;
		public Lopunny_LL lopunny_LL;
		public Lucario_LL lucario_LL;
		public Lunala_LL lunala_LL;
		public Meowscarada_LL meowscarada_LL;
		public Noivern_LL noivern_LL;
		public Salazzle_LL salazzle_LL;
		public Sylveon_LL sylveon_LL;
		public Tsareena_LL tsareena_LL;
		public Umbreon_LL umbreon_LL;
		public Vaporeon_LL vaporeon_LL;
		public Zoroark_LL zoroark_LL;
		public Vespiquen_LL vespiquen_LL;
		public Primarina_LL primarina_LL;
		public Pheromosa_LL pheromosa_LL;
		public List<bool> LoveLevel_NPCProgressStates;
		public void Start () 
		{
			Get_Player_LLSys();	
		}

		public void Get_Player_LLSys() 
		{
			Player_LLSData();
		}

		protected void Player_LLSData()
		{
			LoveLevel_NPCProgressStates = new List<bool>()
			{
				absol_LL,
				beedrill_LL,
				blaziken_LL,
				braixen_LL,
				cinderace_LL,
				delphox_LL,
				dragapult_LL,
				espeon_LL,
				flareon_LL,
				frostlass_LL,
				garchomp_LL,
				gardevoir_LL,
				glaceon_LL,
				hatterene_LL,
				jolteon_LL,
				leafeon_LL,
				lopunny_LL,
				lucario_LL,
				lunala_LL,
				meowscarada_LL,
				noivern_LL,
				pheromosa_LL,
				primarina_LL,
				salazzle_LL,
				sylveon_LL,
				tsareena_LL,
				umbreon_LL,
				vaporeon_LL,
				vespiquen_LL,
				zoroark_LL
			};
		}
	}
}
