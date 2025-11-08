using System;

namespace AppHotelPlus.Models
{
    public class Hospede
    {
        private int _idade;
        private DateTime _dataCheckin;

        public string Nome { get; set; }

        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0) throw new ArgumentException("Idade não pode ser negativa.");
                _idade = value;
            }
        }

        public DateTime DataCheckin
        {
            get => _dataCheckin;
            set
            {
                if (value < DateTime.Today) throw new ArgumentException("Data de check-in não pode ser no passado.");
                _dataCheckin = value;
            }
        }

        public override string ToString()
        {
            return $"{Nome} — {Idade} anos — {DataCheckin:dd/MM/yyyy}";
        }
    }
}
