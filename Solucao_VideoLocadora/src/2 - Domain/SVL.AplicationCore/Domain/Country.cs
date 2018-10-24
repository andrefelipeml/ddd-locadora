using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SVL.AplicationCore.Domain
{
    public class Country : BaseEntity
    {
        private string _name;

        public string Description { get => _name; set => _name = value; }

    }
}
