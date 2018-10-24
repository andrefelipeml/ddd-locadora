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
        public int CustomerID { get; set; }
        public virtual Customer Customer { get => _customer; set => _customer = value; }
        /// <summary>
        ///  Significa que a Locação pode ter uma lista de Filmes
        /// </summary>
        public ICollection<Media> Contatos { get => _medias; set => _medias = value; }


    }
}
