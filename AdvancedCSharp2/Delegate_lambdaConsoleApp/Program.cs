namespace Delegate_lambdaConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            List<int> b = new List<int>();
            List<int> c = new List<int>();
            List<int> d = new List<int>();

            MyList<int> m = new MyList<int>() {5,3,7,8,25,1,9};

            a = m.Find(get);                //Using external function in case you need to use get fn more than one time.
            b = m.Find(delegate (int x)     //Annonymous Function if you want to use it one time (Old the replacement now is lambda)
            {
                return (x >= 5);
            } );
            c = m.Find(x => x >= 5);        //lambda expression for one use of the function x:input, x>=5 output(return).
            d= m.Find(x => {                //lambda statment.
                if(x >= 5)
                    return true;
                return false;
                    });
        }
        static bool get(int x)
        {
            return (x >= 5);
        }
    }
}