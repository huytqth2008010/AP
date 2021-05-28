namespace T2008M_AP.AssignmentOne
{
    public abstract class Clothing
    {
        protected string[] regionsWithMaximumSales
        {
            get;
            set;
        }
        protected string[] regionsWithAvgSales;
        protected string[] regionsWithLowSales;

        protected string[] materials;

        public abstract void Sales();
        public abstract void Materials();
        public abstract void CommonWear();
    }
}