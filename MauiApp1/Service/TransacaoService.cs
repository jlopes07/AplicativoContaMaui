using MauiApp1.Enums;
using MauiApp1.Service.MauiApp1.Entities;
using MauiApp1.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MauiApp1.Service
{
    public class TransacaoService : ITransacaoService
    {
        private readonly ITransacaoRepository _repository;

        public TransacaoService(ITransacaoRepository repository)
        {
            _repository = repository;
        }

        public async Task RegistrarAsync(string descricao, decimal valor, string tipo, string categoria)
        {
            if (!Enum.TryParse<TipoTransacao>(tipo, out var tipoEnum))
                throw new ArgumentException("Tipo de transação inválido");

            var transacoes = await _repository.ObterTodasAsync();

            var saldoAtual = transacoes.Sum(t =>
                t.Tipo == TipoTransacao.Entrada ? t.Valor :
                t.Tipo == TipoTransacao.Saida ? -t.Valor : 0);

            if (tipoEnum == TipoTransacao.Saida && saldoAtual - valor < -250)
                throw new InvalidOperationException("Saldo insuficiente. Limite de -R$250,00 atingido.");

            var transacao = new Transacao(new Descricao(descricao), valor, tipoEnum, categoria);
            await _repository.AdicionarAsync(transacao);
        }

        public Task<List<Transacao>> ObterTodasAsync()
        {
            return _repository.ObterTodasAsync();
        }
    }
}
