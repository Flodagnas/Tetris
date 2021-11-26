namespace BlazorApp.Data;

public class SettingService{

    public int Speed(int Vitesse){
        if (Vitesse == 1)
        {
            return Vitesse;
        }
        return 0;
    }
}