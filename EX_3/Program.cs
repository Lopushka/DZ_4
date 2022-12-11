int product(int asd)
{
    int[] myArray = Array.ConvertAll(asd.ToString().ToCharArray(), x => (int)Char.GetNumericValue(x));
    int composition = 1;

    for (int i = 0; i < myArray.Length; i++)
    {

        composition = composition * myArray[i];
    }
    return composition;
}

int summer(int asd)
{
    int[] myArray = Array.ConvertAll(asd.ToString().ToCharArray(), x => (int)Char.GetNumericValue(x));
    int sum_nnumber = myArray.Sum();
    return sum_nnumber;
}


Console.Write("\nВведите количество «интересных» элиментов массива:\t ");

int elementsCont = Convert.ToInt32(Console.ReadLine());  //int.Parse(Console.ReadLine()); 

if (elementsCont == 0)
{
    Console.WriteLine("\nIs not a valid value");


}
if (elementsCont < 0)
{
    Console.WriteLine("\nIs not a valid value");

}
if (elementsCont > 0)
{


    int[] myArray = new int[elementsCont];
    Random random = new Random();
    Console.WriteLine();
    Console.Write($"Генерирую массив на {elementsCont} «интересных» случайных целых чисел от 10 до 1000");
    Console.WriteLine();
    Console.Write("\nВывожу массив: ");
    for (int i = 0; i < myArray.Length; i++)
    {
    loop1:
        myArray[i] = random.Next(10, 1000);
        double a = Convert.ToDouble(product(myArray[i]));
        double b = Convert.ToDouble(summer(myArray[i]));

        if (a % b == 0 && a != 0)
        {
            Console.Write(myArray[i] + " ");
        }
        if (a % b != 0 || a == 0)
        {
            goto loop1;

        }

    }
}

