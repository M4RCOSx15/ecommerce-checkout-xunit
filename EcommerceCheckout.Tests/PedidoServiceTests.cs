using EcommerceCheckout.App;

namespace EcommerceCheckout.Tests;

public class PedidoServiceTests
{
    private readonly PedidoService _service = new PedidoService();

    // TODO: Teste 1 — Valide GerarCodigoRastreio com Assert.Equal
    // Dica: chame _service.GerarCodigoRastreio("sudeste", 42)
    // Resultado esperado: "SUDESTE-0042"

    // TODO: Teste 2 — Valide CalcularPontosFidelidade com Assert.Equal
    // Dica: chame _service.CalcularPontosFidelidade(150)
    // Resultado esperado: 30

    // TODO: Teste 3a — Valide TemDireitoAFreteGratis com Assert.True
    // Cenário: cliente VIP com valor 150 (abaixo de R$200)

    // TODO: Teste 3b — Valide TemDireitoAFreteGratis com Assert.False
    // Cenário: cliente não-VIP com valor 150 (abaixo de R$200)
}
