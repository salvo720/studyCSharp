// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;
using System.Xml;

namespace studyCSharp // Note: actual namespace depends on the project name.
{
    internal class _20_ArrayMultidimensionali2d3d
    {
        public static void function_20_ArrayMultidimensionali2d3d()
        {
            //2D Array (matrici ) multidimensionali 

            string[,] codici = new string[3,2]
            {
                {"010" , "011" },
                {"020" , "021" },
                {"030" , "031" },
            };

            Console.WriteLine("codici[0,0] : " + codici[0,0]);

            // foreach con array multidimensionali 2d
            Console.WriteLine("foreach array 2d " );
            foreach (string codice in codici)
            {
                Console.WriteLine("codice : " + codice);
            }

            // for con gli array multidimensioni per avere accesso agli indici (riga e colonna)

            //codici.GetLength() = punta alla dimensione dell'array ( codici = new string[3,2] )
            // codici.GetLength(0) = accede alla prima dimensione dell'array codice che ha lunghezza 3 ;
            // codici.GetLength(1) = accede alla seconda dimensione dell'array codice che ha lunghezza 2 ;
            Console.WriteLine("for array 2d ");
            for (int riga = 0; riga < codici.GetLength(0); riga++)
            {
                for (int colonna = 0; colonna < codici.GetLength(1); colonna++)
                {
                    Console.WriteLine($"sono alla riga : {riga}, e colonna : {colonna}, il valore e : {codici[riga,colonna]}" );

                }
            }

            //array 3d 
            string[,,] array3d = new string[3, 1, 2]
            {
                {
                    {"010","011"},
                },
                {
                    {"020","021"},
                },
                {
                    {"030","031"},
                },
            };

            Console.WriteLine("for array 3d ");

            for (int dim1 = 0; dim1 < array3d.GetLength(0); dim1++)
            {
                for (int dim2 = 0; dim2 < array3d.GetLength(1); dim2++)
                {
                    for (int dim3 = 0; dim3 < array3d.GetLength(2); dim3++)
                    {
            
                        Console.WriteLine($"sono alla dim1 : {dim1}, dim2 : {dim2}, dim3 : {dim3}, il valore e : {array3d[ dim1, dim2 , dim3 ]}");

                    }
                }
            }

            Console.WriteLine("foreach array 3d ");
            foreach (string elemento in array3d)
            {
                Console.WriteLine(" elemento :" + elemento );
            }
        }
    }
}

