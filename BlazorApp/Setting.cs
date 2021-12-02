namespace BlazorApp;

public class Setting{
    
    public int Vitesse { get; set; }

    public int Speed(int Vitesse){
        if (Vitesse == 1)
        {
            return Vitesse;
        }
        return 0;
    }
}