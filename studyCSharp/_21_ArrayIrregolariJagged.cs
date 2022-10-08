// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;
using System.Xml;

namespace studyCSharp // Note: actual namespace depends on the project name.
{
    internal class _21_ArrayIrregolariJagged
    {
        public static void function_21_ArrayIrregolariJagged()
        {
            //Array Irregolari : sono array che contegono altri array di dimensione variabile o irregolare 
            // gli array irregolri sono array di array 

            // sintassi lunga 
            int[][] arrayIrregolare = new int[4][];
            arrayIrregolare[0] = new int[] { 10, 20 };
            arrayIrregolare[1] = new int[] { 100 };
            arrayIrregolare[2] = new int[] { 17, 45 , 65 };
            arrayIrregolare[3] = new int[] { 30, 52 , 78 , 84 ,21 ,20,98  };

            // sintassi shortend
            int[][] arrayIrregolare2 = 
            { 
                new int[] { 10 ,20 },
                new int[] { 100 },
                new int[] { 17, 45, 65 },
                new int[] { 30, 52, 78, 84, 21, 20, 98 },
            };
            // edit di un valore da un array irregolare 
            arrayIrregolare2[3][1] = 1;
            Console.WriteLine(" arrayIrregolare2[3][1] : " + arrayIrregolare2[3][1]);


            for (int riga = 0; riga < arrayIrregolare2.Length; riga++)
            {
                for (int colonna = 0; colonna < arrayIrregolare2[riga].Length; colonna++)
                {
                    Console.WriteLine($" arrayIrregolare2 riga : {riga} , colonna {colonna} , valore : {arrayIrregolare2[riga][colonna]} ");
                }
            }

            // uno irregolare con dentro un array multidimensione e impossibile su c#
            //int[][] arrayIrregolare3 = new int[3][];
            //arrayIrregolare3[0] =  new int[] { 10, 20 };
            //arrayIrregolare3[1] = new int[3, 1, 3]
            //    {
            //        {
            //            { 10,20,21}
            //        },
            //        {
            //            {11,24,56 }
            //        },
            //        {
            //            { 22,76,21}
            //        },
            //    };
            // arrayIrregolare3[2] = new int[] { 10, 20 };





        }
    }
}

