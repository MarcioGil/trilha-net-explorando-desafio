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

Durante o desenvolvimento, fizemos ajustes para garantir que o código rodasse corretamente no Visual Studio Code, como:
- Remoção de acentos para evitar problemas de compilação.
- Organização da estrutura de arquivos dentro do projeto.
- Correção de pequenos detalhes de nomenclatura.

---

Este projeto faz parte da **Trilha .NET da DIO** e foi proposto pelo professor [Leonardo Buta](https://www.linkedin.com/in/leonardo-buta/), responsável pela explicação e disponibilização do repositório original:  
👉 [Repositório original](https://github.com/digitalinnovationone/trilha-net-explorando-desafio)

---

📌 Repositório com minha solução: [MarcioGil/trilha-net-explorando-desafio](https://github.com/MarcioGil/trilha-net-explorando-desafio)

👤 Autor: **Márcio Alexandre de Paiva Gil**  
🌐 Portfólio: [https://marciogil.github.io/meu-portfolio_profissional/](https://marciogil.github.io/meu-portfolio_profissional/)
