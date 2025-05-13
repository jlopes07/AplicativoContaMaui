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
            await service.RegistrarAsync("Sal�rio", 2500, "Entrada", "Sal�rio");

            // Assert
            repoMock.Verify(x => x.AdicionarAsync(It.Is<Transacao>(t =>
                t.Descricao.ToString() == "Sal�rio" &&
                t.Valor == 2500 &&
                t.Tipo == TipoTransacao.Entrada &&
                t.Categoria == "Sal�rio"
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
