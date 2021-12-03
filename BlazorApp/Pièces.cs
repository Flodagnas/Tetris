using System;

namespace BlazorApp {

    public class Piece {

        public int Largeur;
        public int Hauteur;
        public int[,] block;

    }

    public class BlocksShape {

        public static Piece[] TypePiece;

        public void ListPiece() =>
            // Liste de toutes les pièces dans tous les sens différents
            // Aider par certains groupe de la classe
            
            TypePiece = new Piece[] {
                // le "Carré"
                new Piece {
                    Largeur = 2,
                    Hauteur = 2,
                    block = new int[,] {
                        {1,1},
                        {1,1}
                    },
                },

                // le "Barre"
                new Piece {
                    Largeur = 4,
                    Hauteur = 1,
                    block = new int[,] {
                        {1,1,1,1},
                    },
                },
                new Piece {
                    Largeur = 1,
                    Hauteur = 4,
                    block = new int[,] {
                        {1},
                        {1},
                        {1},
                        {1}
                    },
                },

                // le "L"
                new Piece {
                    Largeur = 3,
                    Hauteur = 2,
                    block = new int[,] {
                        {1,0,0},
                        {1,1,1}
                    },
                },
                new Piece {
                    Largeur = 2,
                    Hauteur = 3,
                    block = new int[,] {
                        {1,1},
                        {1,0},
                        {1,0}
                    },
                },
                new Piece {
                    Largeur = 3,
                    Hauteur = 2,
                    block = new int[,] {
                        {1,1,1},
                        {0,0,1}
                    },
                },
                new Piece {
                    Largeur = 2,
                    Hauteur = 3,
                    block = new int[,] {
                        {0,1},
                        {0,1},
                        {1,1}
                    },
                },

                // le "L-reverse"
                new Piece {
                    Largeur = 3,
                    Hauteur = 2,
                    block = new int[,] {
                        {0,0,1},
                        {1,1,1}
                    }
                },
                new Piece {
                    Largeur = 2,
                    Hauteur = 3,
                    block = new int[,] {
                        {1,1},
                        {0,1},
                        {0,1}
                    }
                },
                new Piece {
                    Largeur = 3,
                    Hauteur = 2,
                    block = new int[,] {
                        {1,1,1},
                        {1,0,1}
                    }
                },
                new Piece {
                    Largeur = 2,
                    Hauteur = 3,
                    block = new int[,] {
                        {1,0},
                        {1,0},
                        {1,1}
                    }
                },

                // le "Zigzag" 
                new Piece {
                    Largeur = 3,
                    Hauteur = 2,
                    block = new int[,] {
                        {0,1,1},
                        {1,1,0}
                    },
                },
                new Piece {
                    Largeur = 3,
                    Hauteur = 2,
                    block = new int[,] {
                        {1,0},
                        {1,1},
                        {0,1}
                    }
                },

                // le "Zigzag-reverse"
                new Piece {
                    Largeur = 3,
                    Hauteur = 2,
                    block = new int[,] {
                        {1,1,0},
                        {0,1,1}
                    },
                },
                new Piece {
                    Largeur = 2,
                    Hauteur = 3,
                    block = new int[,] {
                        {0,1},
                        {1,1},
                        {1,0}
                    }
                },
               
                // le "T"
                new Piece {
                    Largeur = 3,
                    Hauteur = 2,
                    block = new int[,] {
                        {0,1,0},
                        {1,1,1}
                    },
                },
                new Piece {
                    Largeur = 2,
                    Hauteur = 3,
                    block = new int[,] {
                        {1,0},
                        {1,1},
                        {1,0}
                    }
                },
                new Piece {
                    Largeur = 3,
                    Hauteur = 2,
                    block = new int[,] {
                        {1,1,1},
                        {0,1,0}
                    },
                },
                new Piece {
                    Largeur = 2,
                    Hauteur = 3,
                    block = new int[,] {
                        {0,1},
                        {1,1},
                        {0,1}
                    }
                },
            };
    }    
}
