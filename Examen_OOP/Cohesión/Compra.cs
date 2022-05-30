
public class Compra
{
    public int Id { get; private set; }
    public CiudadEnum CiudadEnum { get; private set; }
    public int Valor { get; private set; }

    public Compra(int id, CiudadEnum ciudadEnum, int valor)
    {
        Id = id;
        CiudadEnum = ciudadEnum;
        Valor = valor;
    }
}
