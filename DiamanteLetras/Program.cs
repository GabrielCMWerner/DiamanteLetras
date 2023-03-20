namespace DiamanteLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira uma letra para o centro do desenho: ");
            char letrainf = Convert.ToChar(Console.ReadLine());

            char letraA = 'A';

            int espacosfora = letrainf - letraA;

            int linhas = letrainf - letraA;

            int espacodentro = -1;

            char letra = 'A';

            //cima
            for (int linha = 0; linha < linhas; linha++)
            {


                for (int i = 0; i < espacosfora; i++)
                {
                    Console.Write(" ");
                }

                if (letra != 'A')
                {
                    Console.Write(letra);
                }

                for (int i = 0; i < espacodentro; i++)
                {
                    Console.Write(" ");
                }

                Console.Write(letra);

                letra++;
                espacosfora--;
                espacodentro += 2;

                Console.WriteLine();

            }

            //meio
            Console.Write(letrainf);

            for (int i = 0; i < espacodentro; i++)
            {
                Console.Write(" ");
            }

            Console.Write(letrainf);

            Console.WriteLine();

            letra--;
            espacosfora++;
            espacodentro -= 2;

            //baixo
            for (int linha = 0; linha < linhas; linha++)
            {

                
                for (int i = 0; i < espacosfora; i++)
                {
                    Console.Write(" ");
                }

                if (letra != 'A')
                {
                    Console.Write(letra);
                }

                for (int i = 0; i < espacodentro; i++)
                {
                    Console.Write(" ");
                }

                Console.Write(letra);

                letra--;
                espacosfora++;
                espacodentro -= 2;

                Console.WriteLine();

            }

            Console.ReadLine();

        }
    }
}