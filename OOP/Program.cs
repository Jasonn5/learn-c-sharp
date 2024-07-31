//public class Persona {
//    public string Nombre { get; set; }
//    public int Edad { get; set; }

//    public void Saludar() { 
//        Console.WriteLine("Hola mi nombre es: " +  Nombre + " y tengo " + Edad);
//    }
//}

//public class Empleado : Persona
//{
//    public string Puesto { get; set;}

//    public void MostrarCargo() { 
//        Console.WriteLine("Mi puesto es: " + Puesto);
//    }
//}

//public class Program {
//    static void Main(string[] args) {
//       Empleado empleado = new Empleado();
//        empleado.Nombre = "Diego";
//        empleado.Edad = 5;
//        empleado.Puesto = "Recepcionista";
//        empleado.MostrarCargo();
//        empleado.Saludar();
//    }
//}

//public class Cuenta {
//    private decimal saldo;
//    public  decimal gastos {  get; set; }
//    public decimal ingresos { get; set; }
//    public decimal Saldo { 
//        get { return saldo+ ingresos-gastos; }
//        set { if (value > 0) saldo = value; }
//    }
//}

//public class Program
//{
//    static void Main(string[] args)
//    {
//        Cuenta cuenta = new Cuenta();
//        cuenta.Saldo = 100;
//        cuenta.ingresos = 2000;
//        cuenta.gastos = 500;
//        Console.WriteLine("Saldo actual:" + cuenta.Saldo);
//    }
//}


//public abstract class Animal { 
//    public abstract void getAge();
//}


//public class Perro : Animal
//{
//    public override void getAge()
//    {
//        Console.WriteLine(12);
//    }
//}

//public class Program
//{
//    static void Main(string[] args)
//    {
//        Perro perro = new Perro();
//        perro.getAge();
//    }
//}


public interface ICar {
    public void Conducir();
}
public interface IDriver
{
    public void Conducir();
}
public class Coche : ICar , IDriver
{
    public void Conducir()
    {
        Console.WriteLine("Giro derecha");
    }
}


public class Program
{
    static void Main(string[] args)
    {
        Coche coche = new Coche();
        coche.Conducir();
    }
}