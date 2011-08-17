using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

using Terraria_Server;
using System.Threading;
using Terraria_Server.Collections;
using Terraria_Server.Commands;
using Terraria_Server.Misc;
using Terraria_Server.Logging;
using Terraria_Server.RemoteConsole;
using Terraria_Server.WorldMod;
using Terraria_Server.Definitions;
using Terraria_Server.Plugin;

namespace amarrinerPlugin.Commands
{
    public class Commands
    {
        public static void roll(Server server, ISender sender, ArgumentList args) 
        {
            Random random = new Random();
            int result = 0;
            int times = 1;
            int die = 6;

            if (args.Count > 0)
            {
                string[] arg = args[0].Split('d');
                times = Int32.Parse(arg[0]);
                die = Int32.Parse(arg[1]);
            }

            for (int i = 0; i < times; i++)
            {
                result += random.Next(1, die);
            }

            server.notifyAll(sender.Name + " rolled a " + result.ToString() + " on " + times.ToString() + "d" + die.ToString(), true);
        }
    }
}
