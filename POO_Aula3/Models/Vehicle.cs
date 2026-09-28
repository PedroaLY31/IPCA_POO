namespace POO_Aula3.Models;

public abstract class Vehicle
{
    public string Brand { get; set; }
    private string Model { get; set; }
    
    //ao criar uma classe abstrata, e obrigatorio implementar o metodo abstrato nas classes filhas, caso contrario, a classe filha tambem deve ser abstrata.
    public abstract void StartEngine();
    
}

//ao tornar a classe abstrata, não é possível instanciar objetos diretamente dela. 
// Em vez disso, você pode criar subclasses que herdam da classe abstrata e implementar os métodos e propriedades necessários nessas subclasses.
