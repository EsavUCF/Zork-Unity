using System;

namespace Zork
{

    class Program
    {
        static void Main(string[] args)
        {
            const string defaultGameFilename = "Zork.json";
            string gameFilename = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename] : defaultGameFilename);

            ConsoleOutputService output = new ConsoleOutputService();
           // ConsoleInputService input = new ConsoleInputService();
            Game game = Game.Load(gameFilename, output);
            output.WriteLine("Welcome to Zork!");

            //game.Player.LocationChanged += Player_LocationChanged;
            game.Run();//input, output);
            output.WriteLine("Thank you for playing!");
        //EventHandler<Room> handler = MyHandler;
        
       
        }

        private enum CommandLineArguments
        {
            GameFilename = 0

        }
    
    private static void MyHandler(object sender, Room args) //in class addition, 2:26PM Panopto.
        {

        }    
    
    
    }
}