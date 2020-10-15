namespace blazorserver01.Data
{
    public class BioUnit
    {
        protected string color;
        Environment parent;
        public int posx;
        public int posy;

        public int living;
        public int livingTop;

        public int hungry;
        public int hungryTop;
        public BioUnit(int x, int y, Environment e)
        {
            this.posx = x;
            this.posy = y;
            this.color = "#444444";
            this.parent = e;
        }

        public string myColor() => this.color;
        public virtual bool willIAlive()=>true;
        private bool alive; 
        public BioUnit() {
            this.alive = false;
        }
        public bool is_alive() {
            return this.alive;
        }
        public bool is_dead() {
            return !this.alive;
        }
        public void live() {
            this.alive = true;
        }
        public void die() {
            this.alive = false;
        }
    }
}