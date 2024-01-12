using BepInEx;

namespace OoLunar.CompanyParty
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public sealed class CompanyPartyPlugin : BaseUnityPlugin
    {
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"{MyPluginInfo.PLUGIN_NAME} has loaded!");
        }
    }
}
