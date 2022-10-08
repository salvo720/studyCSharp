// See https://aka.ms/new-console-template for more information

using System;

namespace studyCSharp // Note: actual namespace depends on the project name.
{
    internal class _01_02_Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_01_02_Program : ");
            Console.WriteLine("Hello World!");
            //// Console.Read(); ci consente di mantenere  il programma in esecuzione perche aspetta un input dell'utente 
            //Console.Read();

            Console.WriteLine("");
            Console.WriteLine("_03_VariabiliECostanti : ");
            _03_VariabiliECostanti.function_03_VariabiliECostanti();

            Console.WriteLine("");
            Console.WriteLine("_04_TipiDiDati : ");
            _04_TipiDiDati.function_04_TipiDiDati();

            Console.WriteLine("");
            Console.WriteLine("_05_CastingImplicitoEdEsplicito : ");
            _05_CastingImplicitoEdEsplicito.function_05_CastingImplicitoEdEsplicito();

            Console.WriteLine("");
            Console.WriteLine("_06_LavorareConStringhe : ");
            _06_LavorareConStringhe.function_06_LavorareConStringhe();


            Console.WriteLine("");
            Console.WriteLine("_07_LavorareConINumeri : ");
            _07_LavorareConINumeri.function_07_LavorareConINumeri();

            //disattivato perche richiede imput 
            //Console.WriteLine("");
            //Console.WriteLine("_08_InputUtente : ");
            //_08_InputUtente.function_08_InputUtente();

            //disattivato perche richiede imput 
            //Console.WriteLine("");
            //Console.WriteLine("_09_OperatoriLogiciEDiComparazione : ");
            //_09_OperatoriLogiciEDiComparazione.function_09_OperatoriLogiciEDiComparazione();

            Console.WriteLine("");
            Console.WriteLine("_10_OperatoriLogiciEDiComparazione : ");
            _10_OperatoriLogiciEDiComparazione.function_10_OperatoriLogiciEDiComparazione();

            //disattivato perche richiede imput 
            //Console.WriteLine("");
            //Console.WriteLine("_11_IfElse : ");
            //_11_IfElse.function_11_IfElse();

            Console.WriteLine("");
            Console.WriteLine("_12_OperatoreTernario : ");
            _12_OperatoreTernario.function_12_OperatoreTernario();

            Console.WriteLine("");
            Console.WriteLine("_13_CostruttoSwitchCase : ");
           _13_CostruttoSwitchCase.function_13_CostruttoSwitchCase();

            Console.WriteLine("");
            Console.WriteLine("_14_CicloWhileEDoWhile : ");
            _14_CicloWhileEDoWhile.function_14_CicloWhileEDoWhile();

            Console.WriteLine("");
            Console.WriteLine("_15_CicloForEForeach : ");
            _15_CicloForEForeach.function_15_CicloForEForeach();

            Console.WriteLine("");
            Console.WriteLine("_16_BreakEContinueNeiCicli : ");
            _16_BreakEContinueNeiCicli.function_16_BreakEContinueNeiCicli();

            Console.WriteLine("");
            Console.WriteLine("_17_SovracccaricoDeiMetodiMethodOverloading : ");
            _17_CosaSonoIMetodiParametriEReturn.function_17_CosaSonoIMetodiParametriEReturn();

            Console.WriteLine("");
            Console.WriteLine("_18_SovracccaricoDeiMetodiMethodOverloading : ");
            _18_SovracccaricoDeiMetodiMethodOverloading.function_18_SovracccaricoDeiMetodiMethodOverloading();

            Console.WriteLine("");
            Console.WriteLine("_19_ArraySpiegati : ");
            _19_ArraySpiegati.function_19_ArraySpiegati();

            Console.WriteLine("");
            Console.WriteLine("_20_ArrayMultidimensionali2d3d : ");
            _20_ArrayMultidimensionali2d3d.function_20_ArrayMultidimensionali2d3d();

            Console.WriteLine("");
            Console.WriteLine("_21_ArrayIrregolariJagged : ");
            _21_ArrayIrregolariJagged.function_21_ArrayIrregolariJagged();

            Console.WriteLine("");
            Console.WriteLine("_22_LeArraylist : ");
            _22_LeArraylist.function_22_LeArraylist();

            Console.WriteLine("");
            Console.WriteLine("_23_LeList : ");
            _23_LeList.function_23_LeList();





        }
    }
}


// le funzione locali non possono includere modificatori di classe come public o protecded

// i namespace sono come i package di java , quindi i namespace raggruno del codice andando a dare una struttura al nostro progetto

// c# e un linguaggio orientato agli oggetti 

// Main e il nostro entry point o metodo che viene eseguito quando inizia il programma 

// visual studio usa il colore verde per indicare che stiamo usando qualcosa di una classe in guarda l'esempio  Console.WriteLine("Hello World!");

// c# e un linguaggio fortemente tipizzato , quindi bisogna sempre specificare il tipo della variabile 

// su c# i ; sono obbligatori 