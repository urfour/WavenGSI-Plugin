﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artemis.Plugins.Games.Waven.DataModels.Player
{
    public class Companion
    {
        public string? Name { get; set; }
        public string? Element { get; set; }
        public string? State { get; set; }
        public string? Rarity { get; set; }
        public bool IsAvailable { get; set; }
        public Companion() { }
    }
}
