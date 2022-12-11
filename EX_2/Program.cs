Console.Write("Give me a number: ");
int numder = Convert.ToInt32(Console.ReadLine());

int [] myArray = Array.ConvertAll (numder.ToString ().ToCharArray (), x => (int)Char.GetNumericValue (x));
Console.WriteLine($"\nsum of all array elements:{myArray.Sum()}");