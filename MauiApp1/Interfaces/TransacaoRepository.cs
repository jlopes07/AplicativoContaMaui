using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp1.Service.MauiApp1.Entities;

namespace MauiApp1.Service
{
    public class TransacaoRepository : ITransacaoRepository
    {
        private readonly List<Transacao> _transacoes = new();

        public Task AdicionarAsync(Transacao transacao)
        {
            _transacoes.Add(transacao);
            return Task.CompletedTask;
        }

        public Task<List<Transacao>> ObterTodasAsync()
        {
            return Task.FromResult(_transacoes.ToList());
        }
    }
}