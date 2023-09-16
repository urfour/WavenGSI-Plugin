using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artemis.Plugins.Games.Waven.DataModels.Player
{
    public class PlayerInfos
    {
        public string? AccountName { get; set; }
        public string? HeroName { get; set; }
        public string? Class { get; set; }
        public string? Weapon { get; set; }
        public int Level { get; set; }
        public bool IsInFight { get; set; }
        public bool IsPlayerTurn { get; set; }
        public int BaseHealthPoints { get; set; }
        public int HealthPoints { get; set; }
        public int ActionPoints { get; set; }
        public int ReservePoints { get; set; }
        public int BaseMovementPoints { get; set; }
        public int MovementPoints { get; set; }
        public int SpellsCount { get; set; }
        public SpellSlots? Spells { get; set; }
        public CompanionSlots? Companions { get; set; }
        public int CompanionsCount { get; set; }
        public PlayerInfos() { }
    }

}
