using System;

namespace SVL.AplicationCore.Domain
{
    public class Devolution : BaseEntity
    {
        private DateTime _date;
        private MediaLocation _medialocation;
        private int _mediaID;
        private int _locationId;

        /// <summary>
        /// ID da Locação 
        /// </summary>
        public int LocationId { get => _locationId; set => _locationId = value; }
        /// <summary>
        /// Relacionamento com a mídia locada
        /// </summary>
        public int MediaId { get => _mediaID; set => _mediaID = value; }

        /// <summary>
        /// Data da Devolução 
        /// </summary>
        DateTime Date { get => _date; set => _date = value; }


    }
}
