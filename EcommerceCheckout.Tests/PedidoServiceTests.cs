
using EcommerceCheckout.App;

namespace EcommerceCheckout.Tests;

public class PedidoServiceTests
{
    [Fact]
    public void GerarCodigoRastreio()
    {
        Assert.Equal("SP-0001", PedidoService.GerarPedido("sp", 1));

    }

    [Fact]
    public void CalcularPontosFidelidade()
    {
        Assert.Equal(4, PedidoService.CalcularPontosFidelidade(20));

    }

    [Fact]
    public void TemDireitoAFreteGratis()
    {
        Assert.True(PedidoService.TemDireitoAFreteGratis(100, true));
        Assert.False(PedidoService.TemDireitoAFreteGratis(100, false));
    }

}

