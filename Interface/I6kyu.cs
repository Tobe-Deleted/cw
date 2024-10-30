public interface I6kyu
{
    /// <summary>
    /// Counts bits with a value of 1. See CountingBits.cs
    /// https://www.codewars.com/kata/526571aae218b8ee490006f4
    /// </summary>
    /// <param name="n"></param>
    /// <returns>number of 1's in the binary translateion of integer n</returns>
    public int HowManyOnes (int n);

    /// <summary>
    /// Prints digital root of n
    /// https://www.codewars.com/kata/541c8630095125aba6000c00
    /// </summary>
    /// <param name="n"></param>
    public void GetDigitalRoot(long n);

    /// <summary>
    /// reverses each word that are >= 5 characters long in sentence.
    /// https://www.codewars.com/kata/5264d2b162488dc400000001
    /// </summary>
    /// <param name="sentence"></param>
    public void SpinWords(string sentence);

    /// <summary>
    /// counts how many distinct characters have duplicates
    /// https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1
    /// </summary>
    /// <param name="str"></param>
    /// <returns> integer result</returns>
    public int DuplicateCount(string str);

/// <summary>
/// Encodes a string turning characters only occuring once into ( 
/// and characters with multiple occurances into )
/// https://www.codewars.com/kata/54b42f9314d9229fd6000d9c
/// </summary>
/// <param name="word"></param>
/// <returns>string with word encoded</returns>
    public string DuplicateEncoder(string word);

/// <summary>
/// Takes in an int array and returns the first number that doesn't fit
/// https://www.codewars.com/kata/5526fc09a1bbd946250002dc
/// </summary>
/// <param name="arr"></param>
/// <returns>int = first odd/even number</returns>
    public int ParityOutlier(int[] arr);

/// <summary>
/// Will take in string and replace all letters with their corresponding number in the alphabet
/// https://www.codewars.com/kata/546f922b54af40e1e90001da
/// </summary>
/// <param name="text"></param>
/// <returns></returns>
    public string ReplaceWithAlphabetPosition(string text);

/// <summary>
/// Checking if a walk will take 10 minutes and return you to the starting point
/// https://www.codewars.com/kata/54da539698b8a2ad76000228
/// </summary>
/// <returns>false || true</returns>
    public bool ValidWalk(string[] walk);

/// <summary>
/// Takes in a number and multiplies each digit with each other until it is left with only  1 digit
/// https://www.codewars.com/kata/55bf01e5a717a0d57e0000ec
/// </summary>
/// <param name="n"></param>
/// <returns>int number of processes needed to reach 1 digit</returns>
    public int Persistence(long n);

/// <summary>
/// Takes in string where words are seperated by _ or - and converts it to camel case
/// If first letter is capital during input, it converts sentence to Pascal case
/// https://www.codewars.com/kata/517abf86da9663f1d2000003
/// </summary>
/// <param name="str"></param>
/// <returns>One word string where each word which is either camel case or pascal case</returns>
    public string CamelCase(string str);

/// <summary>
/// takes in any argument and removes all repeating elements next to each other. Prints out result.
/// https://www.codewars.com/kata/54e6533c92449cc251001667
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="iterable"></param>
    public void UniqueInOrder<T>(IEnumerable<T> iterable);
}
