using System;

namespace MauiApp1.ValueObject
{
    public class Descricao
    {
        public string Valor { get; }

        public Descricao(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
                throw new ArgumentException("Descrição não pode ser vazia ou nula.");

            Valor = valor.Trim();
        }

        public override string ToString() => Valor;

        // Value Object: comparar por valor
        public override bool Equals(object? obj)
        {
            return obj is Descricao other && Valor == other.Valor;
        }

        public override int GetHashCode() => Valor.GetHashCode();
    }
}