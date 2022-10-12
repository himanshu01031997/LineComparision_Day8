namespace LineComparision
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("welcome to line comparision");
            Comparision comparision = new Comparision();
            comparision.value(1,2,4,6);
            comparision.calculate();
        }
    }
}