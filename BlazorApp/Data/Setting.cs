namespace BlazorApp.Data{
    public class Setting{
        public Setting(int Width, int Height){
            this.Width = Width;
            this.Height = Height;
        }

        public int Height{
            private set;
            get;
        }

        public int Width{
            private set;
            get;
        }
        
        public int Vitesse { get; set; }
    }
}