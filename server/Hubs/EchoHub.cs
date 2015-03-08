using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace server.Hubs
{
    [HubName("Echo")]
    public class EchoHub : Hub
    {
        public void Echo(string message)
        {
            Clients.Caller.Echo(message);
        }

        public void EchoAll(string message)
        {
            Clients.All.Echo(message);
        }
    }
}
