using Artemis.Core;
using Artemis.Plugins.Games.Waven.Prerequisites;
using Artemis.UI.Shared;
using System;
using System.IO;

namespace Artemis.Plugins.Games.Waven;

public class Bootstrapper : PluginBootstrapper
{
    public override void OnPluginLoaded(Plugin plugin)
    {
        if (Path.Exists(Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "Ankama/Waven")))
        {
            AddPluginPrerequisite(new WavenGSIPrerequisite(plugin));
        }
    }

    public override void OnPluginEnabled(Plugin plugin)
    {
        
    }
    
    public override void OnPluginDisabled(Plugin plugin)
    {
        
    }
}
