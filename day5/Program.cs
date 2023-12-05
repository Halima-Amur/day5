namespace day5
{

    class program
    {


        static void PrintLine(string Pattren, int LengthPattren, Boolean Flag)
        {
            for (int i = 0; i < LengthPattren; i++)
            {
                Console.WriteLine(Pattren, i);
                Console.WriteLine();
            }
            if (Flag)
            {
                Console.WriteLine();
            }

        }
        static void swap(ref int x, ref int y)
        {
            Console.WriteLine($"original {x}, {y}");
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine($"ref {y}, ref {x}");
            swap(ref x, ref y);

        }
        static void Main()
        {
            int a = 10, b = 3;
            
            swap(ref a,ref b);
            Console.WriteLine($"A value is {a} , B value is {b}");
            


        }
 
    }


}

