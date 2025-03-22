// See https://aka.ms/new-console-template for more information
using tpmodul6_103022330096;

class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo stv = new SayaTubeVideo("Tutorial Design By Contract - Raka Valrizqy Akhdansyah");
        stv.IncreasePlayCount(100000); 
        stv.IncreasePlayCount(99999999);
        stv.PrintVideoDetails();
    }
}
