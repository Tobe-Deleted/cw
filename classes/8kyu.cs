using System;
public class EightKyu : I8kyu
{
    public int Litres(double time)
    {
        time = Math.Floor(time/2);
        int result = Convert.ToInt32(time);
        return result;
        //a better solution:
        //return (int)(time/2);
    }
}