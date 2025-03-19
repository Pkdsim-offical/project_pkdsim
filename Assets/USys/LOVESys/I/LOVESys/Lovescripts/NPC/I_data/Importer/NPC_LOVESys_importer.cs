using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Absol;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Beedrill;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Blaziken;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Braixen;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Cinderace;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Delphox;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Dragapult;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Espeon;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Flareon;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Frostlass;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Garchomp;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Gardevoir;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Glaceon;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Hatterene;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Jolteon;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Leafeon;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Lopunny;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Lucario;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Lunala;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Meowscarada;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Noivern;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Pheromosa;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Primarina;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Salazzle;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Tsareena;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Umbreon;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Vaporeon;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Vespiquen;
using project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Zoroark;
using UnityEngine;

namespace project_pkdsim.Assets.USys.LoveSys.I.LoveScripts.I.NPC.I_data.Importer
{
	public class NPC_LOVESys_Importer : MonoBehaviour
	{
		private Absol_LL Absol_LL;
		private Beedrill_LL Beedrill_LL;
		private Blaziken_LL Blaziken_LL;
		private Braixen_LL Braixen_LL;
		private Cinderace_LL Cinderace_LL;
		private Delphox_LL Delphox_LL;
		private Dragapult_LL Dragapult_LL;
		private Espeon_LL Espeon_LL;
		private Flareon_LL Flareon_LL;
		private Frostlass_LL Frostlass_LL;
		private Garchomp_LL Garchomp_LL;
		private Gardevoir_LL Gardevoir_LL;
		private Glaceon_LL Glaceon_LL;
		private Hatterene_LL Hatterene_LL;
		private Jolteon_LL Jolteon_LL;
		private Leafeon_LL Leafeon_LL;
		private Lucario_LL Lucario_LL;
		private Lopunny_LL Lopunny_LL;
		private Lunala_LL Lunala_LL;
		private Meowscarada_LL Meowscarada_LL;
		private Noivern_LL Noivern_LL;
		private Pheromosa_LL Pheromosa_LL;
		private Primarina_LL Primarina_LL;
		private Salazzle_LL Salazzle_LL;
		private Sylveon_LL Sylveon_LL;
		private Tsareena_LL Tsareena_LL;
		private Umbreon_LL Umbreon_LL;
		private Vaporeon_LL Vaporeon_LL;
		private Vespiquen_LL Vespiquen_LL;
		private Zoroark_LL Zoroark_LL;

		protected void Get_NPC_LLSys()
		{
			Get_Absol_LLSys();
			Get_Beedrill_LLSys();
			Get_Blaziken_LLSys();
			Get_Braixen_LLSys();
			Get_Cinderace_LLSys();
			Get_Delphox_LLSys();
			Get_Dragapult_LLSys();
			Get_Espeon_LLSys();
			Get_Flareon_LLSys();
			Get_Frostlass_LLSys();
			Get_Garchomp_LLSys();
			Get_Gardevoir_LLSys();
			Get_Glaceon_LLSys();
			Get_Hatterene_LLSys();
			Get_Jolteon_LLSys();
			Get_Leafeon_LLSys();
			Get_Lucario_LLSys();
			Get_Lopunny_LLSys();
			Get_Lunala_LLSys();
			Get_Meowscarada_LLSys();
			Get_Noivern_LLSys();
			Get_Pheromosa_LLSys();
			Get_Primarina_LLSys();
			Get_Salazzle_LLSys();
			Get_Sylveon_LLSys();
			Get_Tsareena_LLSys();
			Get_Umbreon_LLSys();
			Get_Vaporeon_LLSys();
			Get_Vespiquen_LLSys();
			Get_Zoroark_LLSys();
		}
		protected void Get_Absol_LLSys()
		{
			Absol_LL.Absol_LLI();
		}	

		protected void Get_Beedrill_LLSys()
		{
			Beedrill_LL.Beedrill_LLI();
		}

		protected void Get_Blaziken_LLSys()
		{
			Blaziken_LL.Blaziken_LLI();
		}

		protected void Get_Braixen_LLSys() 
		{
			Braixen_LL.Braixen_LLI();
		}

		protected void Get_Cinderace_LLSys() 
		{
			Cinderace_LL.Cinderace_LLI();
		}

		protected void Get_Delphox_LLSys()
		{
			Delphox_LL.Delphox_LLI();
		}

		protected void Get_Dragapult_LLSys()
		{
			Dragapult_LL.Dragapult_LLI();
		}

		protected void Get_Espeon_LLSys()
		{
			Espeon_LL.Espeon_LLI();
		}

		protected void Get_Flareon_LLSys()
		{
			Flareon_LL.Flareon_LLI();
		}

		protected void Get_Frostlass_LLSys() 
		{
			Frostlass_LL.Frostlass_LLI();
		}

		protected void Get_Garchomp_LLSys() 
		{ 
			Garchomp_LL.Garchomp_LLI();
		}

		protected void Get_Gardevoir_LLSys() 
		{
			Gardevoir_LL.Gardevoir_LLI();
		}

		protected void Get_Glaceon_LLSys()
		{
			Glaceon_LL.Glaceon_LLI();
		}

		protected void Get_Hatterene_LLSys()
		{
			Hatterene_LL.Hatterene_LLI();
		}

		protected void Get_Jolteon_LLSys()
		{
			Jolteon_LL.Jolteon_LLI();
		}

		protected void Get_Leafeon_LLSys()
		{
			Leafeon_LL.Leafeon_LLI();
		}

		protected void Get_Lucario_LLSys()
		{
			Lucario_LL.Lucario_LLI();
		}

		protected void Get_Lopunny_LLSys()
		{
			Lopunny_LL.Lopunny_LLI();
		}

		protected void Get_Lunala_LLSys()
		{
			Lunala_LL.Lunala_LLI();
		}

		protected void Get_Meowscarada_LLSys() 
		{
			Meowscarada_LL.Meowscarada_LLI();
		}

		protected void Get_Noivern_LLSys() 
		{
			Noivern_LL.Noivern_LLI();
		}

		protected void Get_Pheromosa_LLSys()
		{
			Pheromosa_LL.Pheromosa_LLI();
		}

		protected void Get_Primarina_LLSys()	
		{
			Primarina_LL.Primarina_LLI();
		}

		protected void Get_Salazzle_LLSys()
		{
			Salazzle_LL.Salazzle_LLI();
		}
		protected void Get_Sylveon_LLSys()
		{
			Sylveon_LL.Sylveon_LLI();
		}

		protected void Get_Tsareena_LLSys()
		{
			Tsareena_LL.Tsareena_LLI();
		}

		protected void Get_Umbreon_LLSys()
		{
			Umbreon_LL.Umbreon_LLI();
		}

		protected void Get_Vaporeon_LLSys()
		{
			Vaporeon_LL.Vaporeon_LLI();
		}

		protected void Get_Vespiquen_LLSys()
		{
			Vespiquen_LL.Vespiquen_LLI();
		}

		protected void Get_Zoroark_LLSys()
		{
			Zoroark_LL.Zoroark_LLI();
		}
	}	
}