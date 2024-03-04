using System.Text;

// Zadanie 1

Console.WriteLine("Give the upper limit of the range of the set of prime numbers");
int.TryParse(Console.ReadLine(), out int userNumber);
List<int> listToDivede = new List<int>();
listToDivede.AddRange(new List<int>() {
  2,  3,  5,  7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71,
 73, 79, 83, 89, 97,101,103,107,109,113,127,131,137,139,149,151,157,163,167,173,
179,181,191,193,197,199,211,223,227,229,233,239,241,251,257,263,269,271,277,281,
283,293,307,311,313,317,331,337,347,349,353,359,367,373,379,383,389,397,401,409,
419,421,431,433,439,443,449,457,461,463,467,479,487,491,499,503,509,521,523,541,
547,557,563,569,571,577,587,593,599,601,607,613,617,619,631,641,643,647,653,659,
661,673,677,683,691,701,709,719,727,733,739,743,751,757,761,769,773,787,797,809,
811,821,823,827,829,839,853,857,859,863,877,881,883,887,907,911,919,929,937,941,
947,953,967,971,977,983,991,997});
int divisorsNumber = 0;
int counter = 168;
for (int i = 2; i <= userNumber; i++)
{
   foreach (int item in listToDivede)
   {
       if (i % item == 0)
       {
           divisorsNumber++;
       }
   }
   if (divisorsNumber == 0)
   {
       counter++;
       //Console.Write($"{i} ");

   }
   divisorsNumber = 0;
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
Console.WriteLine();
Console.WriteLine("Enter random integer number.");
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

//zadanie 5

Console.WriteLine();
Console.WriteLine("Algorithm display 3rd power of numbers from 1 to 20.");
for (int i = 1; i<=20;  i++)
{
    double result = Math.Pow(i, 3);
    Console.WriteLine($"{i}^3= {result}");
}


//zadanie 6

Console.WriteLine();
Console.WriteLine("Program calculate and display sum of numbers 1-20 like 1 + 1/2 + 1/3 +...+ 1/20 ");
double sumOfSequence = 0;
for (int i = 1; i < 20; i++)
{
    sumOfSequence += 1.0 / i;
}
Console.WriteLine(Math.Round(sumOfSequence, 2));


//zadanie 7




{
    Console.WriteLine();
    Console.WriteLine("Enter the length of the diagonal of the diamond I want to draw.?");
    int.TryParse(Console.ReadLine(), out int diagonal);
    if (diagonal % 2 == 0)
    {
        Console.WriteLine("You entered an odd number, in the case of even numbers it is impossible to draw a diamond that meets the conditions imposed in the task.");
    }
    else
    {
        StringBuilder lineToPrint = new StringBuilder();
        for (int numOfStars = 1; numOfStars <= diagonal; numOfStars = numOfStars + 2)
        {
            int numOfSpaces = (diagonal - numOfStars) / 2;
            Console.Write(lineToPrint.Append(' ', numOfSpaces));
            lineToPrint.Clear();
            Console.WriteLine(lineToPrint.Append('*', numOfStars));
            lineToPrint.Clear();
        }
        for (int numOfStars = diagonal - 2; numOfStars >= 1; numOfStars = numOfStars - 2)
        {
            int numOfSpaces = (diagonal - numOfStars) / 2;
            lineToPrint.Append(' ', numOfSpaces);
            lineToPrint.Append('*', numOfStars);
            lineToPrint.Append("\r\n");
        }
        Console.WriteLine(lineToPrint);
    }
}

//zadanie 8

Console.WriteLine();
Console.WriteLine("Program revers a string Abcdefg");
string input = "Abcdefg";
string output = "";
string output2 = "";
for (int i = input.Length - 1; i > 0; i--)
{
    if (i == input.Length - 1)
    {
        output += input[i];
        output = output.ToUpper();
    }
    else
    {
        output += input[i];
    }
}
output2 += input[0];
output += output2.ToLower();
Console.WriteLine(output);

//zadanie 9

Console.WriteLine();
Console.WriteLine("Enter decimal number which u want to convert to binary.");
int.TryParse(Console.ReadLine(), out int numDecimal);
string numBinary = "";
while (numDecimal > 0)
{
    numBinary = numDecimal % 2 + numBinary;
    numDecimal /= 2;
}
Console.WriteLine(numBinary);

//zadanie 10

Console.WriteLine();
Console.WriteLine("Program finding Least Common Multiple (LCM) of 2 integers numbers.");

int GCD(int first, int second)  //GCD Greatest Common Divisor
{
    int auxNum;
    while (second != 0)
    {
        auxNum = first % second;
        first = second;
        second = auxNum;

    }
    return first;
}

int.TryParse(Console.ReadLine(), out int firstNum);
int.TryParse(Console.ReadLine(), out int secondNum);
Console.WriteLine($"GCD={GCD(firstNum, secondNum)}");
Console.WriteLine($"LCM={firstNum * secondNum / GCD(firstNum, secondNum)}");
