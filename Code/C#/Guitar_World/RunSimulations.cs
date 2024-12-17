

namespace Guitar_World {

    public class RunSimulations {

        public RunSimulations() {
        
        }    

        /// <summary> MainMenu is simply printing out the layout of the main menu </summary>
        private static void MainMenu() {
            Console.Clear();
            Console.WriteLine("WELCOME TO GUITAR WORLD! 👋                                | 🎸 |");
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^                                   | 🎸 |");
            Console.WriteLine("                                                           | 🎸 |");
            Console.WriteLine("MAIN MENU                                                  | 🎸 |");
            Console.WriteLine("------------------------                                   | 🎸 |");
            Console.WriteLine("- Press 'SPACE' to activate the LIVE Pedal-Sorting Show    | 🎸 |");
            Console.WriteLine("                                                           | 🎸 |");
            Console.WriteLine("- Press 'A' to see Josiahs signal chain list               | 🎸 |");
            Console.WriteLine("                                                           | 🎸 |");
            Console.WriteLine("- Press 'S' to enter the Use-Pedal Simulator               | 🎸 |");
            Console.WriteLine("                                                           | 🎸 |");
            Console.WriteLine("- Press 'D' to enter Pedal Type Seeker mode                | 🎸 |");
            Console.WriteLine("                                                           | 🎸 |");
            Console.WriteLine("- Press 'F' to enter Pick And Play mode                    | 🎸 |");
            Console.WriteLine("                                                           | 🎸 |");
            Console.WriteLine("- Press 'W' to enter Learn-Guitar mode                     | 🎸 |");
            Console.WriteLine("                                                           | 🎸 |");
            Console.WriteLine("- Press 'Q' to exit Guitar World                           | 🎸 |");
            Console.WriteLine("                                                           | 🎸 |");
            Console.WriteLine("___________________________________________________________| 🎸 |");
            Console.WriteLine(" 🎸 🎸 🎸 🎸 🎸 🎸 🎸 🎸 🎸 🎸 🎸 🎸 🎸 🎸 🎸 🎸 🎸 🎸 🎸 🎸 🎸 |");
            /// <note> Console.Write() let the user write input on the same line as the
            /// written output on the terminal. If it was Console.Writeline() it would
            /// write the input on the next line in stead </note>
            Console.Write("________________________________________________________________|");

        }

        /// <summary> SimulatorLoop() is running the whole program and calls all the functions
        /// which makes up the whole program. It is responsible for the main menu where the
        /// user can choose between the different functions and run them as well as cancel them </summary>
        public void SimulatorLoop() {
            MainMenu();
            /// <note> refer to the link for how to let the user interact with the terminal: </note>
            /// https://makolyte.com/csharp-waiting-for-user-input-in-a-console-app/
            ConsoleKeyInfo keyPress = Console.ReadKey(true);
            switch (keyPress.Key) {
                case ConsoleKey.Spacebar:
                    // Console.Clear() -> https://learn.microsoft.com/en-us/dotnet/api/system.console.setcursorposition?redirectedfrom=MSDN&view=net-6.0#System_Console_SetCursorPosition_System_Int32_System_Int32_
                    Console.Clear();
                    Console.WriteLine("The LIVE Pedal-Sorting Show will begin soon...");
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    Console.WriteLine("The pedals are now being reordered to represent Josiahs signal chain: ");
                    // System.Threading.Thread.Sleep() -> https://stackoverflow.com/questions/5449956/how-to-add-a-delay-for-a-2-or-3-seconds
                    System.Threading.Thread.Sleep(3000);  
                    Console.Clear();
                    PedalSimulator.liveSortSigCha_JDG(1000); 
                    Console.Clear();
                    Console.WriteLine("Returning to the main menu...");
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    SimulatorLoop(); 
                    break;

                case ConsoleKey.A:
                    Console.Clear();
                    PedalSimulator.instSortSigCha_JDG();
                    Console.Clear();
                    SimulatorLoop();
                    break;
                
                case ConsoleKey.S:
                    Console.Clear();
                    Console.WriteLine("Entering Use-Pedal Simulator...");
                    System.Threading.Thread.Sleep(3000);
                    PedalSimulator.usePedals_JDG(PedalSimulator.SigCha_JDG());
                    Console.Clear();
                    Console.WriteLine("Returning to the main menu...");
                    System.Threading.Thread.Sleep(3000);
                    SimulatorLoop();
                    break;
                
                case ConsoleKey.D:
                    Console.Clear();
                    Console.WriteLine("Entering Pedal Type Seeker mode...");
                    System.Threading.Thread.Sleep(3000);
                    PedalSimulator.pedalTypeSeeker(PedalSimulator.myPedals());
                    Console.Clear();
                    Console.WriteLine("Returning to the main menu...");
                    System.Threading.Thread.Sleep(3000);
                    SimulatorLoop();
                    break;

                case ConsoleKey.F:
                    Console.Clear();
                    Console.WriteLine("Entering Pick-And-Play mode...");
                    System.Threading.Thread.Sleep(3000);
                    DoubleLinkedList guitars = new DoubleLinkedList();
                    guitars.PickAndPlay();
                    Console.Clear();
                    Console.WriteLine("Returning to the main menu...");
                    System.Threading.Thread.Sleep(3000);
                    SimulatorLoop();
                    break;

                case ConsoleKey.W:
                    Console.Clear();
                    Console.WriteLine("Entering Learn-Guitar mode...");
                    System.Threading.Thread.Sleep(3000);
                    GuitarSimulator.Learn_Guitar();
                    Console.Clear();
                    Console.WriteLine("Returning to the main menu...");
                    System.Threading.Thread.Sleep(3000);
                    SimulatorLoop();
                    break;
                
                case ConsoleKey.Q:
                    break;

                default:
                    SimulatorLoop();
                    break;
            }  
        }
    }
}