using System;

class Program
{
    static void Main(string[] args) {
        Console.WriteLine("---> Program started! <---");
        Console.WriteLine("Ex. 1:");
        fibonacci();
        Console.WriteLine("");
        Console.WriteLine("Ex. 2:");
        leibniz();
        Console.WriteLine("");
        Console.WriteLine("Ex. 3:");
        biggerNumber();
        Console.WriteLine("");
        Console.WriteLine("Ex. 4:");
        sumAndAverage();
        Console.WriteLine("");
        Console.WriteLine("Ex. 5:");
        reverseInput();
        Console.WriteLine("");
        Console.WriteLine("Ex. 6:");
        gcd();
        Console.WriteLine("");
        Console.WriteLine("Ex. 7:");
        readFile();
    }

    static void fibonacci() {
        int n1 = 0, n2 = 1, n3, count = 20;
            Console.Write(n1 + " " + n2 + " ");
            for (int i = 2; i < count; ++i)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }

    }

    static void leibniz() {
        int n = 1000;
            double pi = 0;
            for (int i = 0; i < n; i++)
            {
                double fraction = (4.0 / (2 * i + 1));
                
                if (i % 2 == 0)
                {
                    pi += fraction;
                } else {
                    pi -= fraction;
                }
            }
            Console.Write("PI: " + pi);
    }

    static void biggerNumber() {
        Console.WriteLine("Enter n1: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter n2: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        if (n1 > n2) Console.Write("The bigger number is " + n1);
        else Console.Write("The bigger number is " + n2);
    }

    static void sumAndAverage() {
        int n, sum = 0;
        double avg;

        Console.WriteLine("Input 10 numbers: ");

        for (int i = 1; i < 10; i++)
        {   
            Console.Write("Number-" + i + ": ");
            n = Convert.ToInt32(Console.ReadLine());
            sum += n;
        }

        avg = sum/10.0;
        Console.Write("Average = " + avg + "/ Sum = " + sum);
    }

    static void reverseInput() {
        int n = 0;
        List<int> list = new List<int>();

        Console.WriteLine("Input 10 numbers: ");

        for (int i = 1; i < 10; i++)
        {  
            Console.Write("Number-" + i + ": ");
            n = Convert.ToInt32(Console.ReadLine());
            list.Add(n);
        }

        List<int> reverse = Enumerable.Reverse(list).ToList();

        Console.Write(String.Join(',', reverse));
    }

    static void gcd() {
        Console.WriteLine("Enter n1: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter n2: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        int gcd = 1;
        int temp;

        if (n1 > n2) {
            temp = n1;
            n1 = n2;
            n2 = temp;
        }

        for (int i = 1; i < (n1+1); i++)
        {
            if(n1%i == 0 && n2%i == 0) gcd = i;
        }

        Console.Write("GCD of " + n1 + " and " + n2 + " is " + gcd);
    }

    static void readFile() {
        string fileName = "scribles.txt";

        try
        {
            using (StreamReader sr = new StreamReader(fileName)) {
                string line;
                while ((line = sr.ReadLine()) != null){
                    Console.Write(line.ToUpper());
                }
            }
        }
        catch (FileNotFoundException) {
            Console.Write("The File {0} could not be found.", fileName);
        }
        catch(Exception e)
        {
            Console.Write("An error occurred " + e.Message);
        }
    }

}