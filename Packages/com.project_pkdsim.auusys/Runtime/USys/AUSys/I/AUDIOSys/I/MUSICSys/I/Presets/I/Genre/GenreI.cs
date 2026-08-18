using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys.Modules.Presets.Modules.Genre.Modules.Alternative_Indie;
using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys.Modules.Presets.Modules.Genre.Modules.Blues;
using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys.Modules.Presets.Modules.Genre.Modules.Country;
using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys.Modules.Presets.Modules.Genre.Modules.Dance;
using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys.Modules.Presets.Modules.Genre.Modules.Disco;
using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys.Modules.Presets.Modules.Genre.Modules.Drums;
using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys.Modules.Presets.Modules.Genre.Modules.Electronic;
using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys.Modules.Presets.Modules.Genre.Modules.Funk;
using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys.Modules.Presets.Modules.Genre.Modules.House;
using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys.Modules.Presets.Modules.Genre.Modules.Latin;
using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys.Modules.Presets.Modules.Genre.Modules.Metal;
using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys.Modules.Presets.Modules.Genre.Modules.Punk;
using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys.Modules.Presets.Modules.Genre.Modules.Rap;
using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys.Modules.Presets.Modules.Genre.Modules.Rock;
using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys.Modules.Presets.Modules.Genre.Modules.Soul;
using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys.Modules.Presets.Modules.Genre.Modules.Trap;
using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys.Modules.Presets.Modules.Genre.Modules.Dubstep;
using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys.Modules.Presets.Modules.Genre.Modules.Bass;
using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys.Modules.Presets.Modules.Genre.Modules.Reggae;
using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys.Modules.Presets.Modules.Genre.Modules.Pop;
using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys.Modules.Presets.Modules.Genre.Modules.Techno;
using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys.Modules.Presets.Modules.Genre.Modules.Folk;
using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys.Modules.Presets.Modules.Genre.Modules.Gospel;
using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys.Modules.Presets.Modules.Genre.Modules.Jazz;
using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys.Modules.Presets.Modules.Genre.Modules.Classical;
using project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys.Modules.Presets.Modules.Genre.Modules.Synthwave;
using UnityEngine;

namespace project_pkdsim.USys.AUSys.Modules.AUDIOSys.Modules.MUSICSys.Modules.Presets.Modules.Genre.Modules
{
	public class GenreI : MonoBehaviour 
	{
		private Alternative_Indie.Alternative_Indie Alternative_Indie;
		private Blues.Blues Blues;
		private Country.Country Country;
		private Rap.Rap Rap;
		private Pop.Pop Pop;
		private Trap.Trap Trap;
		private Rock.Rock Rock;
		private Funk.Funk Funk;
		private Dance.Dance Dance;
		private Reggae.Reggae Reggae;
		private Drums.Drums Drums;
		private Electronic.Electronic Electronic;
		private Dubstep.Dubstep Dubstep;
		private Bass.Bass Bass;
		private Metal.Metal Metal;
		private Punk.Punk Punk;
		private Disco.Disco Disco;
		private Latin.Latin Latin;
		private Soul.Soul Soul;
		private Synthwave.Synthwave Synthwave;
		private Techno.Techno Techno;
		private Jazz.Jazz Jazz;
		private Folk.Folk Folk;
		private Gospel.Gospel Gospel;
		private Classical.Classical Classical;

		public void Genre_I()
		{

		}
		public void LoadAlternative_Indie() 
		{
			Alternative_Indie.Alternative_IndieLoader();
		}
		public void LoadBlues() 
		{
			Blues.BluesLoader();
		}
		public void LoadCountry() 
		{
			Country.CountryLoader();
		}
		public void LoadRap() 
		{
			Rap.RapLoader();
		}
		public void LoadPop() 
		{
			Pop.PopLoader();
		}
		public void LoadTrap() 
		{
			Trap.TrapLoader();
		}
		public void LoadRock() 
		{
			Rock.RockLoader();
		}
		public void LoadFunk() 
		{
			Funk.FunkLoader();
		}
		public void LoadDance() 
		{
			Dance.DanceLoader();
		}
		public void LoadReggae() 
		{
			Reggae.ReggaeLoader();
		}
		public void LoadDrums() 
		{
			Drums.DrumsLoader();
		}
		public void LoadElectronic() 
		{
			Electronic.ElectronicLoader();
		}
		public void LoadDubstep() 
		{
			Dubstep.DubstepLoader();
		}
		public void LoadBass() 
		{
			Bass.BassLoader();
		}
		public void LoadMetal() 
		{
			Metal.MetalLoader();
		}
		public void LoadPunk() 
		{
			Punk.PunkLoader();
		}
		public void LoadDisco() 
		{
			Disco.DiscoLoader();
		}
		public void LoadLatin() 
		{
			Latin.LatinLoader();
		}
		public void LoadSoul() 
		{
			Soul.SoulLoader();
		}
		public void LoadSynthwave() 
		{
			Synthwave.SynthwaveLoader();
		}
		public void LoadTechno() 
		{
			Techno.TechnoLoader();
		}
		public void LoadJazz() 
		{
			Jazz.JazzLoader();
		}
		public void LoadFolk() 
		{
			Folk.FolkLoader();
		}
		public void LoadGospel() 
		{
			Gospel.GospelLoader();
		}
		public void LoadClassical() 
		{
			Classical.ClassicalLoader();
		}
	}
}