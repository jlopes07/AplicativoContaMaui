using MauiApp1.Enums;
using MauiApp1.Service;
using MauiApp1.Service.MauiApp1.Entities;
using Moq;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public async Task RegistrarAsync_DeveAdicionarTransacao()
        {
            // Arrange
            var repoMock = new Mock<ITransacaoRepository>();
            var service = new TransacaoService(repoMock.Object);

            // Act
            await service.RegistrarAsync("Salário", 2500, "Entrada", "Salário");

            // Assert
            repoMock.Verify(x => x.AdicionarAsync(It.Is<Transacao>(t =>
                t.Descricao.ToString() == "Salário" &&
                t.Valor == 2500 &&
                t.Tipo == TipoTransacao.Entrada &&
                t.Categoria == "Salário"
            )), Times.Once);
        }

        [Fact]
        public async Task RegistrarAsync_TipoInvalido_DeveLancarExcecao()
        {
            // Arrange
            var repoMock = new Mock<ITransacaoRepository>();
            var service = new TransacaoService(repoMock.Object);

            // Act & Assert
            await Assert.ThrowsAsync<ArgumentException>(() =>
                service.RegistrarAsync("Teste", 100, "Invalido", "Outro")
            );
        }
    }
}
