namespace blazorserver01.Data
{
    public class Rabbit:  Data.BioUnit
    {
        public Rabbit(int x, int y, Data.Environment e) : base(x ,y, e){
            this.color ="#fafafa";
            this.living=0;
            this.livingTop=3;                     
        }

        public override bool willIAlive()
        {
            this.hungry++;
            this.living++;
            if((this.living-1)>=this.livingTop) return false;            
            return true;
        } 

        public void eat(){
            this.hungry=0;
        }
    }
}