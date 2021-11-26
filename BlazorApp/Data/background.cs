namespace BlazorApp{
    public class Background{

        private int Largeur = 10;
        private int Hauteur = 20;

        public List<List<int>> CrationGrille(int Largeur, int Hauteur){            
            List<List<int>> Grille = new List<List<int>>();
            for(int j = 0; j < Hauteur; j++){
                List<int> line = new List<int>();
                for(int i = 0; i < Largeur; i++){
                    line.Add(0);
                    Console.Write(line[i]);
                }
                Console.WriteLine();
                Grille.Add(line);
            }
            return Grille;
        }

        public List<List<int>> MajGrille(int ligne, int colonne, int block, List<List<int>> Grille){
            return Grille;
        }
    }
}