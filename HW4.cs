int count = 0;
int sum = 0;
int low = 0;
int high = 0;

while (true)
{
     Console.Write("Enter a grade (-1 to stop): ");
     int grade = int.Parse(Console.ReadLine()!);
    
    if (grade == -1)
    {
        break;
    }
    if (count==0)
    {
        high = grade;
        low = grade;
    }
    if (grade > high)
    {
        high = grade;
    }
    if (grade<low)
    {
        low = grade;
    }
    sum += grade;
    count++;
}
if (count>0)
{
    double average = (double)sum / count;
    Console.WriteLine($"Number of grades: {count}");
    Console.WriteLine($"Sum: {sum}");
    Console.WriteLine($"Average: {average:F2}");
    if (high==low)
    {
    Console.WriteLine("All grades are equal");
    }
    else
    {
        Console.WriteLine($"Highest grade: {high}");
        Console.WriteLine($"Lowest grade: {low}");
    }
}
else
{
    Console.WriteLine("No grades entered.");
}




Console.Write("Enter a nuumber(1-10): ");
int n = int.Parse(Console.ReadLine()!);
if (n>=1 && n<=10)
{
    for (int i = 1; i <=10;i++)
    {
        Console.WriteLine($"{n} x {i} = {n * i}");
    }       
}
else
{
    Console.WriteLine("Please enter a number between 1 and 10.");
}
