// Zadanie 1

Console.WriteLine("Give the upper limit of the range of the set of prime numbers");
int.TryParse(Console.ReadLine(), out int userNumber);
List<int> listToDivede = new List<int>();
listToDivede.AddRange(new List<int>() {
  2,  3,  5,  7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71,
 73, 79, 83, 89, 97/*,101,103,107,109,113,127,131,137,139,149,151,157,163,167,173,
179,181,191,193,197,199,211,223,227,229,233,239,241,251,257,263,269,271,277,281,
283,293,307,311,313,317,331,337,347,349,353,359,367,373,379,383,389,397,401,409,
419,421,431,433,439,443,449,457,461,463,467,479,487,491,499,503,509,521,523,541,
547,557,563,569,571,577,587,593,599,601,607,613,617,619,631,641,643,647,653,659,
661,673,677,683,691,701,709,719,727,733,739,743,751,757,761,769,773,787,797,809,
811,821,823,827,829,839,853,857,859,863,877,881,883,887,907,911,919,929,937,941,
947,953,967,971,977,983,991,997*/});
int primeNumber = 0;
int counter = 25;
for (int i = 2; i <= userNumber; i++)
{
   foreach (int item in listToDivede)
   {
       if (i % item == 0)
       {
           primeNumber++;
       }
   }
   if (primeNumber == 0)
   {
       counter++;
       //Console.Write($"{i} ");

   }
   primeNumber = 0;
}

Console.WriteLine($"Quantity of Primes numbers in range 0-{userNumber} is: {counter}");
Console.WriteLine();

// Zadanie1 ver.2

bool isPrimeNumber(int number)
{
   for (int i = 2; i < number; i++)
   {
       if (number % i == 0)
       {
           return (false);
       }
   }
   return (true);
}
Console.Write("Upper range of Prime Numbers: ");
int counterPN = 1;
int.TryParse(Console.ReadLine(), out int numUser);
for (int i = 3; i <= numUser; i += 2)
{
   if (isPrimeNumber(i) == true)
   {
       counterPN++;
       // Console.WriteLine(i);
   }
}
Console.WriteLine($"W zakresie 0-{numUser} is: {counterPN} Primes Number");

// Zadanie 2

int oddEven = 1;

do
{
   if (oddEven % 2 == 0)
   {
       Console.WriteLine(oddEven); 
   }
   oddEven++;
} while (oddEven < 1000);

//Zadanie 3

Console.Write("How many first elements of Fibonacci Sequence do you want to display ? ");

int.TryParse(Console.ReadLine(), out int elementsFS);
int[] sequenceFibonacci = new int[elementsFS];

for (int i = 2; i < elementsFS; i++)
{
   sequenceFibonacci[0] = 1;
   sequenceFibonacci[1] = 1;
   sequenceFibonacci[i] = sequenceFibonacci[i - 2] + sequenceFibonacci[i - 1];
}
for (int i = 0; i < sequenceFibonacci.Length; i++)
{
   Console.WriteLine($"F({i+1}) = {sequenceFibonacci[i]}");
}

// Zadanie 4

{
   int.TryParse(Console.ReadLine(), out int numFromUser);
   int numToPrint = 1;  
   int columnCounter = 1;
   while (numToPrint <= numFromUser)
   {
       for (int i = 1; i <= columnCounter; i++)
       {
           Console.Write($"{numToPrint} ");
           numToPrint++;
           if (numToPrint > numFromUser) 
           {
               break;
           }
       }
       columnCounter++;
       Console.WriteLine();
   }
}

int numberD = int.Parse(Console.ReadLine());
string numberB = "";
while (numberD > 0)
{
    numberB = (numberD % 2) + numberB;
    numberD = numberD / 2;
}
Console.WriteLine(numberB);

//zad 10

Console.Write("1st: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("2nd: ");
int n2 = int.Parse(Console.ReadLine());
int sum = n1 * n2;
for (int i = 2; i <= sum; i++)
{
    n1 *= i;
    n2 *= i;
    if (n1 == n2)
    {
        Console.WriteLine($"wynik= {n1 * n2}");
        break;
    }
}

{
    Console.WriteLine("Enter the first number: ");
    string firstNumber = Console.ReadLine();

    Console.WriteLine("Enter the second number: ");
    string secondNumber = Console.ReadLine();

    int firstNum = 0;
    int secondNum = 0;

    Int32.TryParse(firstNumber, out firstNum);
    Int32.TryParse(secondNumber, out secondNum);

    int multiply = firstNum * secondNum;

    if (firstNum > 0 & secondNum > 0)
    {
        while (firstNum != secondNum)
        {
            if (firstNum > secondNum)
            {
                firstNum -= secondNum;
            }
            else if (firstNum < secondNum)
            {
                secondNum -= firstNum;
            }

        }

        int leastMultiple = multiply / firstNum;
        Console.WriteLine($"The least common multiple of two given numbers is: {leastMultiple}");

    }

    else
    {
        Console.WriteLine("Error, zero is undefined");
    }
}

/*
int NWD(int a, int b)
{
    int c;
    while (b != 0)
    {
        c = a % b;
        a = b;
        b = c;

    }
    return a;
}
int a= int.Parse(Console.ReadLine());
int b= int.Parse(Console.ReadLine());
Console.WriteLine($"NWD={NWD(a,b)}");
Console.WriteLine($"NWW={a*b/NWD(a,b)}");
*/