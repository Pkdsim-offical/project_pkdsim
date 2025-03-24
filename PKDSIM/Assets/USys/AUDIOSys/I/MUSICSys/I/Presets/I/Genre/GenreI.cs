using project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Presets.I.Genre.I.Alternative_Indie;
using project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Presets.I.Genre.I.Blues;
using project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Presets.I.Genre.I.Country;
using project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Presets.I.Genre.I.Dance;
using project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Presets.I.Genre.I.Disco;
using project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Presets.I.Genre.I.Drums;
using project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Presets.I.Genre.I.Electronic;
using project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Presets.I.Genre.I.Funk;
using project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Presets.I.Genre.I.House;
using project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Presets.I.Genre.I.Latin;
using project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Presets.I.Genre.I.Metal;
using project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Presets.I.Genre.I.Punk;
using project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Presets.I.Genre.I.Rap;
using project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Presets.I.Genre.I.Rock;
using project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Presets.I.Genre.I.Soul;
using project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Presets.I.Genre.I.Trap;
using project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Presets.I.Genre.I.Dubstep;
using project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Presets.I.Genre.I.Bass;
using project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Presets.I.Genre.I.Reggae;
using project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Presets.I.Genre.I.Pop;
using project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Presets.I.Genre.I.Techno;
using project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Presets.I.Genre.I.Folk;
using project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Presets.I.Genre.I.Gospel;
using project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Presets.I.Genre.I.Jazz;
using project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Presets.I.Genre.I.Classical;
using project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Presets.I.Genre.I.Synthwave;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AUDIOSys.I.MUSICSys.I.Presets.I.Genre.I
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