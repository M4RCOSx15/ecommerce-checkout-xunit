namespace EcommerceCheckout.App;

/// <summary>
/// Serviço responsável pelas regras de negócio do checkout de pedidos.
/// </summary>
public class PedidoService
{
    /// <summary>
    /// Gera um código de rastreio formatado a partir da região e do número do pedido.
    /// </summary>
    /// <param name="regiao">Nome da região (ex: "sudeste").</param>
    /// <param name="numeroPedido">Número do pedido.</param>
    /// <returns>Código no formato "REGIAO-XXXX" (4 dígitos com zeros à esquerda).</returns>
    /// <example>GerarCodigoRastreio("sudeste", 42) → "SUDESTE-0042"</example>
    public string GerarCodigoRastreio(string regiao, int numeroPedido)
    {
        return $"{regiao.ToUpper()}-{numeroPedido:D4}";
    }

    /// <summary>
    /// Calcula os pontos de fidelidade com base no valor total da compra.
    /// A cada R$ 10, o cliente ganha 2 pontos.
    /// </summary>
    /// <param name="valorTotal">Valor total da compra em reais.</param>
    /// <returns>Total de pontos de fidelidade acumulados.</returns>
    /// <example>CalcularPontosFidelidade(150) → 30</example>
    public int CalcularPontosFidelidade(int valorTotal)
    {
        return (valorTotal / 10) * 2;
    }

    /// <summary>
    /// Verifica se o cliente tem direito a frete grátis.
    /// O frete é grátis se o valor total for >= R$ 200 OU se o cliente for VIP.
    /// </summary>
    /// <param name="valorTotal">Valor total da compra em reais.</param>
    /// <param name="eClienteVIP">Indica se o cliente é VIP.</param>
    /// <returns>True se o frete for grátis; False caso contrário.</returns>
    /// <example>
    /// TemDireitoAFreteGratis(150, true)  → true  (cliente VIP)
    /// TemDireitoAFreteGratis(150, false) → false (não VIP e abaixo de R$200)
    /// TemDireitoAFreteGratis(200, false) → true  (valor >= R$200)
    /// </example>
    public bool TemDireitoAFreteGratis(int valorTotal, bool eClienteVIP)
    {
        return valorTotal >= 200 || eClienteVIP;
    }
}
