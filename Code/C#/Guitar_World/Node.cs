

namespace Guitar_World {
    /// <note> This is made inspired from page 167 in "C# Precisely", BUT the class
    ///  could not implement the interface </note>
    public class Node {
        public El_Guitar Guitar;
        public Node prev;
        public Node next;
    
        public Node (El_Guitar guitar) {
            Guitar = guitar;
            /// <note> null! -> refer to this link: https://stackoverflow.com/questions/67505347/non-nullable-property-must-contain-a-non-null-value-when-exiting-constructor-co </note>
            prev = null!;
            next = null!;
        }
    }
}