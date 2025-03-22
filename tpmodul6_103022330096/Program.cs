// See https://aka.ms/new-console-template for more information
using tpmodul6_103022330096;

class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo stv = new SayaTubeVideo("Tutorial Design By Contract - Raka Valrizqy Akhdansyah");
        stv.IncreasePlayCount(1000);
        stv.PrintVideoDetails();
    }
}
