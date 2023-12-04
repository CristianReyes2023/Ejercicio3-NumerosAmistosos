using System.Collections;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingresa el primer numero del rango: ");
        var m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa el segundo numero del rango: ");
        var n = Convert.ToInt32(Console.ReadLine());
        var numero1 = 0;
        var numero2 = 0;
        ArrayList indexNum1 = new ArrayList();
        ArrayList indexNum2 = new ArrayList();
        bool AddProcess = true;
        while (AddProcess)
        {
            for (int i = m; i <= n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    numero1 = i % j;
                    if (numero1 == 0)
                    {
                        indexNum1.Add(j);
                    }
                }
                var sumaNum1 = 0;
                for (int n1 = 0; n1 < indexNum1.Count; n1++)
                {
                    sumaNum1 = sumaNum1 + Convert.ToInt32(indexNum1[n1]);
                }
                var sumaNum2 = 0;
                var j2 = 0;
                if (sumaNum1 >= m)
                {
                    for (int k = m; k <= n; k++)
                    {
                        for (int j = 1; j < n; j++)
                        {
                            numero2 = k % j;
                            if (numero2 == 0)
                            {
                                indexNum2.Add(j);
                            }
                            j2 = j;
                        }
                        for (int n2 = 0; n2 < indexNum2.Count; n2++)
                        {
                            sumaNum2 = sumaNum2 + Convert.ToInt32(indexNum2[n2]);
                        }
                        sumaNum2 = sumaNum2 - Convert.ToInt32(indexNum2[indexNum2.Count-1]);
                        if ((i == sumaNum2) & (j2 == sumaNum1))
                        {   
                            Console.WriteLine("Los numeros amistosos son:");
                            Console.WriteLine($"{i}");
                            Console.WriteLine($"{j2}");
                            Console.ReadKey();
                            AddProcess = false;
                            break;
                        }
                        indexNum2 = [];
                        sumaNum2 = 0;
                    }
                }
                indexNum1 = [];
                indexNum2 = [];
                sumaNum1 = 0;
                sumaNum2 = 0;
            }
        }

    }
}