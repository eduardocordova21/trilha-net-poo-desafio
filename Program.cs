using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Smartphone Nokia");
        Smartphone nokia = new Nokia(numero: "1234", modelo: "Tijolão", imei: "11111", memoria: 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("Signal");

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone Iphone");
        Smartphone iphone = new Iphone(numero: "5678", modelo: "MAX", imei: "22222", memoria: 256);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Senhas");
    }
}