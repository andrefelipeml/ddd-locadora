using System;
using System.Collections.Generic;

namespace SVL.AplicationCore.Domain
{
    public class Location : BaseEntity
    {
        private DateTime _date;
        private float _valueLocation;
        private Customer _customer;
        private ICollection<Media> _medias;
        private bool _isFinished;

        /// <summary>
        /// Data de Locação
        /// </summary>
        DateTime DateLocation { get => _date; set => _date = value; }

        /// <summary>
        /// Valor da Locação
        /// </summary>
        float ValueLocation { get => _valueLocation; set => _valueLocation = value; }

        /// <summary>
        /// Cliente da Locação
        /// </summary>
        public Customer Customer { get => _customer; set => _customer = value; }
        /// <summary>
        ///  Significa que a Locação pode ter uma lista de VHF
        /// </summary>
        public ICollection<Media> medias { get => _medias; set => _medias = value; }

        /// <summary>
        /// Identifica se a Locação esta finalizada
        /// </summary>
        public Boolean IsFinished { get => _isFinished; set => _isFinished = value; }

    }
}
