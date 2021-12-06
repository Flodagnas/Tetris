using System.Collections;

namespace BlazorApp{
    public class CreaGrille{
        public int Largeur = 10;
        public int Hauteur = 20;

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
    }
}