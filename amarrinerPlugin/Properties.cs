﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria_Server.Misc;

namespace amarrinerPlugin
{
    public class Properties : PropertiesFile
    {
        //private const bool DEFAULT_SPAWNING_CANCELLED = true;
        //private const bool DEFAULT_TILE_BREAKAGE = true;
        //private const bool DEFAULT_EXPLOSIVES_ALLOWED = true;

        //private const String SPAWNING_CANCELLED = "allowspawns";
        //private const String TILE_BREAKAGE = "tilebreakage";
        //private const String EXPLOSIVES_ALLOWED = "allowexplosives";

        public Properties(String propertiesPath) : base(propertiesPath) { }

        public void pushData()
        {
            //object temp = SpawningCancelled;
            //temp = TileBreakage;
            //temp = ExplosivesAllowed;
        }

    //    public bool SpawningCancelled
    //    {
    //        get
    //        {
    //            return getValue(SPAWNING_CANCELLED, DEFAULT_SPAWNING_CANCELLED);
    //        }
    //    }

    //    public bool TileBreakage
    //    {
    //        get
    //        {
    //            return getValue(TILE_BREAKAGE, DEFAULT_TILE_BREAKAGE);
    //        }
    //    }

    //    public bool ExplosivesAllowed
    //    {
    //        get
    //        {
    //            return getValue(EXPLOSIVES_ALLOWED, DEFAULT_EXPLOSIVES_ALLOWED);
    //        }
    //    }
    }
}
