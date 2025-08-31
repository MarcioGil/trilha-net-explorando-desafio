# DIO - Trilha .NET - Explorando a linguagem C#
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de explorando a linguagem C#, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema de hospedagem, que será usado para realizar uma reserva em um hotel. Você precisará usar a classe Pessoa, que representa o hóspede, a classe Suíte, e a classe Reserva, que fará um relacionamento entre ambos.

O seu programa deverá calcular corretamente os valores dos métodos da classe Reserva, que precisará trazer a quantidade de hóspedes e o valor da diária, concedendo um desconto de 10% para caso a reserva seja para um período maior que 10 dias.

## Regras e validações
1. Não deve ser possível realizar uma reserva de uma suíte com capacidade menor do que a quantidade de hóspedes. Exemplo: Se é uma suíte capaz de hospedar 2 pessoas, então ao passar 3 hóspedes deverá retornar uma exception.
2. O método ObterQuantidadeHospedes da classe Reserva deverá retornar a quantidade total de hóspedes, enquanto que o método CalcularValorDiaria deverá retornar o valor da diária (Dias reservados x valor da diária).
3. Caso seja feita uma reserva igual ou maior que 10 dias, deverá ser concedido um desconto de 10% no valor da diária.

![Diagrama de classe hotel](diagrama_classe_hotel.png)

## Solução
O código inicial do projeto estava incompleto e continha marcações `TODO` a serem implementadas.  
As principais implementações realizadas foram:

- **Classe Reserva**
  - Implementação da validação de capacidade da suíte em relação ao número de hóspedes.
  - Implementação do método `ObterQuantidadeHospedes()`, que retorna a quantidade de hóspedes cadastrados.
  - Implementação do método `CalcularValorDiaria()`, com regra de desconto de 10% para reservas de 10 dias ou mais.
  - Tratamento de exceções para cenários inválidos (ex.: cadastrar hóspedes sem suite definida).

- **Program.cs**
  - Exibição dos resultados no console.
  - Melhoria na saída formatando o valor da diária como moeda (`:C`).

- **Projeto**
  - Atualização do projeto para rodar em **.NET 8**, garantindo compatibilidade com a versão mais recente.
  - Manutenção da estrutura original do desafio para seguir os padrões propostos pela DIO.

Com essas alterações, o programa agora é **plenamente funcional** e segue todas as regras definidas no enunciado do desafio.


---

## Como executar o projeto

1. Clone este repositório:
   ```bash
   git clone https://github.com/MarcioGil/trilha-net-explorando-desafio.git

cd trilha-net-explorando-desafio

dotnet run

Hospedes: 2
Valor diaria: R$ 150,00
Valor total: R$ 300,00

Tecnologias utilizadas

.NET 8

C#

Programação Orientada a Objetos (POO)

Git e GitHub

Créditos e informações pessoais

Este projeto faz parte da Trilha .NET da DIO e foi proposto pelo professor Leonardo Buta, responsável pela explicação e disponibilização do repositório original:
👉 Repositório original

Implementação e versão personalizada por:
Márcio Alexandre de Paiva Gil
🔗 GitHub: MarcioGil

📧 Email: (marciopaiva.gil@gmail.com)
🌐 Repositório com minha solução: https://github.com/MarcioGil/trilha-net-explorando-desafio.git