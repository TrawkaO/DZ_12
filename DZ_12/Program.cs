namespace DZ_12
{
    internal class Program
    {
     
        
      
        static void Main(string[] args)
        {
            var opManager = new OperaManager(20, 10);
            var result = opManager.Exe(Opera.Sun);
            Console.WriteLine($"The result of the operation is {result}");
            Console.ReadKey();

        }
    }
}