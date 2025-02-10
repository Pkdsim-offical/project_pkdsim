
using project_pkdsim.Assets.USys.HTPSys.HOUSES.NPC.I;

namespace project_pkdsim.Assets.USys.HTPSys.HOUSES.NPC
{
    public class HTPSys_NPC_FamilyTeleporter
    {
        private HTPSys_NPC_FamilyTeleporterI HTPSys_NPC_FamilyTeleporterI;
        public void HTPSys_NPC_FamilySceneTeleporter(string family)
        {
            if (HTPSys_NPC_FamilyTeleporterI != null)
            {
                switch (family)
                {
                    case "Ab":
                        HTPSys_NPC_FamilyTeleporterI.HTPSys_AbH();
                        break;
                    case "Be":
                        HTPSys_NPC_FamilyTeleporterI.HTPSys_BeH();
                        break;
                    case "Bl":
                        HTPSys_NPC_FamilyTeleporterI.HTPSys_BlH();
                        break;
                    case "Br":
                        HTPSys_NPC_FamilyTeleporterI.HTPSys_BrH();
                        break;
                    case "C":
                        HTPSys_NPC_FamilyTeleporterI.HTPSys_CH();
                        break;
                    case "Dl":
                        HTPSys_NPC_FamilyTeleporterI.HTPSys_DlH();
                        break;
                    case "Dr":
                        HTPSys_NPC_FamilyTeleporterI.HTPSys_DrH();
                        break;
                    case "FlVpJo":
                        HTPSys_NPC_FamilyTeleporterI.HTPSys_FlVpJoH();
                        break;
                    case "Fr":
                        HTPSys_NPC_FamilyTeleporterI.HTPSys_FrH();
                        break;
                    case "Garc":
                        HTPSys_NPC_FamilyTeleporterI.HTPSys_GarcH();
                        break;
                    case "Gard":
                        HTPSys_NPC_FamilyTeleporterI.HTPSys_GardH();
                        break;
                    case "H":
                        HTPSys_NPC_FamilyTeleporterI.HTPSys_HH();
                        break;
                    case "LeGl":
                        HTPSys_NPC_FamilyTeleporterI.HTPSys_LeGlH();
                        break;
                    case "Lo":
                        HTPSys_NPC_FamilyTeleporterI.HTPSys_LoH();
                        break;
                    case "Luca":
                        HTPSys_NPC_FamilyTeleporterI.HTPSys_LucaH();
                        break;
                    case "Luna":
                        HTPSys_NPC_FamilyTeleporterI.HTPSys_LunaH();
                        break;
                    case "Me":
                        HTPSys_NPC_FamilyTeleporterI.HTPSys_MeH();
                        break;
                    case "No":
                        HTPSys_NPC_FamilyTeleporterI.HTPSys_NoH();
                        break;
                    case "Ph":
                        HTPSys_NPC_FamilyTeleporterI.HTPSys_PhH();
                        break;
                    case "Pr":
                        HTPSys_NPC_FamilyTeleporterI.HTPSys_PrH();
                        break;
                    case "Sa":
                        HTPSys_NPC_FamilyTeleporterI.HTPSys_SaH();
                        break;
                    case "Syl":
                        HTPSys_NPC_FamilyTeleporterI.HTPSys_SYLH();
                        break;
                    case "T":
                        HTPSys_NPC_FamilyTeleporterI.HTPSys_TH();
                        break;
                    case "UE":
                        HTPSys_NPC_FamilyTeleporterI.HTPSys_UEH();
                        break;
                    case "Ve":
                        HTPSys_NPC_FamilyTeleporterI.HTPSys_VeH();
                        break;
                    case "Z":
                        HTPSys_NPC_FamilyTeleporterI.HTPSys_ZH();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
