
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp1.Service.MauiApp1.Entities;


namespace MauiApp1.Service
{


    public interface ITransacaoRepository
    {
        Task AdicionarAsync(Transacao transacao);
        Task<List<Transacao>> ObterTodasAsync();
    }
}