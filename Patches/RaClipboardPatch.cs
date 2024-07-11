using HarmonyLib;
using RemoteAdmin.Communication;
using System.Text.RegularExpressions;
using static RemoteAdmin.Communication.RaClipboard;

namespace RaClipboardFix.Patches;
[HarmonyPatch(typeof(RaClipboard), nameof(RaClipboard.Send))]
public static class RaClipboardPatch
{
    [HarmonyPrefix]
    public static bool Prefix(CommandSender sender, RaClipBoardType type, string data)
    {
        // ", " to "."
        sender.RaReply($"$6 {(int)type} {string.Join(".", Regex.Split(data, ", "))}", success: true, logToConsole: false, string.Empty);
        return false;
    }
}
