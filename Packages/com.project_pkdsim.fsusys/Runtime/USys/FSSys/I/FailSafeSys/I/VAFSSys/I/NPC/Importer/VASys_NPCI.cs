using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Absol;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Beedrill;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Blaziken;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Braixen;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Cinderace;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Delphox;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Dragapult;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Espeon;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Flareon;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Frostlass;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Garchomp;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Gardevoir;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Glaceon;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Hatterene;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Jolteon;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Leafeon;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Lopunny;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Lucario;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Lunala;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Meowscarada;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Noivern;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Pheromosa;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Primarina;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Salazzle;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Sylveon;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Tsareena;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Umbreon;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Vaporeon;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Vespiquen;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Zoroark;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys.Modules.NPC.Importer
{
	public class VAFSSys_NPCI : MonoBehaviour 
	{
		private ZoroarkVAFS ZoroarkVAFS;
		private VespiquenVAFS VespiquenVAFS;
		private VaporeonVAFS VaporeonVAFS;
		private UmbreonVAFS UmbreonVAFS;
		private TsareenaVAFS TsareenaVAFS;
		private SylveonVAFS SylveonVAFS;
		private SalazzleVAFS SalazzleVAFS;
		private PrimarinaVAFS PrimarinaVAFS;
		private PheromosaVAFS PheromosaVAFS;
		private NoivernVAFS NoivernVAFS;
		private MeowscaradaVAFS MeowscaradaVAFS;
		private LunalaVAFS LunalaVAFS;
		private LucarioVAFS LucarioVAFS;
		private LopunnyVAFS LopunnyVAFS;
		private LeafeonVAFS LeafeonVAFS;
		private JolteonVAFS JolteonVAFS;
		private HattereneVAFS HattereneVAFS;
		private GlaceonVAFS GlaceonVAFS;
		private GardevoirVAFS GardevoirVAFS;
		private GarchompVAFS GarchompVAFS;
		private FrostlassVAFS FrostlassVAFS;
		private FlareonVAFS FlareonVAFS;
		private EspeonVAFS EspeonVAFS;
		private DragapultVAFS DragapultVAFS;
		private DelphoxVAFS DelphoxVAFS;
		private CinderaceVAFS CinderaceVAFS;
		private BraixenVAFS BraixenVAFS;
		private BlazikenVAFS BlazikenVAFS;
		private BeedrillVAFS BeedrillVAFS;
		private AbsolVAFS AbsolVAFS;

		public void VAFSSys_NPC_I() 
		{
			
		}
	}
}