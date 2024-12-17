

namespace Guitar_World {

    public class Pedal {

        // Skal det være skrevet ud som en streng eller er det ikke bedre at
        // lave en enum class med hver type pedal jeg ejer? En enum class for
        // brand (fx Boss eller Strymon) og en enum class for pedal-modellerne.
        
        public PedalBrand Brand { get; }
        public PedalModel Model { get; }
        public EffectType Type { get; }
        public bool IsActivated { get; set; }

        public Pedal (PedalBrand brand, PedalModel model, EffectType type, bool isActivated) {
            Brand = brand;
            Model = model;
            Type = type;
            IsActivated = isActivated;
        }

        /// <summary> stepOn() is method which activate and deactivate a pedal which 
        /// is not a volume pedal. </summary>
        public void stepOn() {
            if (Type == EffectType.Volume) {
                Console.WriteLine("error: " + Brand + " " + Model + " is a volume pedal and cannot be stepped on");
            }
            else {
                if (IsActivated == true) {
                    IsActivated = false;
                    Console.WriteLine(Brand + " " + Model + " has been turned off");
                }
                else {
                    IsActivated = true;
                    Console.WriteLine(Brand + " " + Model + " has been turned on");
                }
            }
        }

        /// <summary> swell() is a method used only for volume pedals since they are
        /// the only pedals which can be used for swells </summary>
        public void swell() {
            if (Type == EffectType.Volume) {
                Console.WriteLine(Brand + " " + Model + " is now doing swells:");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("guitar volume turned down while strumming note");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("guitar volume turned up as a note rings out");
            }
            else {
                Console.WriteLine("error: " + Brand + " " + Model + " is not a volume pedal and cannot be used for swells");
            }
        }
    }
}