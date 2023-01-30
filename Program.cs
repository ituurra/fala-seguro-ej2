    class Ejercicio2
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] matriz = new int[3, 3];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rnd.Next(1, 10);
                }
            }

            Console.WriteLine("Matriz:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            int maxSum = 0;
            int currentSum = 0;

            for (int i = 0; i < matriz.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matriz.GetLength(1) - 1; j++)
                {
                    currentSum = matriz[i, j] + matriz[i + 1, j] + matriz[i, j + 1] + matriz[i + 1, j + 1];
                    maxSum = Math.Max(maxSum, currentSum);
                }
            }

            Console.WriteLine("El valor mas alto es: " + maxSum);
            Console.ReadLine();
        }
    }