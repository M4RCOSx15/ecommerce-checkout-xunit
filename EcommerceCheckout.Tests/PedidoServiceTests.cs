using EcommerceCheckout.App;

namespace EcommerceCheckout.Tests;

public class PedidoServiceTests
{
    private readonly PedidoService _service = new PedidoService();

    [Fact]
public void GerarCodigoRastreio_DeveRetornarCodigoFormatado()
{
    string resultado = _service.GerarCodigoRastreio("sudeste", 42);

    Assert.Equal("SUDESTE-0042", resultado);
}
    [Fact]
public void CalcularPontosFidelidade_DeveRetornar30Pontos()
{
    int resultado = _service.CalcularPontosFidelidade(150);

    Assert.Equal(30, resultado);
}

   [Fact]
public void TemDireitoAFreteGratis_ClienteVip_DeveRetornarTrue()
{
    bool resultado = _service.TemDireitoAFreteGratis(150, true);

    Assert.True(resultado);
}

    [Fact]
public void TemDireitoAFreteGratis_ClienteNaoVip_DeveRetornarFalse()
{
    bool resultado = _service.TemDireitoAFreteGratis(150, false);

    Assert.False(resultado);
  }

}
