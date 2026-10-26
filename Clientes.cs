namespace Atividade
{
    // Classe-pai (abstração do cliente do mundo real)
    class Clientes
    {
        public string nome { get; set; }
        public string endereco { get; set; }

        // Encapsulamento: valores só podem ser alterados pela própria classe e suas derivadas
        public float valor { get; protected set; }
        public float valor_imposto { get; protected set; }
        public float total { get; protected set; }

        // virtual: permite que as classes derivadas reescrevam (override) o método
        public virtual void Pagar_Imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 10 / 100;
            this.total = this.valor + this.valor_imposto;
        }
    }
}
