using Artemis.Core.Modules;
using Artemis.Plugins.Games.Waven.DataModels.Player;
using Artemis.Plugins.Games.Waven.DataModels.World;
using System.Collections.Generic;

namespace Artemis.Plugins.Games.Waven.DataModels
{
    public class GameInfos
    {
        public GameInfos()
        {
            Player = new PlayerInfos();
            World = new WorldInfos();
        }
        [DataModelProperty(Name = "Player")]
        public PlayerInfos Player { get; set; }
        [DataModelProperty(Name = "World")]
        public WorldInfos World { get; set; }
    }
}