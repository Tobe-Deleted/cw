﻿using System.Security.Cryptography;
using System;
using System.Runtime.InteropServices;
namespace Codewars_test;

class Program
{
    static void Main(string[] args)
    {
        EightKyu kyu8 = new EightKyu();
        //Console.WriteLine(kyu8.Litres(11.8));

        
        SevenKyu kyu7 = new SevenKyu();
        //kyu7.IsIsogram("MoOse");
        //kyu7.GetMidChar("testing");
        //kyu7.IsSquare(25);
        //Console.WriteLine(kyu7.XandO("xmXmoo"));
        //Console.WriteLine(kyu7.ToJadenCase("fiskene svømmer forbi i full faRt"));
        //Console.WriteLine(kyu7.ShortWordLength("dette kan ikke fiskene huske"));
        Console.WriteLine(kyu7.Accumul("abcde"));
        
        SixKyu kyu6 = new SixKyu();
        //Console.WriteLine(kyu6.HowManyOnes(55));
        //kyu6.GetDigitalRoot(56798);
        //kyu6.SpinWords("Hey fellow warriors");
        //Console.WriteLine(kyu6.DuplicateCount("bro bro brille klokken ringer elleve"));

        FiveKyu kyu5 = new FiveKyu();
        /*int[] arr = {1, 0, 2, 0, 1, 0, 1, 0, 3, 1};
        kyu5.MoveZeroes(arr);*/


    }
}
