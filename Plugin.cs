using Exiled.API.Features;
using HarmonyLib;

namespace RaClipboardFix;
public class Plugin : Plugin<Configs.Plugin>
{
    public override string Name => "RaClipboardFix";
    public override string Author => "swd";
    public override Version Version => new(1, 0, 0);
    public static Harmony? Harmony;
    public const string HarmonyId = "RaClipboardFix - swd";
    public override void OnEnabled()
    {
        Harmony = new Harmony(HarmonyId);
        Harmony.PatchAll();

        base.OnEnabled();
    }
    public override void OnDisabled()
    {
        Harmony?.UnpatchAll(HarmonyId);
        Harmony = null;

        base.OnDisabled();
    }
}
