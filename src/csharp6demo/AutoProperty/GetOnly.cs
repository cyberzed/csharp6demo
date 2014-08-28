namespace csharp6demo.AutoProperty
{
    public class GetOnly
    {
        public int Meaning { get; } = 42;

        //public int OfLife { get; }

        public GetOnly()
        {
            //Not in current CTP
            //OfLife = -42;
        }
    }
}
