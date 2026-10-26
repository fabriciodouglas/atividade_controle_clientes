# Sistema de Controle de Clientes (C# / POO)

Atividade de **Codificação Back-End – SENAI**. Aplicação de console em C# baseada em um diagrama de classes.

## Estrutura
| Arquivo | Descrição |
|---|---|
| `Clientes.cs` | Classe-pai. Imposto de 10% (`Pagar_Imposto` é `virtual`). |
| `Pessoa_Fisica.cs` | Herda de `Clientes`. Atributos `cpf` e `rg`. |
| `Pessoa_Juridica.cs` | Herda de `Clientes`. Atributos `cnpj` e `ie`. Faz `override` de `Pagar_Imposto` (20%). |
| `Program.cs` | Entrada de dados via console, define o tipo de cliente e exibe os resultados. |

## Conceitos de POO aplicados
- **Abstração:** modelagem do cliente do mundo real em classes.
- **Herança:** `Pessoa_Fisica` e `Pessoa_Juridica` derivam de `Clientes`.
- **Polimorfismo:** `override` de `Pagar_Imposto` em `Pessoa_Juridica`.
- **Encapsulamento:** `valor`, `valor_imposto` e `total` usam `protected set`.

## Como executar
Requisitos: [.NET SDK](https://dotnet.microsoft.com/download) 8.0 ou superior.

```bash
cd Atividade
dotnet run
```

## Exemplo
```
Pessoa Física (f) ou Jurídica (j) ?
f
...
Valor de Compra: R$ 2.500,00
Imposto .......: R$ 250,00
Total a Pagar : R$ 2.750,00
```
Pessoa jurídica com R$ 35.000,00 → imposto R$ 7.000,00 → total R$ 42.000,00.
