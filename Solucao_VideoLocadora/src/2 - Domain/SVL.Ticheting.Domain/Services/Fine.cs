﻿using SVL.AplicationCore.Domain;
using SVL.Ticketing.Domain.Services;
using System;

namespace SVL.Ticketing.Domain
{
    public class Fine: IFine
    {
        public void Apply(Media media, DateTime dataDevolucao) { }
    }
}