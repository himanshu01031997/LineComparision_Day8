namespace LineComparision
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("welcome to line comparision");
            //Comparision comparision = new Comparision();
            //comparision.value(1,2,4,6);
            //comparision.calculate();
            Comparision compare1 = new Comparision(2, 9, 8, 7);//parameterised constructor
            double line1 = compare1.calculate();
            Comparision compare2 = new Comparision(2, 9, 8, 7);
            double line2 = compare2.calculate();

            if (line1.CompareTo(line2) == 0)
            {
                Console.WriteLine("line1 and line2 are equal");
            }
            else
            {
                Console.WriteLine("line1 and line2 are not equal");
            }
        }
    }
}