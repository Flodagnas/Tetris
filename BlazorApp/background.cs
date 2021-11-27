namespace BlazorApp{
    public class Background{
        public int Largeur = 10;
        public int Hauteur = 20;

        public static List<List<int>> CreationGrille(int Largeur, int Hauteur){            
            List<List<int>> Grille = new List<List<int>>();
            for(int i = 0; i < Hauteur; i++){
                List<int> line = new List<int>();
                for(int j = 0; j < Largeur; j++){
                    line.Add(0);
                    Console.Write(line[j]);
                }
                Console.WriteLine();
                Grille.Add(line);
            }
            return Grille;
        }
    }
}