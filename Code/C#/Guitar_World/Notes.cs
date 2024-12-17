/// LESSONS THAT I HAVE LEARNED ALONG THE WAY

// using System.Collections.Generic; // for List<t> -> t = any type
// using System.Linq; // for Distinct() (removes duplicates)

/// <note> You can define functions inside Main(), but you cannot
/// define their modifier level and that is not relevant either 
/// since it is defined inside Main(). refer to the link below 
/// https://stackoverflow.com/questions/8946808/can-console-clear-be-used-to-only-clear-a-line-instead-of-whole-console
/// </note>

/// <note> Static: if a method does not change its output it must be declared as static 
/// </note>

/// <note> summary: only if the summary section is written directly on top of the method
/// declared, it will show the description as you hover over the method 
/// </note>

/// <note> The reason I can't use foreach-loop in the following case is because when
/// an element is removed from the list the list is then made shorter and this causes
/// an out-of-bounds exception. In stead I use a reverse for-loop to remove the ele-
/// ments. Refer to the link below: 
/// https://stackoverflow.com/questions/1582285/how-to-remove-elements-from-a-generic-list-while-iterating-over-it 
/// </note>

/// <note> I cannot use the Distinct() in this case since it also removes the du-
/// plicate of VP Jr, but the duplicates are actually necessary. Foreach-loops 
/// or for-loops do not make any difference since Distinct().ToList<t>() will be 
/// called on the whole list and not some of it. Refer to the link below: 
/// https://www.educative.io/answers/how-to-remove-duplicates-from-a-linked-list-in-c-sharp
/// </note>
    /*
        foreach (Pedal pedal in signalChain) {
            if (pedal.Model != PedalModel.VP_Jr) {
                signalChain = signalChain.Distinct().ToList<Pedal>();
            }
        }
    */

/// <note> I wanted to delete a pedal a certain place in the 
/// chain since it was a duplicate but this resulted in getting 
/// the other pedal of the same type deleted too. This is be-
/// cause it register that the pedal was this name is located 
/// in this position and is to be deleted, but that also means 
/// that it is deleted anywhere else in the chain - therefore 
/// the for-loop did not work </note>
    /*
        for (int j = signalChain.Count - 1; j >= 7; j--) {
            if (j == signalChain.Count - 6) {
                signalChain.RemoveAt(signalChain[j]); 
            }
        }
    */

/// <note> This is how you print a list out on the terminal: </note>
    /*
        Console.WriteLine("This is my pedalboard with ordered signal chain:");
        foreach (Pedal pedal in PedalSimulator.SigCha_JDG()) { // <- SigCha_JDG returns a list
            Console.WriteLine("- " + pedal.Brand + " " + pedal.Model);
        }
    */

/// <note> Instead of using if- and if else-statements for controls, use
/// switch statements. Look at the PedalSimulator.usePedals_JDG()-method
/// as an example and compare with the one below
/// </note>
    /*
        public static void usePedals_JDG(List<Pedal> mySignalChain) {
            manual();
            ConsoleKeyInfo keyPress = Console.ReadKey(true);
            while (keyPress.Key != ConsoleKey.Q) {
                for (int i = 0; i < mySignalChain.Count - 1; i++) {
                    if (keyPress.Key == ConsoleKey.I) {
                        pedalsActivated(mySignalChain);
                        WaitForKey(ConsoleKey.I);
                    }
                    else if (keyPress.Key == ConsoleKey.N) {
                        mySignalChain[1].stepOn(); // CS-3
                        WaitForKey(ConsoleKey.N);
                    }
                    else if (keyPress.Key == ConsoleKey.B) {
                        mySignalChain[2].stepOn(); // Sovereign
                        WaitForKey(ConsoleKey.B);
                    }
                    else if (keyPress.Key == ConsoleKey.V) {
                        mySignalChain[3].stepOn(); // BD-2w
                        WaitForKey(ConsoleKey.V);
                    }
                    else if (keyPress.Key == ConsoleKey.C) {
                        mySignalChain[4].stepOn(); // EP Booster
                        WaitForKey(ConsoleKey.C);
                    }
                    else if (keyPress.Key == ConsoleKey.K) {
                        mySignalChain[5].swell(); // Volume
                        WaitForKey(ConsoleKey.K);
                    }
                    else if (keyPress.Key == ConsoleKey.M) {
                        mySignalChain[6].stepOn(); // Tuner
                        WaitForKey(ConsoleKey.M);
                    }
                    else if (keyPress.Key == ConsoleKey.J) {
                        mySignalChain[8].stepOn(); // DD-3
                        WaitForKey(ConsoleKey.J);
                    }
                    else if (keyPress.Key == ConsoleKey.H) {
                        mySignalChain[9].stepOn(); // Timeline
                        WaitForKey(ConsoleKey.H);
                    }
                    else if (keyPress.Key == ConsoleKey.G) {
                        mySignalChain[10].stepOn(); // RV-6
                        WaitForKey(ConsoleKey.G);
                    }
                    else if (keyPress.Key == ConsoleKey.F) {
                        mySignalChain[11].stepOn(); // Blue Sky
                        WaitForKey(ConsoleKey.F);
                    }
                    else if (keyPress.Key == ConsoleKey.X) {
                        mySignalChain[12].stepOn(); // RC-1
                        WaitForKey(ConsoleKey.X);
                    }
                }
            }
        } 
    */

/// <note> How to make a countdown </note>
    /*        
        Console.WriteLine("6");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("5");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("4");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("3");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("2");
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("1");
        System.Threading.Thread.Sleep(1000);
    */

/// <note> If you make a global variable which constructs a list it will 
/// keep on making lists and cause the program to crash and cause stack
/// overflow. </note>
/// example: assuming that the following is written in global scope:
/// DoubleLinkedList newList = new DoubleLinkedList(); 

/// <note> This foreach loop only works for chords with exactly 3 notes. If more advanced
/// chords were introduced which has more or maybe less than 3 notes then some extension
/// would be necessary. </note>
    /* 
        List<Chord> chords = Chord.Builder();
            foreach (Chord chord in chords) {
                Console.WriteLine(chord.Name + ": " + chord.Notes[0] + " " + chord.Notes[1] +
                    " " + chord.Notes[2]);
            }
    */

/// <note> 
/// chords[0].Name -> chord name
/// chords[0].Notes[0] -> first note of chord
/// chords[0].Notes[1] -> second note of chord
/// chords[0].Notes[2] -> third note of chord
/// </note>
