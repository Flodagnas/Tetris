using System.Collections;

namespace BlazorApp{
    public class CreaGrille : Block{
        public int Largeur{get; set;} = 10;
        public int Hauteur{get; set;} = 20;

        public static ArrayList CreationGrille(int Largeur, int Hauteur){            
            var Grille = new ArrayList();
            for(int i = 0; i < Hauteur; i++){
                var ligne = new ArrayList();
                for(int j = 0; j < Largeur; j++){
                        
                }
                Grille.Add(ligne);
            }
            return Grille;
        }

        public void PlaceBlock(int Largeur, int Hauteur, int[,] block, ArrayList Grille ){
            int HauteurPiece = Hauteur;
            for(int i = 0; i < block.GetLength(i); i++){
                for(int j = 0; j < block.GetLength(j); j++){
                    int[,] Test = {{Largeur, HauteurPiece}};
                    Grille = block[i,j];
                    HauteurPiece--;
                }
                Largeur++;
                Hauteur = HauteurPiece;
            }
        }
    }
}