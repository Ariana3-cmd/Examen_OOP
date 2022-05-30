
public class CincoPorciento : ReglaDeCalculo
{
	public decimal Calcular(Compra compra)
	{
		if (compra.Valor > 5000)
			return (compra.Valor) * (5 / 100);
	}
}
