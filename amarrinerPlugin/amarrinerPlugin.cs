using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using Terraria_Server;
using Terraria_Server.Plugin;
using Terraria_Server.Collections;
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
        public static amarrinerPlugin plugin;

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
            properties.Save();

            //read properties data
            //spawningAllowed = properties.SpawningCancelled;
        }

        public override void Enable()
        {
            Program.tConsole.WriteLine(base.Name + " enabled.");
            //Register Hooks
            this.registerHook(Hooks.PLAYER_LOGIN);

            //Add Commands
            AddCommand("roll")
                .WithAccessLevel(AccessLevel.PLAYER)
                .WithDescription("Roll a six-sided die")
                .WithHelpText("Usage:   /roll")
                .Calls(Commands.Commands.roll);


        }

        public override void Disable()
        {
            Program.tConsole.WriteLine(base.Name + " disabled.");
        }

        public override void onPlayerJoin(PlayerLoginEvent Event)
        {
            Event.Sender.sendMessage("Welcome, " + Event.Player.Name, 255, 100, 200, 100);

            Item item = Registries.Item.Create("Statue");
            Item.NewItem((int)Event.Player.Position.X, (int)Event.Player.Position.Y, Event.Player.Width, Event.Player.Height, item.Type);
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
