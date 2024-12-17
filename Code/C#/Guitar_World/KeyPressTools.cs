 

namespace Guitar_World {
    public class KeyPressTools {

        public KeyPressTools () {

        }

        /// <note> hasBeenPressed is a Boolean value which is used to make
        /// sure that key that is pressed is being spammed. It is used in
        /// the helper-function WaitForKey() </note>
        public static bool hasBeenPressed = false; 

        /// <summary> WaitForKey() is a helper-function which is making sure that
        /// no key pressed is being spammed </summary>
        public static void WaitForKey(ConsoleKey key) {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == key && hasBeenPressed == false) {
                hasBeenPressed = true;
                return;
            }
            else if (keyInfo.Key == key) {
                hasBeenPressed = false;
                return;
            }
        }
    }
}