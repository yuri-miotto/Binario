internal class Program
{
    private static void Main(string[] args)
    {
        /*
        int numero;
        int[] vetor = new int[8];

        Console.WriteLine("Informe um número na base 10: ");
        numero = int.Parse(Console.ReadLine());


        int temp = numero;

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = temp % 2;
            temp = (temp / 2);
        }

        Console.Write(numero + " na forma binária é igual a: ");

        for (int i = 7; i >= 0; i--)
        {
            
            Console.Write(vetor[i]);
        }
        

        Console.ReadKey();

        */
        

        
        int valor, resto, quociente;
        int[] binario = new int[8];
        int[] convertido = new int[8];

        Console.WriteLine("Informe um número inteiro a ser convertido");
        valor = int.Parse(Console.ReadLine());

        convertido = converter(valor);

        int[] converter(int valor)
        {
            quociente = valor;
            for (int i = 0; i < binario.Length; i++)
            {
                if((quociente==1) && (quociente % 2 == 0))
                {
                    i = binario.Length;
                }


                resto = quociente % 2;
                binario[i] = resto;
                quociente = valor / 2;
                valor = quociente;

            }
            return binario;
        }

        for (int i = binario.Length - 1; i >=0; i--)
        {
            Console.Write(binario[i] + " ");
        }
        
    }
}