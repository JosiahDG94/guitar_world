

namespace Guitar_World {

    class Program {
        
        static void Main(string[] args) {
            RunSimulations Run = new RunSimulations();
            Console.Clear();
            Console.Write("Loading Guitar World...");
            System.Threading.Thread.Sleep(3000);
            Run.SimulatorLoop();
            Console.Clear();
            Console.Write("Closing Guitar World...");
            System.Threading.Thread.Sleep(3000);
            Console.Clear(); 
        }
    }
}

