using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.IO;
using System.Threading.Tasks;

namespace DiscordBOT
{
    class BOT
    {
		public static Task Main(string[] args) => new BOT().MainAsync();

		private DiscordSocketClient _client;
		public async Task MainAsync()
		{
			_client = new DiscordSocketClient();
			_client.Log += Log;


			//Configurar o Token.TXT para autenticação do BOT.
			var token = File.ReadAllText(@"C:\Users\vinic\source\repos\DiscordBOT\token.txt");

			await _client.LoginAsync(TokenType.Bot, token);
			await _client.StartAsync();

			await Task.Delay(-1);
		}

		private Task Log(LogMessage msg)
        {
			Console.WriteLine(msg.ToString());
			return Task.CompletedTask;
        }

		[Command("spawner")]
		public async Task Spawn() 
		{

		}
	}
}
