namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            //1
            //Console.WriteLine("Введите кол-во кубов: ");
            //if (int.TryParse(Console.ReadLine(), out int cubes) && cubes >= 0)
            //{
            //    Console.WriteLine($"Кол-во слоев: {Steps(cubes)}");
            //}




            //2
            //Console.WriteLine("Загадайте число от 0 до 100");

            //int left = 0;
            //int right = 100;
            //int attmps = 0;

            //while (left <= right)
            //{
            //    attmps++;
            //    int guess = left + (right - left) / 2;
            //    Console.WriteLine($"Попытка {attmps}: Моё число — {guess}.");

            //    Console.WriteLine("Ваше число больше, меньше или равно?");
            //    Console.WriteLine("Введите: 'больше', 'меньше' или 'равно' ");
            //    string response = Console.ReadLine().ToLower();

            //    if (response == "равно")
            //    {
            //        Console.WriteLine($"Число {guess} за {attmps} попыток.");
            //        break;
            //    }
            //    else if (response == "больше")
            //    {
            //        left = guess + 1; 
            //    }
            //    else if (response == "меньше")
            //    {
            //        right = guess - 1;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ошибка");
            //    }
            //}


        }

        //1
        //static int Steps(int cubes, int step = 1, int count = 0)
        //{
        //    return cubes >= step ? Steps(cubes - step, step + 1, count + 1) : count;
        //}

        
    }
 }

