

namespace Guitar_World {

    /// <note> Tutorial to create "DoubleLinkedList.cs" and "Node.cs"
    /// refer to the following link: https://www.youtube.com/watch?v=0AO7OwNzd2Y and:
    /// https://www.youtube.com/watch?v=KR3IM9adclc&t=281sote </note>
    public class DoubleLinkedList {
        private Node head;
        /// <note> tail is important to keep track off in order to be able to traverse 
        /// backwards in the double linked list when you go from tail to head </note>
        private Node tail;

        public DoubleLinkedList() {
            /// <note> null! -> refer to this link: https://stackoverflow.com/questions/67505347/non-nullable-property-must-contain-a-non-null-value-when-exiting-constructor-co </note>
            head = null!;
            tail = null!;
        }

        /// <summary> IsEmpty() simply checks if there is any elements in the
        /// list by seeing if the head of the list is null. If it is null it
        /// means that the list is empty and will return true and otherwise false </summary>
        private bool IsEmpty() {
            if (head != null) {
                return false;
            }
            else {
                return true;
            }
        }

        /// <summary> ReverseList() takes two double linked lists: the first is
        /// the list that is to be reversed while the second is the list which will
        /// contain the elements reversed </summary>
        /// <note> When ReverseList() is being called recursively it should not make 
        /// another list, but use the already created list - the while statement
        /// ensures this </note>
        public DoubleLinkedList ReverseList(DoubleLinkedList oldList, DoubleLinkedList newList) {
            newList.InsertFront(oldList.head.Guitar);
            oldList.DeleteFirstNode();
            while (!oldList.IsEmpty()) {
                ReverseList(oldList, newList);
            }
            return newList;
        }        

        /// <summary> InsertFront() is adding elements to the front of the list </summary>
        /// <note> Since I'm working with El-guitars and not just integers I have switched
        /// int data out with El_Guitar guitar </note>
        private void InsertFront(El_Guitar guitar) {
            Node newNode = new Node(guitar);
            newNode.next = head;
            newNode.prev = tail;
            if (head != null!) {
                head.prev = newNode;
                tail = head.next;
            }
            head = newNode;
        }

        /// <note> This method has been constructed from this video: https://www.youtube.com/watch?v=KR3IM9adclc </note>
        private void DeleteFirstNode() {
            Node temp = head;
            /// <note> if temp.next is null it means that there is only item left in the list </note>
            if (temp.next != null!) {
                head = temp.next;
                head.prev = null!;
                return;
            }
            else {
                head = null!;
            }
        }

        /// <summary> PrintList() is printing out chosen features of each guitar in
        /// in the double linked list. </summary>
        /// <note> this method has been inspired from the following video: https://www.youtube.com/watch?v=0AO7OwNzd2Y </note>
        public void PrintList() {
            Node runner = head;
            Console.WriteLine("List of my guitars:");
            Console.WriteLine("");
            while (runner != null!) {
                Console.WriteLine("Brand: " + runner.Guitar.Brand);
                Console.WriteLine("Model: " + runner.Guitar.GuitarModel);
                Console.WriteLine("Type: " + runner.Guitar.Type);
                Console.WriteLine("Pickup set: " + runner.Guitar.Pickups);
                Console.WriteLine("Tremolo system: " + runner.Guitar.TremSys);
                Console.WriteLine("Color: " + runner.Guitar.Color);
                Console.WriteLine("");
                runner = runner.next;
            
            }
        }

        /// <summary> myGuitars() is creating a double linked list and adds all my guitars
        /// to the list and then returns the list </summary>
        public static DoubleLinkedList MyGuitars() {
            DoubleLinkedList DL_guitarList = new DoubleLinkedList();
            List<String> strings = new List<String>();
            strings.Add(String.E_deep);
            strings.Add(String.A);
            strings.Add(String.D);
            strings.Add(String.G);
            strings.Add(String.B);
            strings.Add(String.E_high);
            El_Guitar Telecaster = new El_Guitar(4, GuitarBrand.Fender, "75TH Anni Tele Diamond Anni", GuitarType.Telecaster, 
                "Diamond Anniversary", strings, PickupSet.SS, PickupSwitchType.three_way, PickupSwitchPosition.Bridge,
                TremoloSystem.None);
            El_Guitar Black_Squier = new El_Guitar(3, GuitarBrand.Squier, "Unknown", GuitarType.Stratocaster,
                "Black" ,strings, PickupSet.SSH, PickupSwitchType.five_way, PickupSwitchPosition.Bridge,
                TremoloSystem.None);
            El_Guitar Blue_Gretsch = new El_Guitar(2, GuitarBrand.Gretsch, "G5420T Electromatic", GuitarType.Hollowbody,
                "Fairlane Blue", strings, PickupSet.HH, PickupSwitchType.three_way, PickupSwitchPosition.Bridge,
                TremoloSystem.Bigsby);
            El_Guitar Blue_Squier = new El_Guitar(1, GuitarBrand.Squier, "Unknown", GuitarType.Stratocaster,
                "Blue", strings, PickupSet.SSH, PickupSwitchType.five_way, PickupSwitchPosition.Bridge,
                TremoloSystem.Tremolo);
            DL_guitarList.InsertFront(Telecaster);
            DL_guitarList.InsertFront(Black_Squier);
            DL_guitarList.InsertFront(Blue_Gretsch);
            DL_guitarList.InsertFront(Blue_Squier);
            return DL_guitarList;
        }

        /// <summary> pickGuitar() lets you traverse the list of guitars both
        /// forwards and backwards and choose one of them </summary>
        public void PickAndPlay() {
            DoubleLinkedList guitarList = MyGuitars();
            Node pointer = guitarList.head;
            Console.Clear();
            Console.WriteLine("Press 'ENTER' to choose a guitar:");
            Console.WriteLine("");
            Console.WriteLine("Guitar " + pointer.Guitar.GuitarNr + ":  ◅  ▻");
            Console.WriteLine("------------------");
            Console.WriteLine("Brand: " + pointer.Guitar.Brand);
            Console.WriteLine("Model: " + pointer.Guitar.GuitarModel);
            Console.WriteLine("Type: " + pointer.Guitar.Type);
            Console.WriteLine("Pickup set: " + pointer.Guitar.Pickups);
            Console.WriteLine("Tremolo system: " + pointer.Guitar.TremSys);
            Console.WriteLine("Color: " + pointer.Guitar.Color);
            Console.WriteLine("");
            ConsoleKeyInfo keyPress = Console.ReadKey(true);
            while (keyPress.Key != ConsoleKey.Q) {
                switch (keyPress.Key) {
                    case ConsoleKey.RightArrow:

                        if (pointer.next == null!) {
                            pointer.next = guitarList.head;
                        }
                        pointer = pointer.next;
                        Console.Clear();
                        Console.WriteLine("Press 'ENTER' to choose a guitar:");
                        Console.WriteLine("");
                        Console.WriteLine("Guitar " + pointer.Guitar.GuitarNr + ":  ◅  ►");
                        Console.WriteLine("------------------");
                        Console.WriteLine("Brand: " + pointer.Guitar.Brand);
                        Console.WriteLine("Model: " + pointer.Guitar.GuitarModel);
                        Console.WriteLine("Type: " + pointer.Guitar.Type);
                        Console.WriteLine("Pickup set: " + pointer.Guitar.Pickups);
                        Console.WriteLine("Tremolo system: " + pointer.Guitar.TremSys);
                        Console.WriteLine("Color: " + pointer.Guitar.Color);
                        Console.WriteLine("");
                        System.Threading.Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine("Press 'ENTER' to choose a guitar:");
                        Console.WriteLine("");
                        Console.WriteLine("Guitar " + pointer.Guitar.GuitarNr + ":  ◅  ▻");
                        Console.WriteLine("------------------");
                        Console.WriteLine("Brand: " + pointer.Guitar.Brand);
                        Console.WriteLine("Model: " + pointer.Guitar.GuitarModel);
                        Console.WriteLine("Type: " + pointer.Guitar.Type);
                        Console.WriteLine("Pickup set: " + pointer.Guitar.Pickups);
                        Console.WriteLine("Tremolo system: " + pointer.Guitar.TremSys);
                        Console.WriteLine("Color: " + pointer.Guitar.Color);
                        Console.WriteLine("");
                        KeyPressTools.WaitForKey(ConsoleKey.RightArrow);
                        keyPress = Console.ReadKey(true);
                        break;

                    case ConsoleKey.LeftArrow:      
                        if (pointer.prev == null!) {
                            pointer.prev = guitarList.tail;
                        }
                        pointer = pointer.prev;
                        Console.Clear();
                        Console.WriteLine("Press 'ENTER' to choose a guitar:");
                        Console.WriteLine("");
                        Console.WriteLine("Guitar " + pointer.Guitar.GuitarNr + ":  ◄  ▻");
                        Console.WriteLine("------------------");
                        Console.WriteLine("Brand: " + pointer.Guitar.Brand);
                        Console.WriteLine("Model: " + pointer.Guitar.GuitarModel);
                        Console.WriteLine("Type: " + pointer.Guitar.Type);
                        Console.WriteLine("Pickup set: " + pointer.Guitar.Pickups);
                        Console.WriteLine("Tremolo system: " + pointer.Guitar.TremSys);
                        Console.WriteLine("Color: " + pointer.Guitar.Color);
                        Console.WriteLine("");
                        System.Threading.Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine("Press 'ENTER' to choose a guitar:");
                        Console.WriteLine("");
                        Console.WriteLine("Guitar " + pointer.Guitar.GuitarNr + ":  ◅  ▻");
                        Console.WriteLine("------------------");
                        Console.WriteLine("Brand: " + pointer.Guitar.Brand);
                        Console.WriteLine("Model: " + pointer.Guitar.GuitarModel);
                        Console.WriteLine("Type: " + pointer.Guitar.Type);
                        Console.WriteLine("Pickup set: " + pointer.Guitar.Pickups);
                        Console.WriteLine("Tremolo system: " + pointer.Guitar.TremSys);
                        Console.WriteLine("Color: " + pointer.Guitar.Color);
                        Console.WriteLine("");
                        KeyPressTools.WaitForKey(ConsoleKey.LeftArrow);
                        keyPress = Console.ReadKey(true);
                        break;

                    case ConsoleKey.Enter:
                        Console.WriteLine("You have chosen guitar " + pointer.Guitar.GuitarNr + "! ✅");
                        KeyPressTools.WaitForKey(ConsoleKey.Enter);
                        keyPress = Console.ReadKey(true);
                        // enter new mode with chosen guitar. 
                        break;
                    
                    default:
                        break;
                }
            }
        }
    }
}