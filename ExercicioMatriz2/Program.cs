using System;

namespace ExercicioMatriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com a quantidade de linha: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Entre com a quantidade de colunas: ");
            int y = int.Parse(Console.ReadLine());

            //instanciando matriz bidimencional passando número de linhas e colunas
            int[,] mat = new int[x, y];

            for(int i = 0; i < x; i++)
            {
                string[] valor = Console.ReadLine().Split(" "); //vetor para guardar informação da matriz e usar split

                for(int j = 0; j < y; j++)
                {
                    mat[i, j] = int.Parse(valor[j]);
                }
            }

            Console.Write("Entre com o valor para pesquisar na matriz: ");
            int k = int.Parse(Console.ReadLine());
            
            int left;
            int right;
            int up;
            int down;
           
            for(int i = 0; i < x; i++)
            {
                for(int j = 0; j < y; j++)
                  {
                     if(mat[i, j] == k)
                    {                       

                        Console.WriteLine("Posição: " + i + "," + j);

                        //coluna a esquerda - left
                        left = j - 1;
                        //coluna a diretira - right
                        right = j + 1;
                        //linha acima - up
                        up = i - 1;
                        //linha abaixo
                        down = i + 1;

                        //validando se elemento ao redor da posição está dentro do range da matriz
                        //getlength(0)/(1) pega a qtd de linhas e colunas respectivamente
                        if (left >= 0 && left <= mat.GetLength(0) && left <= mat.GetLength(1))
                        {                            
                            Console.WriteLine("Left: " + mat[i, left]);
                        }
                        
                        if(right >= 0 && right <= mat.GetLength(0) && right <= mat.GetLength(1))
                        {
                             Console.WriteLine("Right: " + mat[i, right]);   
                        }
                        
                        if(up >= 0 && up <= mat.GetLength(0) && up <= mat.GetLength(1))
                        {
                            Console.WriteLine("Up: " + mat[up, j]);
                        }     
                        
                        if(down >= 0 && down <= mat.GetLength(0) && down <= mat.GetLength(1))
                        {
                            Console.WriteLine("Down: " + mat[down, j]);
                        }
                        
                    }
                    
                }
                
            }
        }
    }
}
