using System.Diagnostics;
using DiscordRPC;

namespace DiscordRichPresence
{   
    class Program
    { 
        private static DiscordRpcClient client;
        private const string clientID = "1264010299128676413";
        private const string PRONTANKI_PROCESS_NAME = "ProTanki";

        static void Main(string[] args)
        {
            bool RCPStatus = false;
            client = new DiscordRpcClient(clientID);

            client.OnReady += (sender, e) =>
            {
                for (int i = 0; i < 80; i++)
                    Console.Write("=");

                Console.WriteLine("\n" + "   __    ___   ___             _____            _    _ \r\n  /__\\  / __\\ / _ \\_ __ ___   /__   \\__ _ _ __ | | _(_)\r\n / \\// / /   / /_)/ '__/ _ \\    / /\\/ _` | '_ \\| |/ / |\r\n/ _  \\/ /___/ ___/| | | (_) |  / / | (_| | | | |   <| |\r\n\\/ \\_/\\____/\\/    |_|  \\___/   \\/   \\__,_|_| |_|_|\\_\\_| \n\n Versão 1.0.0 | Feito por: floattt_");

                for (int i = 0; i < 80; i++)
                    Console.Write("=");

                Console.WriteLine($"\n\n\nOlá {e.User.Username}!");
                Console.WriteLine("O seu Rich Presence Pro Tanki para Discord está está funcionando!\n" +
                    "Pronto para mostrar para todos os seus amigos a sua jogatina no Pro Tanki!");
            };

            client.OnError += (sender, e) =>
            {
                Console.WriteLine($"Eita! Parece que ocorreu um erro. Veja se você realmente está com o discord " +
                    $"aberto e se você permite o compartilhamento de jogos!> {e.Message}");    
            };

            client.Initialize();

            bool ProTankDetected_Show = false;

            while (true) 
            {
                if(PROTankiIsRunning())
                {
                    if (!RCPStatus)
                    {
                        RCPStatus = true;
                        UpdateRCP();

                        if (!ProTankDetected_Show)
                        {
                            ProTankDetected_Show = true;
                            Console.WriteLine("RCProTank | O Pro Tanki Online foi detectado!");
                        }
                    }
                } 
                else
                {
                    if (!ProTankDetected_Show)
                        Console.WriteLine("RCProTank | O Pro Tanki Online não foi detectado! Aguardando..");
                    else
                        ProTankDetected_Show = false;

                    RCPStatus = false;
                    client.ClearPresence();
                }

                client.Invoke();
                Thread.Sleep(3000);
            }
        }

        private static void UpdateRCP()
        {
            client.SetPresence(new RichPresence()
            {
                State = "Pro Tanki Online",
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {
                    LargeImageKey = "https://wiki.pro-tanki.com/en/images/e/ef/Logo_small.png",
                    LargeImageText = "Pro Tanki"
                }
            });
        }

        private static bool PROTankiIsRunning()
        {
            return Process.GetProcessesByName(PRONTANKI_PROCESS_NAME).Length > 0 ? true : false;
        }
    }
}