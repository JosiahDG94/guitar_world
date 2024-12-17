

namespace Guitar_World {

    public class Guitar {
        public int GuitarNr { get; }
        public GuitarBrand Brand { get; }
        public string GuitarModel { get; }
        public GuitarType Type { get; }
        public string Color { get; }
        public List<String> Strings { get; set; }
        
    
        public Guitar (int guitarNr, GuitarBrand brand, string guitarModel, GuitarType type, string color, List<String> strings) {
            GuitarNr = guitarNr;
            Brand = brand;
            GuitarModel = guitarModel;
            Type = type;
            Color = color;
            Strings = strings;
            
        }
    }
}