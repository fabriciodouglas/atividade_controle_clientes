using System;
using System.Globalization;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cultura pt-BR: aceita "2500,00" na entrada e exibe R$ 2.500,00 na saída
            CultureInfo cultura = new CultureInfo("pt-BR");
            CultureInfo.CurrentCulture = cultura;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            float val_pag;

            Console.WriteLine("Informar Nome");
            string var_nome = Console.ReadLine();

            Console.WriteLine("Informar Endereço");
            string var_endereco = Console.ReadLine();

            Console.WriteLine("Pessoa Física (f) ou Jurídica (j) ?");
            string var_tipo = Console.ReadLine().Trim().ToLower();

            if (var_tipo == "f")
            {
                // --- Pessoa Física ----
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;

                Console.WriteLine("Informar CPF:");
                pf.cpf = Console.ReadLine();

                Console.WriteLine("Informar RG:");
                pf.rg = Console.ReadLine();

                val_pag = LerValor();
                pf.Pagar_Imposto(val_pag);

                Console.WriteLine("-------- Pessoa Física ---------");
                Console.WriteLine("Nome ..........: " + pf.nome);
                Console.WriteLine("Endereço ......: " + pf.endereco);
                Console.WriteLine("CPF ...........: " + pf.cpf);
                Console.WriteLine("RG ............: " + pf.rg);
                Console.WriteLine("Valor de Compra: " + pf.valor.ToString("C"));
                Console.WriteLine("Imposto .......: " + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar : " + pf.total.ToString("C"));
            }
            else if (var_tipo == "j")
            {
                // --- Pessoa Jurídica ---
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;

                Console.WriteLine("Informar CNPJ:");
                pj.cnpj = Console.ReadLine();

                Console.WriteLine("Informar IE:");
                pj.ie = Console.ReadLine();

                val_pag = LerValor();
                pj.Pagar_Imposto(val_pag);

                Console.WriteLine("-------- Pessoa Jurídica ---------");
                Console.WriteLine("Nome ..........: " + pj.nome);
                Console.WriteLine("Endereço ......: " + pj.endereco);
                Console.WriteLine("CNPJ ..........: " + pj.cnpj);
                Console.WriteLine("IE ............: " + pj.ie);
                Console.WriteLine("Valor de Compra: " + pj.valor.ToString("C"));
                Console.WriteLine("Imposto .......: " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar : " + pj.total.ToString("C"));
            }
            else
            {
                Console.WriteLine("Opção inválida. Execute novamente e informe 'f' ou 'j'.");
            }
        }

        // Lê o valor da compra e repete até o usuário digitar um número válido
        static float LerValor()
        {
            float valor;
            Console.WriteLine("Informar Valor de Compra:");
            while (!float.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.CurrentCulture, out valor) || valor < 0)
            {
                Console.WriteLine("Valor inválido. Informe um número (ex.: 2500,00):");
            }
            return valor;
        }
    }
}
