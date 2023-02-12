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
        Console.WriteLine("");
        Console.WriteLine("Ex. 8:");
        switchCase();
        Console.WriteLine("");
        Console.WriteLine("Ex. 9:");
        textAnalyzer();
        Console.WriteLine("");
        Console.WriteLine("Ex. 10:");
        lineToUppercase();
        Console.WriteLine("");
        Console.WriteLine("Ex. 11:");
        NumberAnalyzer();
        Console.WriteLine("");
        Console.WriteLine("---> Program Finished! <---");
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

        for (int i = 1; i <= 10; i++)
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

        for (int i = 1; i <= 10; i++)
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

    static void switchCase() {
        Console.WriteLine("Use commas , instead of points to insert float numbers!");
        Console.Write("Enter n1: ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("");
        Console.Write("Enter n2: ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine(" Options ");
        Console.WriteLine(" 1. + ");
        Console.WriteLine(" 2. - ");
        Console.WriteLine(" 3. / ");
        Console.WriteLine(" 4. x ");

        Console.Write("Select: ");
        int opt = Convert.ToInt32(Console.ReadLine());

        switch (opt)
        {
            case 1:
                Console.Write("{0} + {1} = {2}", n1, n2, n1 + n2);
                break;
            case 2:
                Console.Write("{0} - {1} = {2}", n1, n2, n1 - n2);
                break;
            case 3:
                Console.Write("{0} / {1} = {2}", n1, n2, n1 / n2);
                break;
            case 4:
                Console.Write("{0} x {1} = {2}", n1, n2, n1 * n2);
                break;
            default:
                Console.Write("Default!");
                break;
        }
    }

    static void textAnalyzer() {
        Console.WriteLine("Enter a line of text (Maximum 60 characters):");
        string input = Console.ReadLine();

        if (input.Length > 60) input = input.Substring(0, 60);

        int charCount = input.Length;
        int wordCount = 0;
        int upperCount = 0;
        int lowerCount = 0;
        int numCount = 0;

        foreach (char c in input)
        {
            if (char.IsWhiteSpace(c)) wordCount++;

            if (char.IsUpper(c)) upperCount++;

            if (char.IsLower(c)) lowerCount++;

            if (char.IsNumber(c)) numCount++;
        }

        wordCount++;

        Console.Write("Number of char: {0}, words: {1}, uppercase: {2}, lowercase: {3} and numbers: {4}", charCount, wordCount, upperCount, lowerCount, numCount);
    }

    static void lineToUppercase() {
        Console.WriteLine("Enter a line of text (0 to exit):");
        string input = Console.ReadLine();

        while (input != "0") {
            input = input.ToUpper();
            Console.WriteLine(input);

            Console.WriteLine("Enter a line of text (0 to exit):");
            input = Console.ReadLine();
        }
    }

    static void NumberAnalyzer() {
        List<int> numbers = new List<int>();
        int value;

        Console.WriteLine("Enter a sequence of integer numbers (0 to stop):");
        
        while(int.TryParse(Console.ReadLine(), out value) && value != 0) numbers.Add(value);

        if (numbers.Count == 0) {
            Console.WriteLine("No numbers entered!");
            return;
        }

        int minValue = int.MaxValue;
        List<int> topThree = new List<int>();

        int sum = 0;
        int above10count = 0;
        int above10sum = 0;

        foreach (int num in numbers)
        {
            if (num < minValue) minValue = num;
            
            if (topThree.Count < 3) topThree.Add(num);

            if (num > topThree[0]) {
                topThree[0] = num;
                topThree.Sort();
            }

            if (num > 10) {
                above10count++;
                above10sum += num;
            }
            
            sum += num;
        }

        Console.WriteLine("Minimum value: " + minValue);
        Console.WriteLine("Three greatest values: " + string.Join(", ", topThree));
        Console.WriteLine("Mean of the whole sequence: " + (sum / numbers.Count));
        Console.WriteLine("Mean of the numbers above 10: " + (above10sum / above10count));
        Console.WriteLine("Percentage of values above 10: " + (100.0 * above10count / numbers.Count) + "%");
        Console.WriteLine("Number of values above 10: " + above10count);
    }

}