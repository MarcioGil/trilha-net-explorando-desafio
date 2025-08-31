namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; } = new();
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Verificar se a capacidade da suíte comporta a quantidade de hóspedes recebida
            if (Suite == null)
                throw new InvalidOperationException("Cadastre a suíte antes de cadastrar os hóspedes.");

            if (hospedes == null)
                throw new ArgumentNullException(nameof(hospedes), "A lista de hóspedes não pode ser nula.");

            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Lança exceção se a capacidade for menor que o número de hóspedes
                throw new InvalidOperationException(
                    $"A suíte selecionada comporta até {Suite.Capacidade} hóspede(s), " +
                    $"mas foram informados {hospedes.Count}.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite ?? throw new ArgumentNullException(nameof(suite));
        }

        public int ObterQuantidadeHospedes()
        {
            // Retorna a quantidade de hóspedes cadastrados
            return Hospedes?.Count ?? 0;
        }

        public decimal CalcularValorDiaria()
        {
            if (Suite == null)
                throw new InvalidOperationException("Não é possível calcular o valor sem uma suíte cadastrada.");

            if (DiasReservados <= 0)
                throw new InvalidOperationException("Dias reservados deve ser maior que zero.");

            // Cálculo: DiasReservados X Suite.ValorDiaria
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: se DiasReservados >= 10, aplica 10% de desconto
            if (DiasReservados >= 10)
            {
                valor *= 0.90m; // desconto de 10%
            }

            return valor;
        }
    }
}
