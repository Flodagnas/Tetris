namespace BlazorApp.Data{
    //Game property
    public class BoardProp{
        public BoardProp(int nWidth, int nHeight){
            this.nWidth = nWidth;
            this.nHeight = nHeight;
        }

        public int nHeight{
            private set;
            get;
        }

        public int nWidth{
            private set;
            get;
        }
    }
}