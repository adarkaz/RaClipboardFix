using Exiled.API.Interfaces;
using System.ComponentModel;

namespace RaClipboardFix.Configs;
public sealed class Plugin : IConfig
{
    [Description("Indicates enabled plugin or not.")]
    public bool IsEnabled { get; set; } = true;
    [Description("Indicates enabled debug mod or not.")]
    public bool Debug { get; set; } = false;
}