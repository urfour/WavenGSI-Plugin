using Artemis.Core.Modules;

namespace Artemis.Plugins.Games.Waven.DataModels;

public class WavenDataModel : DataModel
{
    public GameInfos Infos { get; set; }
    public WavenDataModel()
    {
        Infos = new GameInfos();

    }
}