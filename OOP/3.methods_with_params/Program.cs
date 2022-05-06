using System;

Calculate calc = new Calculate();

Console.WriteLine(calc.SumWithManual(10,30));
Console.WriteLine(calc.SumWithManual(y:30,x:10));//named
Console.WriteLine(calc.SumDefaultParams(10,30));//default
Console.WriteLine(calc.SumParams(10,20,30,40,50));//default

class  Calculate
{
    public int SumWithManual(int x, int y){
        return x+y;
    }

    public int SumDefaultParams(int x, int y, int z=5){
        return x+y+z;
    }

    public int SumParams(params int[] numbers){
        int result=0;
        foreach (var item in numbers)
        {
            result+=item;
        }
        return result;
    }
}





