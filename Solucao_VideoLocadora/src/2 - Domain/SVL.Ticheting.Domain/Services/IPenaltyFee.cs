﻿using SVL.Domain.Location;
using System;
using System.Collections.Generic;
using System.Text;

namespace SVL.Ticketing.Domain.Services
{
    public interface IPenaltyFee
    {
        void Apply(Media media, DateTime date);
    }
}
