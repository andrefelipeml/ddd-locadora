using System;

namespace SVL.AplicationCore.Domain
{
    public class Devolution : BaseEntity
    {
        private DateTime _devolutionDate;
        private MediaLocation _medialocation;
        private bool _isRelease;
        private int _mediaLocationID;
        private bool _generatesAFine;
        private bool _generatesPoint;


        /// <summary>
        /// Relacionamento com a mídia locada
        /// </summary>
        public int MediaLocationID { get => _mediaLocationID; set => _mediaLocationID = value; }

        public virtual MediaLocation MediaLocation { get => _medialocation; set => _medialocation = value; }

        /// <summary>
        /// Data da Devolução 
        /// </summary>
        DateTime DevolutionDate { get => _devolutionDate; set => _devolutionDate = value; }

        /// <summary>
        /// é Lançamento
        /// </summary>
        Boolean IsRelease { get => _isRelease; set => _isRelease = value; }

        /// <summary>
        /// Gerou Multa
        /// </summary>
        Boolean GeneratesAFine { get => _generatesAFine; set => _generatesAFine = value; }
        /// <summary>
        /// Gerou Pontos Extra por Devolver antes do prazo
        /// </summary>
        Boolean GeneratesPoint { get => _generatesPoint; set => _generatesPoint = value; }

    }
}
