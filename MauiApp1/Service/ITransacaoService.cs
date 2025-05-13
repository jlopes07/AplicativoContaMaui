using MauiApp1.Service.MauiApp1.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MauiApp1.Service
{
    public interface ITransacaoService
    {
        Task RegistrarAsync(string descricao, decimal valor, string tipo, string categoria);
        Task<List<Transacao>> ObterTodasAsync();
    }
}
