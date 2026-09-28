namespace POO_Aula3.Models;

public class Moto : Vehicle
{

    //ATRIBUTOS   
    public int NumberWheels { get; set; }

    //CONSTRUTOR
    public Moto(string brand, string model, int numberWheels)
    {
        Brand = brand;
        Model = model;
        NumberWheels = numberWheels;

    }

    //NETODOS
    public void StartEngine()
    {
        Console.WriteLine($"The Moto {Brand} {Model} is now running.");
        
    }
        
}