namespace T2008M_AP.Practical.Ex2
{
    public abstract class Base
    {
        protected double weight;
        protected string name;

        protected Base()
        {
        }

        protected Base(double weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }

        public abstract void Show();
        public abstract void SetMe(double weight, string name);
    }
}