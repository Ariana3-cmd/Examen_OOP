
class CalculadoraDePrecio
{
    private ReglaDeCalculo _reglaDeCalculo;

    public CalculadoraDePrecio()
    {

    }

    public void DefinirRegla(ReglaDeCalculo reglaDeCalculo)
    {
        _reglaDeCalculo = reglaDeCalculo;
    }

    public decimal Calcular(Compra compra)
    {
        return _reglaDeCalculo.Calcular(compra;
    }
}