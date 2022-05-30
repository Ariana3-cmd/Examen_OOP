// See https://aka.ms/new-console-template for more information}

public class Animal
{
    public string Sonido, Alimento, NombreCientifico;
    
}
public class Canido: Animal
{
    public class Perro: Canido
    {
   public Perro( string S, string A, String NC)
        {
            Sonido= S;
            Alimento= A;
            NombreCientifico= NC;
        }

    }
    public class Lobo : Canido
    {
        public Lobo(string S, string A, String NC)
        {
            Sonido = S;
            Alimento = A;
            NombreCientifico = NC;
        }

    }

}
public class Felino : Animal
{
    public class Gato : Felino
    {
        public Gato(string S, string A, String NC)
        {
            Sonido = S;
            Alimento = A;
            NombreCientifico = NC;
        }

    }
    public class León : Felino
    {
        public León(string S, string A, String NC)
        {
            Sonido = S;
            Alimento = A;
            NombreCientifico = NC;
        }

    }

}

public class Animales
{
    static int Main()
    {
        Canido.Perro Manchas = new Canido.Perro("Ladrido", "Canívora", "Canis");
        Console.WriteLine(Manchas.Sonido + "\t" + Manchas.Alimento + "\t"+ Manchas.NombreCientifico);

        Canido.Lobo Apolo = new Canido.Lobo("Aullido", "Canívora", "Canis Lupus");
        Console.WriteLine(Apolo.Sonido + "\t" + Apolo.Alimento + "\t" + Apolo.NombreCientifico);

        Felino.León Simba = new Felino.León("Rugido", "Carnívoro", " Panthera leo");
        Console.WriteLine(Simba.Sonido + "\t" + Simba.Alimento + "\t" + Simba.NombreCientifico);

        Felino.Gato Peluza = new Felino.Gato("Maullido", "Ratones", "Felis silvestris catus");
        Console.WriteLine(Peluza.Sonido + "\t" + Peluza.Alimento + "\t" + Peluza.NombreCientifico);

        return 0;
    }
}
