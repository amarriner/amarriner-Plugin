using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using Terraria_Server;
using Terraria_Server.Plugin;
using Terraria_Server.Commands;
using Terraria_Server.Events;
using Terraria_Server.Logging;

namespace amarrinerPlugin
{
    public class amarrinerPlugin : Plugin
    {
        /*
         * @Developers
         * 
         * Plugins need to be in .NET 3.5
         * Otherwise TDSM will be unable to load it. 
         * 
         * As of June 16, 1:15 AM, TDSM should now load Plugins Dynamically.
         */

        public Properties properties;
        public static Plugin plugin;

        public override void Load()
        {
            Name = "amarrinerPlugin";
            Description = "Learning how to create a TDSM plugin";
            Author = "amarriner";
            Version = "1";
            TDSMBuild = 30; //Current Release - Working

            plugin = this;

            string pluginFolder = Statics.PluginPath + Path.DirectorySeparatorChar + "amarrinerPlugin";
            //Create folder if it doesn't exist
            CreateDirectory(pluginFolder);

            //setup a new properties file
            properties = new Properties(pluginFolder + Path.DirectorySeparatorChar + "amarrinerplugin.properties");
            properties.Load();
            //properties.pushData(); //Creates default values if needed. [Out-Dated]
            properties.Save();

            //read properties data
            //spawningAllowed = properties.SpawningCancelled;
            //tileBreakageAllowed = properties.TileBreakage;
            //explosivesAllowed = properties.ExplosivesAllowed;
        }

        public override void Enable()
        {
            Program.tConsole.WriteLine(base.Name + " enabled.");
            //Register Hooks
            //this.registerHook(Hooks.PLAYER_TILECHANGE);
            //this.registerHook(Hooks.PLAYER_PROJECTILE);

            //Add Commands
            AddCommand("roll")
                .WithAccessLevel(AccessLevel.PLAYER)
                .WithDescription("Roll a six-sided die")
                .WithHelpText("Usage:   /roll")
                .Calls(Commands.Commands.roll);

            //Main.stopSpawns = !spawningAllowed;
            //if (Main.stopSpawns)
            //{
            //    ProgramLog.Log("Disabled NPC Spawning");
            //}
        }

        public override void Disable()
        {
            Program.tConsole.WriteLine(base.Name + " disabled.");
        }

        public override void onPlayerTileChange(PlayerTileChangeEvent Event)
        {
            //if (!Enabled || tileBreakageAllowed == false) { return; }
            //ProgramLog.Log("[TSDM Plugin] Cancelled Tile change of Player: " + ((Player)Event.Sender).Name);
            //Event.Cancelled = true;
        }

        public override void onPlayerProjectileUse(PlayerProjectileEvent Event)
        {
            //if (Enabled && !explosivesAllowed)
            //{

            //    int type = Event.Projectile.Type;
            //    if (type == 28 || type == 29 || type == 37)
            //    {
            //        Event.Cancelled = true;
            //        ProgramLog.Log("[TSDM Plugin] Cancelled Explosive usage of Player: " + ((Player)Event.Sender).Name);
            //    }
            //}
        }

        private static void CreateDirectory(string dirPath)
        {
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
        }

    }
}
