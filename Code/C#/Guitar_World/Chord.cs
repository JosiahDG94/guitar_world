

namespace Guitar_World {

    public class Chord {

        public string Name { get; }
        public List<string> Notes { get; }
        public ChordRelation Relation { get; set; }

        /// <summary> This is the class for chords which represents how chords are built. </summary>
        /// <param name="name"> The name of the chord fx "C" or "C#m" </param>
        /// <param name="notes"> The list of notes which creates the chord. Must be exactly 3. </param>
        /// 
        /// <note> This class could be extended with more fields like fx how many B's or #'s the
        /// different keys has. </note>
        public Chord(string name, List<string> notes, ChordRelation relation) {
            Name = name;
            Notes = notes;
            Relation = relation;
        }

       
        
            
    }
}
