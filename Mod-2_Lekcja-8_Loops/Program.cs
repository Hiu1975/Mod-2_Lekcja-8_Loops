// Zadanie 1

Console.WriteLine("Give the upper limit of the range of the set of prime numbers");
int.TryParse(Console.ReadLine(), out int userNumber);
List<int> listToDivede = new List<int>();
listToDivede.AddRange(new List<int>() {
  2,  3,  5,  7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71,
 73, 79, 83, 89, 97});
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
