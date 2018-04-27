using GameStore.Commands;
using GameStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game("GameA");
            Dictionary<String, ICommand> commands = new Dictionary<string, ICommand>();
            commands.Add("buy", new BuyCommand(g));
            commands.Add("download", new DownloadCommand(g));
            commands.Add("install", new InstallCommand(g));
            commands.Add("lend", new LendCommand(g));
            commands.Add("retrieve", new RetrieveCommand(g));
            commands.Add("start", new StartCommand(g));
            commands.Add("uninstall", new UninstallCommand(g));
            while (true)
            {
                Console.WriteLine("What do you want to do?");
                string s = Console.ReadLine();
                try
                {
                    commands[s].Execute();
                }
                catch (KeyNotFoundException)
                {
                    Console.WriteLine("Invalid command");
                }
            }
        }
    }
}
