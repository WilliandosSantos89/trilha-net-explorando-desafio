namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            if (suite.CapacidadeMaxima < 1 || diasReservados < 1)
            {
                throw new ArgumentException("A quantidade de hóspedes e dias reservados deve ser maio que 0.")
            }

            if (suite.CapacidadeMaxima < hospedes.QuantidadeHospedes)
            {
                throw new ArgumentException ("A suíte não pode hospedar a quantidade de hóspedes informada.")
            }
            
            Hospede = hospede;
            Suite = suite;
            DiasReservados = diasReservados;
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {            
            return Hospede.QuantidadeHospedes;
        }

        
        public double CalcularValorDiaria()
        {
            double valorDiaria = Suite.ValorDiaria;         

            
            if (DiasReservados >= 10)
            {
                valorDiaria *= 0.9;
            }

            return valorDiaria * DiasReservados;
        }
    }
}
