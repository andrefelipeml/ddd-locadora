using SVL.Domain.Base;
using System;
using System.Collections.Generic;

namespace SVL.Domain.Devolution
{
    public class Devolution : BaseEntity
    {
        private int _locationId;
        private int _customerId;
        private ICollection<AplicationCore.Domain.Media> _medias;

        /// <summary>
        /// ID da Locação 
        /// </summary>
        public int LocationId { get => _locationId; set => _locationId = value; }

        private int CustomerI { get => _customerId; set => _customerId = value; }
        /// <summary>
        /// Identifica se a Locação esta finalizada
        /// </summary>
        public Boolean IsFinished { get => _isFinished; set => _isFinished = value; }


        public ICollection<AplicationCore.Domain.Media>  Medias { get => _medias; set => _medias = value; } 

        private void ReturnMedia(AplicationCore.Domain.Media media) { }

        private void IsComplete() { }
    }
}
