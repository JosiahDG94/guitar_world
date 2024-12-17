

namespace Guitar_World {
    
    public class PedalSimulator {

        public PedalSimulator() {
        
        }

        /// <summary> myPedals() simply makes a list with all the pedals that I own 
        /// and return this list </summary>
        public static List<Pedal> myPedals() {
        /// <note> The method needs to be static because the function does not
        /// change anything, but it does the same thing </note>
        /// <note> Below is my collection of all the pedals that I own. They can be 
        /// updated as I require more with time. </note>
        Pedal CS_3 = new Pedal(PedalBrand.Boss, PedalModel.CS_3, EffectType.Compressor, false);
        Pedal BD_2w = new Pedal(PedalBrand.Boss, PedalModel.BD_2w, EffectType.Overdrive, false);
        Pedal DD_3 = new Pedal(PedalBrand.Boss, PedalModel.DD_3, EffectType.Delay, false);
        Pedal DS_1 = new Pedal(PedalBrand.Boss, PedalModel.DS_1, EffectType.Distortion, false);        
        Pedal RC_1 = new Pedal(PedalBrand.Boss, PedalModel.RC_1, EffectType.Looper, false);
        Pedal RV_6 = new Pedal(PedalBrand.Boss, PedalModel.RV_6, EffectType.Reverb, false);
        Pedal TR_2 = new Pedal(PedalBrand.Boss, PedalModel.TR_2, EffectType.Tremolo, false);
        Pedal Tuner = new Pedal(PedalBrand.D_Addario, PedalModel.Chromatic_Pedal_Tuner, EffectType.Tuner, false);
        Pedal VP_Jr = new Pedal(PedalBrand.Ernie_Ball, PedalModel.VP_Jr, EffectType.Volume, false);
        Pedal Blue_Sky = new Pedal(PedalBrand.Strymon, PedalModel.Blue_Sky, EffectType.Reverb, false);
        Pedal Timeline = new Pedal(PedalBrand.Strymon, PedalModel.Timeline, EffectType.Delay, false);
        Pedal Buffer = new Pedal(PedalBrand.TC_Electronic, PedalModel.Bonafide_Buffer, EffectType.Buffer, false);
        Pedal Nova_Delay = new Pedal(PedalBrand.TC_Electronic, PedalModel.Nova_Delay_ND_1, EffectType.Delay, false);
        Pedal EP_Booster = new Pedal(PedalBrand.Xotic, PedalModel.EP_Booster, EffectType.Boost, false);
        Pedal Sovereign = new Pedal(PedalBrand.Wampler, PedalModel.Sovereign, EffectType.Distortion, false);
        List<Pedal> ownedPedals_JDG = new List<Pedal>();
        ownedPedals_JDG.Add(CS_3);
        ownedPedals_JDG.Add(BD_2w);
        ownedPedals_JDG.Add(DD_3);
        ownedPedals_JDG.Add(DS_1);
        ownedPedals_JDG.Add(RC_1);
        ownedPedals_JDG.Add(RV_6);
        ownedPedals_JDG.Add(TR_2);
        ownedPedals_JDG.Add(Tuner);
        ownedPedals_JDG.Add(VP_Jr);
        ownedPedals_JDG.Add(Blue_Sky);
        ownedPedals_JDG.Add(Timeline);
        ownedPedals_JDG.Add(Buffer);
        ownedPedals_JDG.Add(Nova_Delay);
        ownedPedals_JDG.Add(EP_Booster);
        ownedPedals_JDG.Add(Sovereign);
        /// <note> Since I made the function return the type List<Pedal> the 
        /// return statement is required </note>
        return ownedPedals_JDG;
        }

        /// <summary> myPedalboard makes a list of those pedals which are currently
        /// on my pedalboard and returns it </summary>
        private static List<Pedal> myPedalboard() {
            List<Pedal> pedalboard = myPedals();
            for (int i = pedalboard.Count - 1; i >= 0; i--) {
                if (pedalboard[i].Model == PedalModel.DS_1 || 
                    pedalboard[i].Model == PedalModel.Nova_Delay_ND_1 ||
                    pedalboard[i].Model == PedalModel.DD_3) {
                    pedalboard.Remove(pedalboard[i]);
                }
            }
            return pedalboard;
        }

        /// <summary> pedalTypeSeeker() takes the pedal list that is to be sought in
        /// and what effect type the pedals should have as input. It will then pre-
        /// sent the list of pedals found with this effect </summary>
        private static void pedalTypeSearch(List<Pedal> pedals, EffectType pedalType) {
            Console.WriteLine("");
            Console.WriteLine("Pedals found with effect '" + pedalType + "':");
            /// <note> pedalFound is used to check if there is any pedals that are found
            /// with a certain effect or not </note>
            bool pedalFound = false; 
            pedals = pedals.Distinct().ToList<Pedal>();
            for (int i = 0; i < pedals.Count; i++) {
                if (pedals[i].Type == pedalType) {
                    Console.WriteLine("- " + pedals[i].Brand + " " + pedals[i].Model);
                    pedalFound = true; 
                }
                else if (i == pedals.Count - 1 && !pedalFound) {
                    Console.WriteLine("No pedals found");
                } 
            }
        }

        /// <summary> manual1() will simply print out a manual for using the simulator
        /// pedalTypeSeeker() </summary>
        private static void manual1() {
            Console.Clear();
            Console.WriteLine("Pedal Type Seeker mode (feat. Josiah's owned pedals) guide:");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("- Press 'A' to search for effect: " + EffectType.Boost);
            Console.WriteLine("- Press 'S' to search for effect: " + EffectType.Buffer);
            Console.WriteLine("- Press 'D' to search for effect: " + EffectType.Chorus);
            Console.WriteLine("- Press 'F' to search for effect: " + EffectType.Compressor);
            Console.WriteLine("- Press 'G' to search for effect: " + EffectType.Delay);
            Console.WriteLine("- Press 'H' to search for effect: " + EffectType.Distortion);
            Console.WriteLine("- Press 'J' to search for effect: " + EffectType.Flanger);
            Console.WriteLine("- Press 'K' to search for effect: " + EffectType.Looper);
            Console.WriteLine("- Press 'L' to search for effect: " + EffectType.Octave);
            Console.WriteLine("- Press 'Z' to search for effect: " + EffectType.Overdrive);
            Console.WriteLine("- Press 'X' to search for effect: " + EffectType.Pitch_Shifter);
            Console.WriteLine("- Press 'C' to search for effect: " + EffectType.Reverb);
            Console.WriteLine("- Press 'V' to search for effect: " + EffectType.Tremolo);
            Console.WriteLine("- Press 'B' to search for effect: " + EffectType.Tuner);
            Console.WriteLine("- Press 'N' to search for effect: " + EffectType.Vibrato);
            Console.WriteLine("- Press 'M' to search for effect: " + EffectType.Volume);
            Console.WriteLine("- Press 'W' to search for effect: " + EffectType.Wah);
            Console.WriteLine("- Press 'Q' to return to the main menu");
        }

        /// <summary> pedalTypeSeeker() takes a list of pedals as input and then
        /// searches for the pedals that has a certain effect type indicated by
        /// the key pressed (refer to manual1()) </summary>
        public static void pedalTypeSeeker(List<Pedal> pedalboard) {
            manual1();
            ConsoleKeyInfo keyPress = Console.ReadKey(true);
            while (keyPress.Key != ConsoleKey.Q) {
                switch (keyPress.Key) {
                    case ConsoleKey.A: 
                        pedalTypeSearch(pedalboard, EffectType.Boost);
                        KeyPressTools.WaitForKey(ConsoleKey.A);
                        keyPress = Console.ReadKey(true);
                        break;

                    case ConsoleKey.S: 
                        pedalTypeSearch(pedalboard, EffectType.Buffer);
                        KeyPressTools.WaitForKey(ConsoleKey.S);
                        keyPress = Console.ReadKey(true);
                        break;

                    case ConsoleKey.D: 
                        pedalTypeSearch(pedalboard, EffectType.Chorus);
                        KeyPressTools.WaitForKey(ConsoleKey.D);
                        keyPress = Console.ReadKey(true);
                        break;

                    case ConsoleKey.F: 
                        pedalTypeSearch(pedalboard, EffectType.Compressor);
                        KeyPressTools.WaitForKey(ConsoleKey.F);
                        keyPress = Console.ReadKey(true);
                        break;

                    case ConsoleKey.G: 
                        pedalTypeSearch(pedalboard, EffectType.Delay);
                        KeyPressTools.WaitForKey(ConsoleKey.G);
                        keyPress = Console.ReadKey(true);
                        break;

                    case ConsoleKey.H: 
                        pedalTypeSearch(pedalboard, EffectType.Distortion);
                        KeyPressTools.WaitForKey(ConsoleKey.H);
                        keyPress = Console.ReadKey(true);
                        break;

                    case ConsoleKey.J: 
                        pedalTypeSearch(pedalboard, EffectType.Flanger);
                        KeyPressTools.WaitForKey(ConsoleKey.J);
                        keyPress = Console.ReadKey(true);
                        break;

                    case ConsoleKey.K: 
                        pedalTypeSearch(pedalboard, EffectType.Looper);
                        KeyPressTools.WaitForKey(ConsoleKey.F);
                        keyPress = Console.ReadKey(true);
                        break;

                    case ConsoleKey.L: 
                        pedalTypeSearch(pedalboard, EffectType.Octave);
                        KeyPressTools.WaitForKey(ConsoleKey.L);
                        keyPress = Console.ReadKey(true);
                        break;

                    case ConsoleKey.Z: 
                        pedalTypeSearch(pedalboard, EffectType.Overdrive);
                        KeyPressTools.WaitForKey(ConsoleKey.Z);
                        keyPress = Console.ReadKey(true);
                        break;

                    case ConsoleKey.X: 
                        pedalTypeSearch(pedalboard, EffectType.Pitch_Shifter);
                        KeyPressTools.WaitForKey(ConsoleKey.X);
                        keyPress = Console.ReadKey(true);
                        break;

                    case ConsoleKey.C: 
                        pedalTypeSearch(pedalboard, EffectType.Reverb);
                        KeyPressTools.WaitForKey(ConsoleKey.C);
                        keyPress = Console.ReadKey(true);
                        break;

                    case ConsoleKey.V: 
                        pedalTypeSearch(pedalboard, EffectType.Tremolo);
                        KeyPressTools.WaitForKey(ConsoleKey.V);
                        keyPress = Console.ReadKey(true);
                        break;

                    case ConsoleKey.B: 
                        pedalTypeSearch(pedalboard, EffectType.Tuner);
                        KeyPressTools.WaitForKey(ConsoleKey.B);
                        keyPress = Console.ReadKey(true);
                        break;

                    case ConsoleKey.N: 
                        pedalTypeSearch(pedalboard, EffectType.Vibrato);
                        KeyPressTools.WaitForKey(ConsoleKey.N);
                        keyPress = Console.ReadKey(true);
                        break;

                    case ConsoleKey.M: 
                        pedalTypeSearch(pedalboard, EffectType.Volume);
                        KeyPressTools.WaitForKey(ConsoleKey.M);
                        keyPress = Console.ReadKey(true);
                        break;

                    case ConsoleKey.W: 
                        pedalTypeSearch(pedalboard, EffectType.Wah);
                        KeyPressTools.WaitForKey(ConsoleKey.W);
                        keyPress = Console.ReadKey(true);
                        break;

                    default:
                        break;
                }
            }
        }

        /// <summary> instSortSigCha_JDG (= Instant Sort Signal Chain - mine)
        /// takes my list of pedals and immediately sorts them into my signal chain
        /// without showing any steps in between and prints the list in the end </summary>
        public static void instSortSigCha_JDG() {
            /// <note> This for-loop rearranges the pedals used on my pedalboard to 
            /// represent the signal chain on the board. When two VP Jrs are repre-
            /// sented it is because the VP Jr has an output for both tuner and to
            /// continue the signal chain to other pedals. </note>
            List<Pedal> signalChain = myPedalboard();
            Pedal CS_3 = new Pedal(PedalBrand.Boss, PedalModel.CS_3, EffectType.Compressor, false);
            Pedal VP_Jr = new Pedal(PedalBrand.Ernie_Ball, PedalModel.VP_Jr, EffectType.Volume, false);
            signalChain.Add(VP_Jr); // extra VP Jr needed since it both connects to tuner and the rest of the chain.
            signalChain.Add(CS_3); // temp pedal
            for (int i = signalChain.Count - 1; i >= 0; i--) {
                if (i == signalChain.Count - 2) { // VP Jr extra
                    signalChain[signalChain.Count - 1] = signalChain[7]; 
                    signalChain[7] = signalChain[i];
                }
                else if (i == signalChain.Count - 3) { // Sovereign
                    signalChain[signalChain.Count - 2] = signalChain[2];
                    signalChain[2] = signalChain[i];
                }         
                else if (i == signalChain.Count - 4) { // Booster
                    signalChain[signalChain.Count - 3] = signalChain[4];
                    signalChain[4] = signalChain[i];
                }  
                else if (i == signalChain.Count - 5) { // Buffer
                    signalChain[signalChain.Count - 4] = signalChain[0];
                    signalChain[0] = signalChain[i];
                }      
                else if (i == signalChain.Count - 6) { // Timeline
                    signalChain[signalChain.Count - 5] = signalChain[9];
                    signalChain[9] = signalChain[i];
                }   
                else if (i == signalChain.Count - 7) { // VP Jr (extra) in place, switch TR_2
                    signalChain[signalChain.Count - 6] = signalChain[signalChain.Count - 3];
                }                  
                else if (i == signalChain.Count - 8) { // VP Jr
                    signalChain[signalChain.Count - 3] = signalChain[signalChain.Count - 9];
                    signalChain[signalChain.Count - 9] = signalChain[i];
                }
                else if (i == signalChain.Count - 9) { // Tuner 
                    signalChain[signalChain.Count - 8] = signalChain[signalChain.Count - 3];
                }
                else if (i == signalChain.Count - 10) { // Booster in place, switch Blue Sky
                    signalChain[signalChain.Count - 3] = signalChain[signalChain.Count - 1];
                }
                else if (i == signalChain.Count - 11) { // RV-6
                    signalChain[signalChain.Count - 1] = signalChain[signalChain.Count - 4];
                    signalChain[signalChain.Count - 4] = signalChain[3];
                }
                else if (i == signalChain.Count - 12) { // Wampler in place, switch BD-2W
                    signalChain[signalChain.Count - 11] = signalChain[1];
                }
                else if (i == signalChain.Count - 13) { // Switch CS-3
                    signalChain[1] = signalChain[signalChain.Count - 1];
                }
                else if (i == signalChain.Count - 14) { // All pedals in place, remove CS_3 temp
                    /// <note> The solution to remove the duplicate of the temp-pedal was to
                    /// simply reverse the list and the remove the element in that particular 
                    /// index and then reverse it again. The reason I had to reverse the list
                    /// is that the wrong pedal with the same name would be removed otherwise.
                    /// When I do not iterate over the list I avoid removing the other pedal 
                    /// too with the same name </note>
                    signalChain.Reverse();
                    signalChain.Remove(signalChain[0]);
                    signalChain.Reverse();                
                    bool listPrinted = false;
                    bool exit = false;
                    while (!exit) { 
                        ConsoleKeyInfo keyPress = Console.ReadKey(true);
                        if (!listPrinted) {
                            Console.WriteLine("Josiahs signal chain:");
                            Console.WriteLine("");
                            foreach (Pedal pedal in signalChain) {
                                Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                            }
                            listPrinted = true;
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("");
                            Console.WriteLine("Press 'Q' to return to the main menu");
                        }
                        else if (keyPress.Key == ConsoleKey.Q) {
                            exit = true;
                        }
                    }
                }
            } 
        } 

        /// <summary> SigCha_JDG() does exactly the same as instSortSigCha(), but
        /// in stead of printing out the list on the terminal it in stead returns
        /// the list which then can be used in other methods </summary>
        public static List<Pedal> SigCha_JDG() {
            List<Pedal> signalChain = myPedalboard();
            Pedal CS_3 = new Pedal(PedalBrand.Boss, PedalModel.CS_3, EffectType.Compressor, false);
            Pedal VP_Jr = new Pedal(PedalBrand.Ernie_Ball, PedalModel.VP_Jr, EffectType.Volume, false);
            signalChain.Add(VP_Jr);
            signalChain.Add(CS_3); 
            for (int i = signalChain.Count - 1; i >= 0; i--) {
                if (i == signalChain.Count - 2) { // VP Jr (extra)
                    signalChain[signalChain.Count - 1] = signalChain[7]; 
                    signalChain[7] = signalChain[i];
                }
                else if (i == signalChain.Count - 3) { // Sovereign
                    signalChain[signalChain.Count - 2] = signalChain[2];
                    signalChain[2] = signalChain[i];
                }         
                else if (i == signalChain.Count - 4) { // Booster
                    signalChain[signalChain.Count - 3] = signalChain[4];
                    signalChain[4] = signalChain[i];
                }  
                else if (i == signalChain.Count - 5) { // Buffer
                    signalChain[signalChain.Count - 4] = signalChain[0];
                    signalChain[0] = signalChain[i];
                }      
                else if (i == signalChain.Count - 6) { // Timeline
                    signalChain[signalChain.Count - 5] = signalChain[9];
                    signalChain[9] = signalChain[i];
                }   
                else if (i == signalChain.Count - 7) { // VP Jr (extra) in place, switch TR_2
                    signalChain[signalChain.Count - 6] = signalChain[signalChain.Count - 3];
                }                  
                else if (i == signalChain.Count - 8) { // VP Jr
                    signalChain[signalChain.Count - 3] = signalChain[signalChain.Count - 9];
                    signalChain[signalChain.Count - 9] = signalChain[i];
                }
                else if (i == signalChain.Count - 9) { // Tuner 
                    signalChain[signalChain.Count - 8] = signalChain[signalChain.Count - 3];
                }
                else if (i == signalChain.Count - 10) { // Booster in place, switch Blue Sky
                    signalChain[signalChain.Count - 3] = signalChain[signalChain.Count - 1];
                }
                else if (i == signalChain.Count - 11) { // RV-6
                    signalChain[signalChain.Count - 1] = signalChain[signalChain.Count - 4];
                    signalChain[signalChain.Count - 4] = signalChain[3];
                }
                else if (i == signalChain.Count - 12) { // Wampler in place, switch BD-2W
                    signalChain[signalChain.Count - 11] = signalChain[1];
                }
                else if (i == signalChain.Count - 13) { // Switch CS-3
                    signalChain[1] = signalChain[signalChain.Count - 1];
                }
                else if (i == signalChain.Count - 14) {
                    signalChain.Reverse();
                    signalChain.Remove(signalChain[0]);
                    signalChain.Reverse();  
                }
            }
            return signalChain; 
        }
        
        /// <summary> liveSortSigCha_JDG (= Live Sort Signal Chain, mine)
        /// This method updates the pedal list each time pedals 
        /// have been moved around to create a simulation of how the pedals 
        /// are being sorted </summary>
        public static void liveSortSigCha_JDG(int millisec) {
            List<Pedal> signalChain = myPedalboard();
            Pedal CS_3 = new Pedal(PedalBrand.Boss, PedalModel.CS_3, EffectType.Compressor, false);
            Pedal VP_Jr = new Pedal(PedalBrand.Ernie_Ball, PedalModel.VP_Jr, EffectType.Volume, false);
            signalChain.Add(VP_Jr); // extra VP Jr needed since it both connects to tuner and the rest of the chain.
            signalChain.Add(CS_3); // temp pedal
            bool onlyOnce1 = false;
            bool onlyOnce2 = false;
            foreach (Pedal pedal in signalChain) {
                Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
            }
            System.Threading.Thread.Sleep(millisec);
            Console.Clear();
            for (int i = signalChain.Count - 1; i >= 0; i--) {
                if (i == signalChain.Count - 2) { // VP Jr extra
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[7] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[7] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else if (pedal == signalChain[signalChain.Count - 1] && !onlyOnce2) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " <-");
                            onlyOnce2 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    onlyOnce2 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    signalChain[signalChain.Count - 1] = signalChain[7]; 
                    foreach (Pedal pedal in signalChain) {
                        Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                    }
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    ////////
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[i] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[i] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else if (pedal == signalChain[7] && !onlyOnce2) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " <-");
                            onlyOnce2 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    onlyOnce2 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    signalChain[7] = signalChain[i]; 
                    foreach (Pedal pedal in signalChain) {
                        Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                    }
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                }
                else if (i == signalChain.Count - 3) { // Sovereign
                    ////////
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[2] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[2] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else if (pedal == signalChain[signalChain.Count - 2]) {
                            if (onlyOnce2) {
                                Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " <-");
                            }
                            else {
                                Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                            }
                            onlyOnce2 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    onlyOnce2 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    signalChain[signalChain.Count - 2] = signalChain[2]; 
                    foreach (Pedal pedal in signalChain) {
                        Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                    }
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    ///////
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[i] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[i] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else if (pedal == signalChain[2] && !onlyOnce2) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " <-");
                            onlyOnce2 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    onlyOnce2 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    signalChain[2] = signalChain[i]; 
                    foreach (Pedal pedal in signalChain) {
                        Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                    }
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                }         
                else if (i == signalChain.Count - 4) { // Booster
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[4] && !onlyOnce1) {
                                Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                                onlyOnce1 = true;
                            }
                            else {
                                Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                            }
                        }
                        onlyOnce1 = false;
                        System.Threading.Thread.Sleep(millisec);
                        Console.Clear();
                        foreach (Pedal pedal in signalChain) {
                            if (pedal == signalChain[4] && !onlyOnce1) {
                                Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                                onlyOnce1 = true;
                            }
                            else if (pedal == signalChain[signalChain.Count - 3]) {
                                if (onlyOnce2) {
                                    Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " <-");
                                }
                                else {
                                    Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                                }
                                onlyOnce2 = true;
                            }
                            else {
                                Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                            }                            
                        }
                        onlyOnce1 = false;
                        onlyOnce2 = false;
                        System.Threading.Thread.Sleep(millisec);
                        Console.Clear();
                        signalChain[signalChain.Count - 3] = signalChain[4]; 
                        foreach (Pedal pedal in signalChain) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                        System.Threading.Thread.Sleep(millisec);
                        Console.Clear();
                    ////////
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[i] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[i] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else if (pedal == signalChain[4] && !onlyOnce2) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " <-");
                            onlyOnce2 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    onlyOnce2 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    signalChain[4] = signalChain[i]; 
                    foreach (Pedal pedal in signalChain) {
                        Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                    }
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear(); 
                }  
                else if (i == signalChain.Count - 5) { // Buffer
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[0] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[0] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else if (pedal == signalChain[signalChain.Count - 4]) {
                            if (onlyOnce2) {
                                Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " <-");
                            }
                            else {
                                Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                            }
                            onlyOnce2 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    onlyOnce2 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    signalChain[signalChain.Count - 4] = signalChain[0]; 
                    foreach (Pedal pedal in signalChain) {
                        Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                    }
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    ////////
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[i] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[i] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else if (pedal == signalChain[0] && !onlyOnce2) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " <-");
                            onlyOnce2 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    onlyOnce2 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    signalChain[0] = signalChain[i]; 
                    foreach (Pedal pedal in signalChain) {
                        Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                    }
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear(); 
                }      
                else if (i == signalChain.Count - 6) { // Timeline
                    ////////
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[i] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[i] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else if (pedal == signalChain[9]) {
                            if (onlyOnce2) {
                                Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " <-");
                            }
                            else {
                                Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                            }
                            onlyOnce2 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    onlyOnce2 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    signalChain[9] = signalChain[i]; 
                    foreach (Pedal pedal in signalChain) {
                        Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                    }
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear(); 
                }   
                else if (i == signalChain.Count - 7) { // VP Jr (extra) in place, switch TR_2
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[signalChain.Count - 3] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[signalChain.Count - 3] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else if (pedal == signalChain[signalChain.Count - 6] && !onlyOnce2) {                          
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " <-");
                            onlyOnce2 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    onlyOnce2 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    signalChain[signalChain.Count - 6] = signalChain[signalChain.Count - 3]; 
                    foreach (Pedal pedal in signalChain) {
                        Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                    }
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                }                  
                else if (i == signalChain.Count - 8) { // VP Jr
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[signalChain.Count - 9] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[signalChain.Count - 9] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else if (pedal == signalChain[signalChain.Count - 3]) {
                            if (onlyOnce2) {
                                Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " <-");
                            }
                            else {
                                Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                            }
                            onlyOnce2 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    onlyOnce2 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    signalChain[signalChain.Count - 3] = signalChain[signalChain.Count - 9]; 
                    foreach (Pedal pedal in signalChain) {
                        Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                    }
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    ////////
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[i] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[i] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else if (pedal == signalChain[signalChain.Count - 9] && !onlyOnce2) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " <-");
                            onlyOnce2 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    onlyOnce2 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    signalChain[signalChain.Count - 9] = signalChain[i]; 
                    foreach (Pedal pedal in signalChain) {
                        Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                    }
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    
                }
                else if (i == signalChain.Count - 9) { // Tuner 
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[signalChain.Count - 3] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[signalChain.Count - 3] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else if (pedal == signalChain[signalChain.Count - 8]) {      
                            if (onlyOnce2) {                   
                                Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " <-");
                            }
                            else {
                                Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                            }
                            onlyOnce2 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    onlyOnce2 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    signalChain[signalChain.Count - 8] = signalChain[signalChain.Count - 3]; 
                    foreach (Pedal pedal in signalChain) {
                        Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                    }
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                }
                else if (i == signalChain.Count - 10) { // Booster in place, switch Blue Sky
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[signalChain.Count - 1] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[signalChain.Count - 1] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else if (pedal == signalChain[signalChain.Count - 3]) {      
                            if (onlyOnce2) {                    
                                Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " <-");
                            }
                            else {
                                Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                            }
                            onlyOnce2 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    onlyOnce2 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    signalChain[signalChain.Count - 3] = signalChain[signalChain.Count - 1]; 
                    foreach (Pedal pedal in signalChain) {
                        Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                    }
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                }
                else if (i == signalChain.Count - 11) { // RV-6
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[signalChain.Count - 4] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[signalChain.Count - 4] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else if (pedal == signalChain[signalChain.Count - 1]) {
                            if (onlyOnce2) {
                                Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " <-");
                            }
                            else {
                                Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                            }
                            onlyOnce2 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    onlyOnce2 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    signalChain[signalChain.Count - 1] = signalChain[signalChain.Count - 4]; 
                    foreach (Pedal pedal in signalChain) {
                        Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                    }
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    ////////
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[3] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[3] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else if (pedal == signalChain[signalChain.Count - 4] && !onlyOnce2) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " <-");
                            onlyOnce2 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    onlyOnce2 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    signalChain[signalChain.Count - 4] = signalChain[3]; 
                    foreach (Pedal pedal in signalChain) {
                        Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                    }
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                }
                else if (i == signalChain.Count - 12) { // Wampler in place, switch BD-2W
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[1] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[1] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else if (pedal == signalChain[signalChain.Count - 11] && !onlyOnce2) {                           
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " <-");                            
                            onlyOnce2 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    onlyOnce2 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    signalChain[signalChain.Count - 11] = signalChain[1]; 
                    foreach (Pedal pedal in signalChain) {
                        Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                    }
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                }
                else if (i == signalChain.Count - 13) { // Switch CS-3
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[signalChain.Count - 1] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    foreach (Pedal pedal in signalChain) {
                        if (pedal == signalChain[signalChain.Count - 1] && !onlyOnce1) {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " ->");
                            onlyOnce1 = true;
                        }
                        else if (pedal == signalChain[1] && !onlyOnce2) {                     
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " <-");
                            onlyOnce2 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        }
                    }
                    onlyOnce1 = false;
                    onlyOnce2 = false;
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                    signalChain[1] = signalChain[signalChain.Count - 1]; 
                    foreach (Pedal pedal in signalChain) {
                        Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                    }
                    System.Threading.Thread.Sleep(millisec);
                    Console.Clear();
                }
                else if (i == signalChain.Count - 14) {
                    foreach (Pedal pedal in signalChain) {                   
                        if (pedal == signalChain[signalChain.Count - 1]) {
                            if (onlyOnce1) {
                                Console.WriteLine("- " + pedal.Brand + " " + pedal.Model + " (removing extra pedal)");
                            }
                            else {
                                Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                            }
                            onlyOnce1 = true;
                        }
                        else {
                            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                        } 
                    }
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    signalChain.Reverse();
                    signalChain.Remove(signalChain[0]);
                    signalChain.Reverse();
                    foreach (Pedal pedal in signalChain) {
                        Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
                    }
                    System.Threading.Thread.Sleep(millisec);
                    Console.WriteLine("");
                    Console.WriteLine("Done!"); 
                    Console.WriteLine("");
                    Console.WriteLine("- Thank you for watching! 😊");
                    System.Threading.Thread.Sleep(8000);             
                }
            } 
        }

        /// <summary> pedalsActivated() takes a list of pedals as input and 
        /// then prints out a list which shows what pedals are activated or 
        /// not </summary>
        private static void pedalsActivated(List<Pedal> pedalboard) {
            Console.WriteLine("");
            foreach (Pedal pedal in pedalboard) {
                if (pedal.Type == EffectType.Volume || pedal.Type == EffectType.Buffer) {
                    continue;
                }
                else if (pedal.IsActivated) {
                    Console.WriteLine(pedal.Brand + " " + pedal.Model + ": on");
                }
                else {
                    Console.WriteLine(pedal.Brand + " " + pedal.Model + ": off");
                }
            }
        }

        /// <summary> manual2() will simply print out a manual for using the simulator
        /// usePedals_JDG() </summary>
        private static void manual2() {
            List<Pedal> pedalboard = SigCha_JDG();
            for (int i = 0; i < pedalboard.Count - 1; i++) {
                Console.Clear();
                Console.WriteLine("Use-Pedal Simulator (feat. Josiah's pedalboard) guide:");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("- Press 'N' to use the CS-3, " + "effect: " + pedalboard[1].Type);
                Console.WriteLine("- Press 'B' to use the Sovereign, " + "effect: " + pedalboard[2].Type);
                Console.WriteLine("- Press 'V' to use the BD-2w, " + "effect: " + pedalboard[3].Type);
                Console.WriteLine("- Press 'C' to use the EP Booster, " + "effect: " + pedalboard[4].Type);
                Console.WriteLine("- Press 'K' to use the VP Jr, " + "effect: " + pedalboard[5].Type);
                Console.WriteLine("- Press 'M' to use the tuner");
                Console.WriteLine("- Press 'J' to use the TR-2, " + "effect: " + pedalboard[8].Type);
                Console.WriteLine("- Press 'H' to use the Timeline, " + "effect: " + pedalboard[9].Type);
                Console.WriteLine("- Press 'G' to use the RV-6, " + "effect: " + pedalboard[10].Type);
                Console.WriteLine("- Press 'F' to use the Blue Sky, " + "effect: " + pedalboard[11].Type);
                Console.WriteLine("- Press 'X' to use the RC-1, " + "effect: " + pedalboard[12].Type);
                Console.WriteLine("- Press 'I' to see what pedals are active currently on the board");
                Console.WriteLine("- Press 'Q' to return to the main menu");
                Console.WriteLine("");
            }
        }

        /// <summary> usePedals_JDG() is a simulator which simulates using my
        /// my pedalboard when certain keys are pressed, it will 'activate' a
        /// pedal </summary>
        public static void usePedals_JDG(List<Pedal> mySignalChain) {
            manual2();
            ConsoleKeyInfo keyPress = Console.ReadKey(true);
            while (keyPress.Key != ConsoleKey.Q) {
                switch (keyPress.Key) {
                    case ConsoleKey.I:
                        pedalsActivated(mySignalChain);
                        Console.WriteLine("");
                        KeyPressTools.WaitForKey(ConsoleKey.I);
                        keyPress = Console.ReadKey(true); // This line is resetting the key
                        break;
                    
                    case ConsoleKey.N:
                        mySignalChain[1].stepOn(); // CS-3
                        KeyPressTools.WaitForKey(ConsoleKey.N); 
                        keyPress = Console.ReadKey(true);
                        break;
                    
                    case ConsoleKey.B:
                        mySignalChain[2].stepOn(); // Sovereign
                        KeyPressTools.WaitForKey(ConsoleKey.B);
                        keyPress = Console.ReadKey(true);
                        break;

                    case ConsoleKey.V:
                        mySignalChain[3].stepOn(); // BD-2w
                        KeyPressTools.WaitForKey(ConsoleKey.V);
                        keyPress = Console.ReadKey(true);
                        break;

                    case ConsoleKey.C:
                        mySignalChain[4].stepOn(); // EP Booster
                        KeyPressTools.WaitForKey(ConsoleKey.C);
                        keyPress = Console.ReadKey(true);
                        break;

                    case ConsoleKey.K:
                        mySignalChain[5].swell(); // Volume
                        KeyPressTools.WaitForKey(ConsoleKey.K);
                        keyPress = Console.ReadKey(true);
                        break;

                    case ConsoleKey.M:
                        mySignalChain[6].stepOn(); // Tuner
                        KeyPressTools.WaitForKey(ConsoleKey.M);
                        keyPress = Console.ReadKey(true);
                        break;

                    case ConsoleKey.J:
                        mySignalChain[8].stepOn(); // TR-2
                        KeyPressTools.WaitForKey(ConsoleKey.J);
                        keyPress = Console.ReadKey(true);
                        break;

                    case ConsoleKey.H:
                        mySignalChain[9].stepOn(); // Timeline
                        KeyPressTools.WaitForKey(ConsoleKey.H);
                        keyPress = Console.ReadKey(true);
                        break;

                    case ConsoleKey.G:
                        mySignalChain[10].stepOn(); // RV-6
                        KeyPressTools.WaitForKey(ConsoleKey.G);
                        keyPress = Console.ReadKey(true);
                        break;
                
                    case ConsoleKey.F:
                        mySignalChain[11].stepOn(); // Blue Sky
                        KeyPressTools.WaitForKey(ConsoleKey.F);
                        keyPress = Console.ReadKey(true);
                        break;

                    case ConsoleKey.X:
                        mySignalChain[12].stepOn(); // RC-1
                        KeyPressTools.WaitForKey(ConsoleKey.X);
                        keyPress = Console.ReadKey(true);
                        break;
                    
                    default:
                        break;
                }
            }
        }    
    }       
}