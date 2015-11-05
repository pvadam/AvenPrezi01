namespace FactoryPattern
{
    //  class Clerk : IPosition
    class Clerk : Position
    {
        // public string Title
        public override string Title
        {
            get
        {
            return "Clerk";
        }
        }
    }
}