using System.Collections.Generic;
using Artemis.Core;
using Artemis.Core.Modules;
using Artemis.Core.Services;
using Artemis.Plugins.Games.Waven.DataModels;

namespace Artemis.Plugins.Games.Waven;

[PluginFeature(Name = "Waven")]
public class WavenModule : Module<WavenDataModel>
{
    private readonly IWebServerService _webServerService;
    public WavenModule(IWebServerService webServerService)
    {
        _webServerService = webServerService;
    }
    public override List<IModuleActivationRequirement> ActivationRequirements { get; } 
        = new() { new ProcessActivationRequirement("Waven") };

    public override void Enable() 
    {
        _webServerService.AddResponsiveJsonEndPoint<GameInfos>(this, "Waven", rep =>
        {
            DataModel.Infos = rep;
            return DataModel.Infos;
        });
    }

    public override void Disable()
    {

    }

    public override void Update(double deltaTime)
    {

    }
}