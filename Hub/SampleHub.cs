using Microsoft.AspNetCore.SignalR;

public class SampleHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        // Tüm bağlı istemcilere mesaj gönderir
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}