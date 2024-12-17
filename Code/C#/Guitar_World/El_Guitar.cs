

namespace Guitar_World {

    public class El_Guitar : Guitar { 
        public PickupSet Pickups { get; set; }
        public PickupSwitchType PickupSwitchType { get; }
        public PickupSwitchPosition PickupPosition { get; set; }
        public TremoloSystem TremSys { get; set; }

        public El_Guitar (int guitarNr, GuitarBrand brand, string guitarModel, GuitarType type, string color, List<String> strings) :
            base (guitarNr, brand, guitarModel, type, color, strings) {}
        
        public El_Guitar (int guitarNr, GuitarBrand brand, string guitarModel, GuitarType type, string color, List<String> strings, 
            PickupSet pickups, PickupSwitchType pickupSwitchType, PickupSwitchPosition pickupPosition,
            TremoloSystem tremSys) : base (guitarNr, brand, guitarModel, type, color, strings) {
        Pickups = pickups;
        PickupSwitchType = pickupSwitchType;
        PickupPosition = pickupPosition;
        TremSys = tremSys;
        }  
    }
}