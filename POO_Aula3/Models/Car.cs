namespace POO_Aula3.Models;

public class Car : Vehicle
{

    //ATRIBUTOS   
    public int NumberDoors { get; set; }

    //CONSTRUTOR
    public Car(string brand, string model, int numberDoors)
    {
        Brand = brand;
        Model = model;
        NumberDoors = numberDoors;

    }

    //METODOS
    
        
}


