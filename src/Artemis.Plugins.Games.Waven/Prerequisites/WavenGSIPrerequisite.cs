using Artemis.Core;
using Artemis.Plugins.Games.Waven.Actions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artemis.Plugins.Games.Waven.Prerequisites
{
    public class WavenGSIPrerequisite : PluginPrerequisite
    {
        public override string Name => "BepInEx";
        public override string Description => "BepInEx needs to be downloaded";
        public static string WavenFolder => Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "Ankama/Waven");

        public override List<PluginPrerequisiteAction> InstallActions { get; }
        public override List<PluginPrerequisiteAction> UninstallActions { get; }

        public override bool IsMet()
        {
            return Path.Exists(Path.Combine(WavenFolder, "BepInEx"));
        }

        public WavenGSIPrerequisite(Plugin plugin)
        {
            InstallActions = new List<PluginPrerequisiteAction>()
            {
                new DownloadFileAction(
                    "Download BepInEx archive",
                    "https://builds.bepinex.dev/projects/bepinex_be/674/BepInEx-Unity.IL2CPP-win-x64-6.0.0-be.674%2B82077ec.zip",
                    Path.Combine(plugin.Directory.FullName, "BepInEx.zip")
                ),
                new ExtractArchiveAction(
                    "Extract BepInEx archive",
                    Path.Combine(plugin.Directory.FullName, "BepInEx.zip"),
                    WavenFolder
                ),
                new CreateDirectoryAction(
                    "Create plugins directory",
                    Path.Combine(WavenFolder, "BepInEx/plugins")),
                new DownloadFileAction(
                    "Download WavenGSI mod",
                    "https://github.com/urfour/WavenGSI-Mod/releases/latest/download/WavenGSI.dll",
                    Path.Combine(WavenFolder, "BepInEx/plugins", "WavenGSI.dll")
                )
            };

            UninstallActions = new List<PluginPrerequisiteAction>()
            {
                new DeleteFolderAction(
                    "Delete BepInEx folder",
                    Path.Combine(WavenFolder, "BepInEx")
                ),
                new DeleteFolderAction(
                    "Delete dotnet folder",
                    Path.Combine(WavenFolder, "dotnet")
                ),
                new DeleteFileAction(
                    "Delete .doorstop_version",
                    Path.Combine(WavenFolder, ".doorstop_version")
                ),
                new DeleteFileAction(
                    "Delete doorstop_config.ini",
                    Path.Combine(WavenFolder, "doorstop_config.ini")
                ),
                new DeleteFileAction(
                    "Delete changelog.txt",
                    Path.Combine(WavenFolder, "changelog.txt")
                ),
                new DeleteFileAction(
                    "Delete winhttp.dll",
                    Path.Combine(WavenFolder, "winhttp.dll")
                )
            };
        }

    }
}
