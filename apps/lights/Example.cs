using System.Threading.Tasks;
using JoySoftware.HomeAssistant.NetDaemon.Common;

public class Example : NetDaemonApp
{
    public override async Task InitializeAsync()
    {
        await CallService("light", "turn_off", new {entity_id = "all"});
    }
}