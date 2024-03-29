﻿// See https://aka.ms/new-console-template for more information

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

            Console.WriteLine("");
            Console.WriteLine("_24_LeHashtable : ");
            _24_LeHashtable.function_24_LeHashtable();

            Console.WriteLine("");
            Console.WriteLine("_25_LeDictionary : ");
            _25_LeDictionary.function_25_LeDictionary();

            Console.WriteLine("");
            Console.WriteLine("_26_LeStack : ");
            _26_LeStack.function_26_LeStack();

            Console.WriteLine("");
            Console.WriteLine("_27_LeQueue : ");
            _27_LeQueue.function_27_LeQueue();

            Console.WriteLine("");
            Console.WriteLine("_28_ProgrammazioneAdOggettiOOP : ");
            _28_ProgrammazioneAdOggettiOOP.function_28_ProgrammazioneAdOggettiOOP();

            Console.WriteLine("");
            Console.WriteLine("_29_CostruttoreDellaClasse : ");
            _29_CostruttoreDellaClasse.function_29_CostruttoreDellaClasse();

            Console.WriteLine("");
            Console.WriteLine("_30_GettersESetters : ");
            _30_GettersESetters.function_30_GettersESetters();

            Console.WriteLine("");
            Console.WriteLine("_31_ParolaChiaveStatic : ");
            _31_ParolaChiaveStatic.function_31_ParolaChiaveStatic();


            Console.WriteLine("");
            Console.WriteLine("_32_Ereditarieta : ");
            _32_Ereditarieta.function_32_Ereditarieta();

            Console.WriteLine("");
            Console.WriteLine("_33_ParoleVirtualOverrideSealed : ");
            _33_ParoleVirtualOverrideSealed.function_33_ParoleVirtualOverrideSealed();

            Console.WriteLine("");
            Console.WriteLine("_34_LeInterfacce : ");
            _34_LeInterfacce.function_34_LeInterfacce();

            Console.WriteLine("");
            Console.WriteLine("_35_IlPolimorfismo : ");
            _35_IlPolimorfismo.function_35_IlPolimorfismo();

            Console.WriteLine("");
            Console.WriteLine("_36_ClassiAstratte : ");
            _36_ClassiAstratte.function_36_ClassiAstratte();

            Console.WriteLine("");
            Console.WriteLine("_37_ModificatoriDiAccesso : ");
            _37_ModificatoriDiAccesso.function_37_ModificatoriDiAccesso();

            Console.WriteLine("");
            Console.WriteLine("_38_GliEnumeratori : ");
            _38_GliEnumeratori.function_38_GliEnumeratori();

            Console.WriteLine("");
            Console.WriteLine("_39_LavorareConLeDate : ");
            _39_LavorareConLeDate.function_39_LavorareConLeDate();


            Console.WriteLine("");
            Console.WriteLine("_40_Nullable : ");
            _40_Nullable.function_40_Nullable();



        }
    }
}


// le funzione locali non possono includere modificatori di classe come public o protecded

// i namespace sono come i package di java , quindi i namespace raggrupano del codice andando a dare una struttura al nostro progetto

// c# e un linguaggio orientato agli oggetti 

// Main e il nostro entry point o metodo che viene eseguito quando inizia il programma 

// visual studio usa il colore verde per indicare che stiamo usando qualcosa di una classe in guarda l'esempio  Console.WriteLine("Hello World!");

// c# e un linguaggio fortemente tipizzato , quindi bisogna sempre specificare il tipo della variabile 

// su c# i ; sono obbligatori 