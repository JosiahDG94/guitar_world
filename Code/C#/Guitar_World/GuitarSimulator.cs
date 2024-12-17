

namespace Guitar_World {

    public class GuitarSimulator {
        
        public GuitarSimulator() {

        }
    

        private static List<Chord> ChordBuilder() {
            List<Chord> chords = new List<Chord>();
            Chord C = new Chord("C", new List<string> { "C", "E", "G" }, ChordRelation.None);
            Chord Cm = new Chord("Cm", new List<string> { "C", "Eb", "G" }, ChordRelation.None);
            Chord C_Sharp = new Chord("C#", new List<string> { "C#", "F", "G#" }, ChordRelation.None);
            Chord C_Sharp_m = new Chord("C#m", new List<string> { "C#", "E", "G#" }, ChordRelation.None);
            Chord Db = new Chord("Db", new List<string> { "Db", "F", "Ab" }, ChordRelation.None);
            Chord Dbm = new Chord("Dbm", new List<string> { "Db", "E", "Ab" }, ChordRelation.None);
            Chord D = new Chord("D", new List<string> { "D", "F#", "A" }, ChordRelation.None);
            Chord Dm = new Chord("Dm", new List<string> { "D", "F", "A" }, ChordRelation.None);
            Chord D_Sharp = new Chord("D#", new List<string> { "D#", "G", "A#" }, ChordRelation.None);
            Chord D_Sharp_m = new Chord("D#m", new List<string> { "D#", "F#", "A#" }, ChordRelation.None);
            Chord Eb = new Chord("Eb", new List<string> { "Eb", "G", "Bb" }, ChordRelation.None);
            Chord Ebm = new Chord("Ebm", new List<string> { "Eb", "Gb", "Bb" }, ChordRelation.None);
            Chord E = new Chord("E", new List<string> { "E", "G#", "B" }, ChordRelation.None);
            Chord Em = new Chord("Em", new List<string> { "E", "G", "B" }, ChordRelation.None);
            Chord F = new Chord("F", new List<string> { "F", "A", "C" }, ChordRelation.None);
            Chord Fm = new Chord("Fm", new List<string> { "F", "Ab", "C" }, ChordRelation.None);
            Chord F_Sharp = new Chord("F#", new List<string> { "F#", "A#", "C#" }, ChordRelation.None);
            Chord F_Sharp_m = new Chord("F#m", new List<string> { "F#", "A", "C#" }, ChordRelation.None);
            Chord Gb = new Chord("Gb", new List<string> { "Gb", "Bb", "Db" }, ChordRelation.None);
            Chord Gbm = new Chord("Gbm", new List<string> { "Gb", "A", "Db" }, ChordRelation.None);
            Chord G = new Chord("G", new List<string> { "G", "B", "D" }, ChordRelation.None);
            Chord Gm = new Chord("Gm", new List<string> { "G", "Bb", "D" }, ChordRelation.None);
            Chord G_Sharp = new Chord("G#", new List<string> { "G#", "C", "D#" }, ChordRelation.None);
            Chord G_Sharp_m = new Chord("G#m", new List<string> { "G#", "B", "D#" }, ChordRelation.None);
            Chord Ab = new Chord("Ab", new List<string> { "Ab", "C", "Eb" }, ChordRelation.None);
            Chord Abm = new Chord("Abm", new List<string> { "Ab", "B", "Eb" }, ChordRelation.None);
            Chord A = new Chord("A", new List<string> { "A", "C#", "E" }, ChordRelation.None);
            Chord Am = new Chord("Am", new List<string> { "A", "C", "E" }, ChordRelation.None);
            Chord A_Sharp = new Chord("A#", new List<string> { "A#", "D", "F" }, ChordRelation.None);
            Chord A_Sharp_m = new Chord("A#m", new List<string> { "A#", "C#", "F" }, ChordRelation.None);
            Chord Bb = new Chord("Bb", new List<string> { "Bb", "D", "F" }, ChordRelation.None);
            Chord Bbm = new Chord("Bbm", new List<string> { "Bb", "Db", "F" }, ChordRelation.None);
            Chord B = new Chord("B", new List<string> { "B", "D#", "F#" }, ChordRelation.None);
            Chord Bm = new Chord ("Bm", new List<string> { "B", "D", "F#" }, ChordRelation.None);
            chords.Add(C);
            chords.Add(Cm);
            chords.Add(C_Sharp);
            chords.Add(C_Sharp_m);
            chords.Add(Db);
            chords.Add(Dbm);
            chords.Add(D);
            chords.Add(Dm);
            chords.Add(D_Sharp);
            chords.Add(D_Sharp_m);
            chords.Add(Eb);
            chords.Add(Ebm);
            chords.Add(E);
            chords.Add(Em);
            chords.Add(F);
            chords.Add(Fm);
            chords.Add(F_Sharp);
            chords.Add(F_Sharp_m);
            chords.Add(Gb);
            chords.Add(Gbm);
            chords.Add(G);
            chords.Add(Gm);
            chords.Add(G_Sharp);
            chords.Add(G_Sharp_m);
            chords.Add(Ab);
            chords.Add(Abm);
            chords.Add(A);
            chords.Add(Am);
            chords.Add(A_Sharp);
            chords.Add(A_Sharp_m);
            chords.Add(Bb);
            chords.Add(Bbm);
            chords.Add(B);
            chords.Add(Bm);
            return chords;
        }

        private static List<Chord> CircleofFifths(string chord, List<Chord> chords) {
            switch (chord) {
                case "C":
                    chords[0].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "G":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "F":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "Am":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "Dm":
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "Em":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;

                case "Cm":
                    chords[1].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "G":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "Fm":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "Eb":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "Ab":
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "Bb":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;

                case "C#":
                    chords[2].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "G#":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "F#":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "A#m":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "D#m":
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "Fm":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;

                case "C#m":
                    chords[3].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "G#":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "F#m":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "E":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "A":
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "B":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;

                case "Db":
                    chords[4].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "Ab":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "Gb":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "Bbm":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "Ebm":
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "Fm":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;

                case "Dbm":
                    chords[5].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "Ab":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "Gbm":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "Bbm":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "Ebm":
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "Fm":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;

                case "D":
                    chords[6].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "A":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "G":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "Bm":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "Em":
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "F#m":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;

                case "Dm":
                    chords[7].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "A":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "Gm":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "F":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "Bb":
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "C":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;

                case "D#":
                    chords[8].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "A#":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "G#":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "Cm":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "Fm":
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "Gm":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;
                
                case "D#m":
                    chords[9].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "A#":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "G#m":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "C":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "Fm":
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "Gm":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;

                case "Eb":
                    chords[10].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "Bb":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "Ab":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "Cm":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "Fm":
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "Gm":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;
                
                case "Ebm":
                    chords[11].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "Bb":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "Abm":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "Gb":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "F":
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "D":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;

                    case "E":
                        chords[12].Relation = ChordRelation.Tonic;
                        for (int i = 0; i < chords.Count; i++) {
                            switch (chords[i].Name) {
                                case "B":
                                    chords[i].Relation = ChordRelation.Dominant;
                                    break;
                                case "A":
                                    chords[i].Relation = ChordRelation.Subdominant;
                                    break;
                                case "C#m":
                                    chords[i].Relation = ChordRelation.TonicSubstitution;
                                    break;
                                case "F#m":
                                    chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                    break;
                                case "G#m":
                                    chords[i].Relation = ChordRelation.DominantSubstitution;
                                    break;
                            }
                        }
                    break;
                
                case "Em":
                    chords[13].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "B":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "Am":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "G":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "C":
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "D":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;

                case "F":
                    chords[14].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "C":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "Bb":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "Dm":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "Gm":
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "Am":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;
                
                case "Fm":
                    chords[15].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "C":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "Bbm":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "Ab":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "Db":
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "Eb":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;

                case "F#":
                    chords[16].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "C#":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "B":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "D#m":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "G#m":
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "A#m":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;
                
                case "F#m":
                    chords[17].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "C#":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "Bm":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "A":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "D":
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "E":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;
                
                case "Gb":
                    chords[18].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "Db":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "B": // = Cb
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "Ebm":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "Abm":
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "Bbm":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;
                
                case "Gbm":
                    chords[19].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "Db":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "Bm": // = Cbm
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "A": // = Bbb
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "D": // = Ebb
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "E": // = Fb
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;
                
                case "G":
                    chords[20].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "D":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "C":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "Em":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "Bm":
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "F#m":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;
                
                case "Gm":
                    chords[21].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "D":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "Cm":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "Bb":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "Eb":
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "F":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;

                case "G#":
                    chords[22].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "D#":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "C#":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "Fm":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "A#m":
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "Cm":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;
                
                case "G#m":
                    chords[23].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "D#":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "C#m":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "B":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "E": // = Eb#
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "F#":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;
                
                case "Ab":
                    chords[24].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "Eb":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "Db":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "Fm":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "Bbm":
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "Cm":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;
                
                case "Abm":
                    chords[25].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "Eb":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "Dbm":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "B":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "E": // = Fb
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "Gb":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;

                case "A":
                    chords[26].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "E":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "D":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "F#m":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "Bm":
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "C#m":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;
                
                case "Am":
                    chords[27].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "E":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "Dm":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "C":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "F": // = Eb#
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "G":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;

                case "A#":
                    chords[28].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "F":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "D#":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "Gm":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "Cm":
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "Dm":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;
                
                case "A#m":
                    chords[29].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "F":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "D#m":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "C#":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "F#": 
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "G#":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;

                case "Bb":
                    chords[30].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "F":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "Eb":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "Gm":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "Cm":
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "Dm":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;
                
                case "Bbm":
                    chords[31].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "F":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "Ebm":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "Db":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "E": 
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "Dm":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;

                case "B":
                    chords[32].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "F#":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "E":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "G#m":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "C#m":
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "D#m":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;
                
                case "Bm":
                    chords[33].Relation = ChordRelation.Tonic;
                    for (int i = 0; i < chords.Count; i++) {
                        switch (chords[i].Name) {
                            case "F#":
                                chords[i].Relation = ChordRelation.Dominant;
                                break;
                            case "Em":
                                chords[i].Relation = ChordRelation.Subdominant;
                                break;
                            case "D":
                                chords[i].Relation = ChordRelation.TonicSubstitution;
                                break;
                            case "G": 
                                chords[i].Relation = ChordRelation.SubdominantSubstitution;
                                break;
                            case "D#":
                                chords[i].Relation = ChordRelation.DominantSubstitution;
                                break;
                        }
                    }
                    break;
                
                default:
                    Console.WriteLine("Key is invalid");
                    break;
            }
            return chords;
        }

        private static void PrintChords(List<Chord> chords, string chord) {
            Console.WriteLine("");
            for (int i = 0; i < chords.Count; i++) {
                if (chords[i].Name == chord) {
                    switch (chord) {
                        case "C":
                            Console.WriteLine("E -0-");
                            Console.WriteLine("B -1-");
                            Console.WriteLine("G -0-");
                            Console.WriteLine("D -2-");
                            Console.WriteLine("A -3-");
                            Console.WriteLine("E ---");
                            break;

                        case "Cm":
                            Console.WriteLine("E -3-");
                            Console.WriteLine("B -4-");
                            Console.WriteLine("G -5-");
                            Console.WriteLine("D -5-");
                            Console.WriteLine("A -3-");
                            Console.WriteLine("E ---");
                            break;
                        
                        case "C#":
                            Console.WriteLine("E -4-");
                            Console.WriteLine("B -6-");
                            Console.WriteLine("G -6-");
                            Console.WriteLine("D -6-");
                            Console.WriteLine("A -4-");
                            Console.WriteLine("E ---");
                            break;

                        case "C#m":
                            Console.WriteLine("E -4-");
                            Console.WriteLine("B -5-");
                            Console.WriteLine("G -6-");
                            Console.WriteLine("D -6-");
                            Console.WriteLine("A -4-");
                            Console.WriteLine("E ---");
                            break;

                        case "Db":
                            Console.WriteLine("E -4-");
                            Console.WriteLine("B -6-");
                            Console.WriteLine("G -6-");
                            Console.WriteLine("D -6-");
                            Console.WriteLine("A -4-");
                            Console.WriteLine("E ---");
                            break;

                        case "Dbm":
                            Console.WriteLine("E -4-");
                            Console.WriteLine("B -5-");
                            Console.WriteLine("G -6-");
                            Console.WriteLine("D -6-");
                            Console.WriteLine("A -4-");
                            Console.WriteLine("E ---");
                            break;

                        case "D":
                            Console.WriteLine("E -2-");
                            Console.WriteLine("B -3-");
                            Console.WriteLine("G -2-");
                            Console.WriteLine("D -0-");
                            Console.WriteLine("A ---");
                            Console.WriteLine("E ---");
                            break;
                        
                        case "Dm":
                            Console.WriteLine("E -1-");
                            Console.WriteLine("B -3-");
                            Console.WriteLine("G -2-");
                            Console.WriteLine("D -0-");
                            Console.WriteLine("A ---");
                            Console.WriteLine("E ---");
                            break;

                        case "D#":
                            Console.WriteLine("E -6-");
                            Console.WriteLine("B -8-");
                            Console.WriteLine("G -8-");
                            Console.WriteLine("D -8-");
                            Console.WriteLine("A -6-");
                            Console.WriteLine("E ---");
                            break;
                        
                        case "D#m":
                            Console.WriteLine("E -6-");
                            Console.WriteLine("B -7-");
                            Console.WriteLine("G -8-");
                            Console.WriteLine("D -8-");
                            Console.WriteLine("A -6-");
                            Console.WriteLine("E ---");
                            break;

                        case "Eb":
                            Console.WriteLine("E -6-");
                            Console.WriteLine("B -8-");
                            Console.WriteLine("G -8-");
                            Console.WriteLine("D -8-");
                            Console.WriteLine("A -6-");
                            Console.WriteLine("E ---");
                            break;
                        
                        case "Ebm":
                            Console.WriteLine("E -6-");
                            Console.WriteLine("B -7-");
                            Console.WriteLine("G -8-");
                            Console.WriteLine("D -8-");
                            Console.WriteLine("A -6-");
                            Console.WriteLine("E ---");
                            break;

                        case "E":
                            Console.WriteLine("E -0-");
                            Console.WriteLine("B -0-");
                            Console.WriteLine("G -1-");
                            Console.WriteLine("D -2-");
                            Console.WriteLine("A -2-");
                            Console.WriteLine("E -0-");
                            break;

                        case "Em":
                            Console.WriteLine("E -0-");
                            Console.WriteLine("B -0-");
                            Console.WriteLine("G -0-");
                            Console.WriteLine("D -2-");
                            Console.WriteLine("A -2-");
                            Console.WriteLine("E -0-");
                            break;

                        case "F":
                            Console.WriteLine("E -1-");
                            Console.WriteLine("B -1-");
                            Console.WriteLine("G -2-");
                            Console.WriteLine("D -3-");
                            Console.WriteLine("A ---");
                            Console.WriteLine("E ---");
                            break;

                        case "Fm":
                            Console.WriteLine("E -1-");
                            Console.WriteLine("B -1-");
                            Console.WriteLine("G -1-");
                            Console.WriteLine("D -3-");
                            Console.WriteLine("A -3-");
                            Console.WriteLine("E -1-");
                            break;

                        case "F#":
                            Console.WriteLine("E -2-");
                            Console.WriteLine("B -2-");
                            Console.WriteLine("G -3-");
                            Console.WriteLine("D -4-");
                            Console.WriteLine("A -4-");
                            Console.WriteLine("E -2-");
                            break;

                        case "F#m":
                            Console.WriteLine("E -2-");
                            Console.WriteLine("B -2-");
                            Console.WriteLine("G -2-");
                            Console.WriteLine("D -4-");
                            Console.WriteLine("A -4-");
                            Console.WriteLine("E -2-");
                            break;

                        case "Gb":
                            Console.WriteLine("E -2-");
                            Console.WriteLine("B -2-");
                            Console.WriteLine("G -3-");
                            Console.WriteLine("D -4-");
                            Console.WriteLine("A -4-");
                            Console.WriteLine("E -2-");
                            break;

                        case "Gbm":
                            Console.WriteLine("E -2-");
                            Console.WriteLine("B -2-");
                            Console.WriteLine("G -2-");
                            Console.WriteLine("D -4-");
                            Console.WriteLine("A -4-");
                            Console.WriteLine("E -2-");
                            break;

                        case "G":
                            Console.WriteLine("E -3-");
                            Console.WriteLine("B -3-");
                            Console.WriteLine("G -0-");
                            Console.WriteLine("D -0-");
                            Console.WriteLine("A -2-");
                            Console.WriteLine("E -3-");
                            break;

                        case "Gm":
                            Console.WriteLine("E -3-");
                            Console.WriteLine("B -3-");
                            Console.WriteLine("G -3-");
                            Console.WriteLine("D -5-");
                            Console.WriteLine("A -5-");
                            Console.WriteLine("E -3-");
                            break;

                        case "G#":
                            Console.WriteLine("E -4-");
                            Console.WriteLine("B -4-");
                            Console.WriteLine("G -5-");
                            Console.WriteLine("D -6-");
                            Console.WriteLine("A -6-");
                            Console.WriteLine("E -4-");
                            break;
                        
                        case "G#m":
                            Console.WriteLine("E -4-");
                            Console.WriteLine("B -4-");
                            Console.WriteLine("G -4-");
                            Console.WriteLine("D -6-");
                            Console.WriteLine("A -6-");
                            Console.WriteLine("E -4-");
                            break;

                        case "Ab":
                            Console.WriteLine("E -4-");
                            Console.WriteLine("B -4-");
                            Console.WriteLine("G -5-");
                            Console.WriteLine("D -6-");
                            Console.WriteLine("A -6-");
                            Console.WriteLine("E -4-");
                            break;
                        
                        case "Abm":
                            Console.WriteLine("E -4-");
                            Console.WriteLine("B -4-");
                            Console.WriteLine("G -4-");
                            Console.WriteLine("D -6-");
                            Console.WriteLine("A -6-");
                            Console.WriteLine("E -4-");
                            break;
                        
                        case "A":
                            Console.WriteLine("E -0-");
                            Console.WriteLine("B -2-");
                            Console.WriteLine("G -2-");
                            Console.WriteLine("D -2-");
                            Console.WriteLine("A -0-");
                            Console.WriteLine("E ---");
                            break;

                        case "Am":
                            Console.WriteLine("E -0-");
                            Console.WriteLine("B -1-");
                            Console.WriteLine("G -2-");
                            Console.WriteLine("D -2-");
                            Console.WriteLine("A -0-");
                            Console.WriteLine("E ---");
                            break;
                        
                        case "A#":
                            Console.WriteLine("E -1-");
                            Console.WriteLine("B -3-");
                            Console.WriteLine("G -3-");
                            Console.WriteLine("D -3-");
                            Console.WriteLine("A -1-");
                            Console.WriteLine("E ---");
                            break;

                        case "A#m":
                            Console.WriteLine("E -1-");
                            Console.WriteLine("B -2-");
                            Console.WriteLine("G -3-");
                            Console.WriteLine("D -3-");
                            Console.WriteLine("A -1-");
                            Console.WriteLine("E ---");
                            break;

                        case "Bb":
                            Console.WriteLine("E -1-");
                            Console.WriteLine("B -3-");
                            Console.WriteLine("G -3-");
                            Console.WriteLine("D -3-");
                            Console.WriteLine("A -1-");
                            Console.WriteLine("E ---");
                            break;

                        case "Bbm":
                            Console.WriteLine("E -1-");
                            Console.WriteLine("B -2-");
                            Console.WriteLine("G -3-");
                            Console.WriteLine("D -3-");
                            Console.WriteLine("A -1-");
                            Console.WriteLine("E ---");
                            break;

                        case "B":
                            Console.WriteLine("E -2-");
                            Console.WriteLine("B -4-");
                            Console.WriteLine("G -4-");
                            Console.WriteLine("D -4-");
                            Console.WriteLine("A -2-");
                            Console.WriteLine("E ---");
                            break;

                        case "Bm":
                            Console.WriteLine("E -2-");
                            Console.WriteLine("B -3-");
                            Console.WriteLine("G -4-");
                            Console.WriteLine("D -4-");
                            Console.WriteLine("A -2-");
                            Console.WriteLine("E ---");
                            break;
                    }
                }
            }
        }

        private static void Manual() {
            Console.WriteLine("");
            Console.WriteLine("- Press '1' for Tonic chord");
            Console.WriteLine("- Press '2' for Subdominant Substitution chord");
            Console.WriteLine("- Press '3' for Dominant Substitution chord");
            Console.WriteLine("- Press '4' for Subdominant chord");
            Console.WriteLine("- Press '5' for Dominant chord");
            Console.WriteLine("- Press '6' for Tonic Substitution chord");
            Console.WriteLine("- Press 'N' for selecting new key");
            Console.WriteLine("- Press 'Q' for returning to main menu");
            Console.WriteLine("");
        }
        public static void Learn_Guitar() {
            Console.Clear();
            Console.WriteLine("Welcome to \"Learn-Guitar mode\"! ");
            Console.WriteLine("");
            Console.Write("Select key: ");
            bool keyFound = false;
            string keySelect = Console.ReadLine();
            List<Chord> chords = ChordBuilder();
            for (int j = 0; j < chords.Count; j++) {
                if (chords[j].Name == keySelect) {
                    keyFound = true;
                }
            }
            if (keyFound) {
                chords = CircleofFifths(keySelect, chords);
                for (int i = 0; i < chords.Count; i++) {
                    if (chords[i].Relation == ChordRelation.Tonic) {
                        Console.Clear();
                        Console.WriteLine("Welcome to \"Learn-Guitar mode\"! ");
                        Console.WriteLine("");
                        Console.WriteLine("You have chosen key: " + keySelect);
                        System.Threading.Thread.Sleep(5000);
                        Console.Clear();
                        Console.WriteLine("Welcome to \"Learn-Guitar mode\"! ");
                        Manual();
                        Console.WriteLine("Tonic:");
                        Console.WriteLine(chords[i].Name);
                        Console.WriteLine("-> notes: " + chords[i].Notes[0] +
                            " + " + chords[i].Notes[1] + " + " + chords[i].Notes[2]);
                        PrintChords(chords, chords[i].Name);
                    }
                }
                ConsoleKeyInfo keyPress = Console.ReadKey(true);
                while (keyPress.Key != ConsoleKey.Q) {
                    switch (keyPress.Key) {
                        case ConsoleKey.D1:
                            for (int i = 0; i < chords.Count; i++) {
                                if (chords[i].Relation == ChordRelation.Tonic) {
                                    Console.Clear();
                                    Console.WriteLine("Welcome to \"Learn-Guitar mode\"! ");
                                    Manual();
                                    Console.WriteLine("Tonic:");
                                    Console.WriteLine(chords[i].Name);
                                    Console.WriteLine("-> notes: " + chords[i].Notes[0] +
                                        " + " + chords[i].Notes[1] + " + " + chords[i].Notes[2]);
                                    PrintChords(chords, chords[i].Name);
                                    KeyPressTools.WaitForKey(ConsoleKey.D1);
                                    keyPress = Console.ReadKey(true);
                                    break;
                                }
                            }
                            break;

                        case ConsoleKey.D2:
                            for (int i = 0; i < chords.Count; i++) {
                                if (chords[i].Relation == ChordRelation.SubdominantSubstitution) {
                                    Console.Clear();
                                    Console.WriteLine("Welcome to \"Learn-Guitar mode\"! ");
                                    Manual();
                                    Console.WriteLine("Subdominant Substitution:");
                                    Console.WriteLine(chords[i].Name);
                                    Console.WriteLine("-> notes: " + chords[i].Notes[0] +
                                        " + " + chords[i].Notes[1] + " + " + chords[i].Notes[2]);
                                    PrintChords(chords, chords[i].Name);
                                    KeyPressTools.WaitForKey(ConsoleKey.D2);
                                    keyPress = Console.ReadKey(true);
                                    break;
                                }
                            }
                            break;

                        case ConsoleKey.D3:
                            for (int i = 0; i < chords.Count; i++) {
                                if (chords[i].Relation == ChordRelation.DominantSubstitution) {
                                        Console.Clear();
                                        Console.WriteLine("Welcome to \"Learn-Guitar mode\"! ");
                                        Manual();
                                        Console.WriteLine("Dominant Substitution:");
                                        Console.WriteLine(chords[i].Name);
                                        Console.WriteLine("-> notes: " + chords[i].Notes[0] +
                                        " + " + chords[i].Notes[1] + " + " + chords[i].Notes[2]);
                                        PrintChords(chords, chords[i].Name);
                                        KeyPressTools.WaitForKey(ConsoleKey.D3);
                                        keyPress = Console.ReadKey(true);
                                        break;
                                }
                            }
                            break;

                        case ConsoleKey.D4:
                            for (int i = 0; i < chords.Count; i++) {
                                if (chords[i].Relation == ChordRelation.Subdominant) {
                                    Console.Clear();
                                    Console.WriteLine("Welcome to \"Learn-Guitar mode\"! ");
                                    Manual();
                                    Console.WriteLine("Subdominant:");
                                    Console.WriteLine(chords[i].Name);
                                    Console.WriteLine("-> notes: " + chords[i].Notes[0] +
                                        " + " + chords[i].Notes[1] + " + " + chords[i].Notes[2]);
                                    PrintChords(chords, chords[i].Name);
                                    KeyPressTools.WaitForKey(ConsoleKey.D4);
                                    keyPress = Console.ReadKey(true);
                                    break; 
                                }
                            }
                            break;

                        case ConsoleKey.D5:
                            for (int i = 0; i < chords.Count; i++) {
                                if (chords[i].Relation == ChordRelation.Dominant) {
                                    Console.Clear();
                                    Console.WriteLine("Welcome to \"Learn-Guitar mode\"! ");
                                    Manual();
                                    Console.WriteLine("Dominant:");
                                    Console.WriteLine(chords[i].Name);
                                    Console.WriteLine("-> notes: " + chords[i].Notes[0] +
                                        " + " + chords[i].Notes[1] + " + " + chords[i].Notes[2]);
                                    PrintChords(chords, chords[i].Name);
                                    KeyPressTools.WaitForKey(ConsoleKey.D5);
                                    keyPress = Console.ReadKey(true);
                                    break; 
                                }
                            }
                            break;

                        case ConsoleKey.D6:
                            for (int i = 0; i < chords.Count; i++) {
                                if (chords[i].Relation == ChordRelation.TonicSubstitution) {
                                    Console.Clear();
                                    Console.WriteLine("Welcome to \"Learn-Guitar mode\"! ");
                                    Manual();
                                    Console.WriteLine("Tonic Substitution:");
                                    Console.WriteLine(chords[i].Name);
                                    Console.WriteLine("-> notes: " + chords[i].Notes[0] +
                                        " + " + chords[i].Notes[1] + " + " + chords[i].Notes[2]);
                                    PrintChords(chords, chords[i].Name);
                                    KeyPressTools.WaitForKey(ConsoleKey.D6);
                                    keyPress = Console.ReadKey(true);
                                    break; 
                                }
                            }
                            break;
                        case ConsoleKey.Q:
                            break;
                        case ConsoleKey.N:
                            Learn_Guitar();
                            break;
                    }            
                }
            }
            else {
                Console.WriteLine("Invalid key");
                System.Threading.Thread.Sleep(3000);
                Learn_Guitar();
            }          
        } 
    }
}