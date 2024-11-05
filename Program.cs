namespace Assignment_1_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte byte1 = 1;
            byte byte2 = 2;
            int int1 = 3;
            int int2 = 4;
            double double1 = 5;
            double double2 = 6;
            decimal decimal1 = 7;
            decimal decimal2 = 8;
            string str = " {0} The greater of {1,3} and {2,3} is {3}.";

            Console.WriteLine(str, "Byte:    " ,     byte1,byte2, Math.Max(byte1, byte2));
            Console.WriteLine(str, "Int:     " ,     int1, int2, Math.Max(int1, int2));
            Console.WriteLine(str, "Double:  " ,     double1, double2, Math.Max(double1, double2));
            Console.WriteLine(str, "Decimal: " ,     decimal1, decimal2, Math.Max(decimal1, decimal2));


        }
    }
}
