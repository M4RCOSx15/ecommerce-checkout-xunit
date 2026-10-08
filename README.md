# 🛒 EcommerceCheckout

**Código de rastreio, pontos de fidelidade e frete grátis para uma loja online, com testes unitários em xUnit.**

![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?logo=csharp&logoColor=white)
![xUnit](https://img.shields.io/badge/tests-xUnit-5E2D91)
![Licença](https://img.shields.io/badge/licen%C3%A7a-MIT-blue)

## 📑 Sumário

- [Sobre o projeto](#-sobre-o-projeto)
- [Tecnologias](#-tecnologias)
- [Estrutura da solução](#-estrutura-da-solução)
- [Pré-requisitos](#-pré-requisitos)
- [Como executar](#-como-executar)
- [Métodos implementados](#-métodos-implementados--pedidoservice)
- [Cobertura de testes](#-cobertura-de-testes)
- [Como a solução foi criada](#-como-a-solução-foi-criada)
- [Equipe](#-equipe)
- [Licença](#-licença)

## 📖 Sobre o projeto

Projeto desenvolvido na disciplina **Garantia da Qualidade de Software** (Gestão e Qualidade de Software), sob orientação do professor **Daniel Henrique Matos de Paiva**.

O objetivo é gerenciar o cálculo de cupons, itens e frete de uma loja online, implementando métodos com retornos dos tipos `string`, `int` e `bool` e cobrindo todos com testes unitários em xUnit (`Assert.Equal`, `Assert.True` e `Assert.False`). A solução é criada via terminal, com a .NET CLI.

## 🛠️ Tecnologias

| Tecnologia | Uso |
|---|---|
| [.NET 10](https://dotnet.microsoft.com/) | Plataforma da aplicação e dos testes |
| C# | Linguagem de programação |
| [xUnit](https://xunit.net/) | Framework de testes unitários |
| Git e GitHub | Versionamento e colaboração |

## 📦 Estrutura da solução

```
EcommerceCheckout.slnx
├── EcommerceCheckout.App      -> código de produção (classe PedidoService)
├── EcommerceCheckout.Tests    -> testes unitários (classe PedidoServiceTests)
├── .gitignore                 -> arquivos ignorados pelo Git (padrão .NET)
├── LICENSE                    -> licença MIT
└── README.md                  -> documentação do projeto
```

- **EcommerceCheckout.App**: projeto console (`net10.0`) com as regras de negócio.
- **EcommerceCheckout.Tests**: projeto xUnit (`net10.0`) que referencia o projeto `App` e testa cada método.

## ✅ Pré-requisitos

- [.NET SDK 10](https://dotnet.microsoft.com/download)
- [Git](https://git-scm.com/)

Para conferir a instalação:

```bash
dotnet --version
```

## ▶️ Como executar

```bash
# 1. Clonar o repositório
git clone https://github.com/M4RCOSx15/ecommerce-checkout-xunit.git

# 2. Entrar na pasta
cd ecommerce-checkout-xunit

# 3. Executar os testes
dotnet test
```

## 🔧 Métodos implementados — `PedidoService`

| Método | Retorno | Regra |
|---|---|---|
| `GerarCodigoRastreio(string regiao, int numeroPedido)` | `string` | Região em maiúsculas, hífen e número do pedido preenchido com zeros à esquerda (4 dígitos) |
| `CalcularPontosFidelidade(int valorTotal)` | `int` | A cada R$ 10 em compras, o cliente ganha 2 pontos |
| `TemDireitoAFreteGratis(int valorTotal, bool eClienteVIP)` | `bool` | Frete grátis se o valor total for maior ou igual a R$ 200 **ou** se o cliente for VIP |

### Exemplos de entrada e saída

| Chamada | Resultado | Observação |
|---|---|---|
| `GerarCodigoRastreio("sudeste", 42)` | `"SUDESTE-0042"` | Região em maiúsculas e pedido com 4 dígitos |
| `CalcularPontosFidelidade(150)` | `30` | 150 / 10 = 15 parcelas de R$ 10, e 15 × 2 = 30 |
| `TemDireitoAFreteGratis(150, true)` | `true` | Abaixo de R$ 200, mas cliente VIP |
| `TemDireitoAFreteGratis(150, false)` | `false` | Abaixo de R$ 200 e não é VIP |

## 🧪 Cobertura de testes

Os testes ficam na classe `PedidoServiceTests` e usam o atributo `[Fact]`.

| Método testado | Tipo | Asserção | Cenário |
|---|---|---|---|
| `GerarCodigoRastreio` | `string` | `Assert.Equal` | `("sudeste", 42)` → `"SUDESTE-0042"` |
| `CalcularPontosFidelidade` | `int` | `Assert.Equal` | `150` → `30` |
| `TemDireitoAFreteGratis` | `bool` | `Assert.True` | Compra VIP abaixo de R$ 200 |
| `TemDireitoAFreteGratis` | `bool` | `Assert.False` | Compra não-VIP abaixo de R$ 200 |

## 🧱 Como a solução foi criada

```bash
dotnet new sln -n EcommerceCheckout
dotnet new console -n EcommerceCheckout.App -f net10.0
dotnet new xunit -n EcommerceCheckout.Tests -f net10.0
dotnet sln add EcommerceCheckout.App/EcommerceCheckout.App.csproj
dotnet sln add EcommerceCheckout.Tests/EcommerceCheckout.Tests.csproj
dotnet add EcommerceCheckout.Tests/EcommerceCheckout.Tests.csproj reference EcommerceCheckout.App/EcommerceCheckout.App.csproj
```

## 👥 Equipe

Projeto desenvolvido de forma colaborativa por:

| Nome | GitHub |
|---|---|
| Marcos | [@M4RCOSx15](https://github.com/M4RCOSx15) |
| Michelle | — |
| Vinícius Henrique Diniz Bento | [@Viniciushdb](https://github.com/Viniciushdb) |

### Fluxo de colaboração

O trabalho foi organizado com Git e GitHub: cada melhoria é feita em uma branch própria (por exemplo, `docs/Aprimorar-README`) e integrada à `main` por meio de **Pull Request**, com descrição das alterações e revisão antes do merge.

## 📝 Licença

Este projeto está sob a licença [MIT](LICENSE).