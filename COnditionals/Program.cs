public class Program { 
    public static void Main(string[] args)
    {
        int initial = 0;
        bool response = true;
       while (response)
        {
            Console.WriteLine("añada un numero");
            int num = int.Parse(Console.ReadLine());
            int partialResult = num + initial;
            initial = partialResult;
            Console.WriteLine("la suma es: " + partialResult);
            Console.WriteLine("Desea seguir sumando");
            bool res=bool.Parse(Console.ReadLine());
            if (!res) { 
                response = false;
                Console.WriteLine("La suma total es: " + partialResult);
            }
        }
    }
}