Console.Write("Give me a number: ");
double numder = Convert.ToDouble(Console.ReadLine());
Console.Write("\nDegree of number: ");
int degree = Convert.ToInt32(Console.ReadLine());
double degree_of_numeracy = numder;

if (degree >= 0)
{

    for (int i = 1; i < degree; i++)
    {
        degree_of_numeracy = numder * degree_of_numeracy;
    }

    Console.WriteLine($"\nNumber {numder} in a power {degree} equally {degree_of_numeracy} ");

}
else
{
    // degree_of_numeracy = Math.Pow(numder, degree); // для проверки

    for (int i = -1; i > degree; i--)
    {
        degree_of_numeracy = numder * degree_of_numeracy;
    }

    Console.WriteLine($"\nNumber {numder} in a power {degree} equally {1/(degree_of_numeracy)} ");
}



