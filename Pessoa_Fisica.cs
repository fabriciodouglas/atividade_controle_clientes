namespace Atividade
{
    // Herança: Pessoa_Fisica herda de Clientes (imposto de 10%, vindo da classe-pai)
    class Pessoa_Fisica : Clientes
    {
        public string cpf { get; set; }
        public string rg { get; set; }
    }
}
