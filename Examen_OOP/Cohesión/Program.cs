using System;

Console.WriteLine("***Buscando Cohesión***");

List<Compra> compra = new List<Compra>();
pedidos.Add(new Compra(1,CiudadEnum.Lima,1000));
pedidos.Add(new Compra(2, CiudadEnum.Cusco, 1200));
pedidos.Add(new Compra(3, CiudadEnum.Quito, 5300));
pedidos.Add(new Compra(4, CiudadEnum.LaPaz, 10000));

var calculadoraDePrecio = new CalculadoraDePrecio();

foreach (var compra in compras)
{
    switch (compra.CategoriaEnum)
    {
        case CiudadEnum.Lima:
            calculadoraDePrecio.DefinirRegla(new TresPorciento());
            break;
        case CiudadEnum.Cusco:
            calculadoraDePrecio.DefinirRegla(new TresPorciento());
            break;
        case CiudadEnum.Quito:
            calculadoraDePrecio.DefinirRegla(new CincoPorciento());
            break;
        case CiudadEnum.LaPaz:
            calculadoraDePrecio.DefinirRegla(new CincoPorciento());
            break;
        case CiudadEnum.BuenosAires:
            break;
        case CiudadEnum.RioDeJaneiro:
            break;
        case CiudadEnum.SaoPaulo:
            break;
        case CiudadEnum.Santiago:
            break;
        case CiudadEnum.MonteVideo:
            break;
        default:
            break;
    }

    var valorConDescuento = calculadoraDePrecio.Calcular(compra);
    Console.WriteLine($"Compra: {compra.Id}, Categoria: {compra.CiudadEnum},Valor Con Descuento: {valorConDescuento}");
}
