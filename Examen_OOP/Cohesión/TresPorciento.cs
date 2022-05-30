

public class TresPorciento : ReglaDeCalculo
{
	public decimal Calcular(Compra compra)
	{
		if(compra.Valor > 1000)
			return (compra.Valor) * (3 / 100);
		}
}
