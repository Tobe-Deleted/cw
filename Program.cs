﻿using System.Security.Cryptography;
using System;
namespace Codewars_test;

class Program
{
    static void Main(string[] args)
    {
        SpinningWords  spnwrd = new SpinningWords();
        //clg.SpinWords("Hey fellow warriors");

        Squared issquare = new Squared();
        //issquare.IsSquare(25);   

        Digital_Root dgrt = new Digital_Root();
        //dgrt.DigitalRoot(56798);

        MiddleCharacter mdch = new MiddleCharacter();
        mdch.GetMidChar("testing");
        mdch.GetMidChar("test");

    }
}
