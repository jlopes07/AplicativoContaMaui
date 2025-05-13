using MauiApp1.Enums;
using MauiApp1.ValueObject;

namespace MauiApp1.Service.MauiApp1.Entities
{
    public class Transacao
    {
        public Guid Id { get; private set; }
        public Descricao Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public TipoTransacao Tipo { get; private set; }
        public DateTime Data { get; private set; }
        public string Categoria { get; private set; }

        public Transacao(Descricao descricao, decimal valor, TipoTransacao tipo, string categoria)
        {
            Id = Guid.NewGuid();
            Descricao = descricao;
            Valor = valor;
            Tipo = tipo;
            Categoria = categoria;
            Data = DateTime.Now;
        }
    }
}
