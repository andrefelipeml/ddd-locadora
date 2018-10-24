﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SVL.AplicationCore.Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SVL.Infra.DomainConfig
{
    /// <summary>
    /// Implementa IEntityTypeConfiguration - Interface do Entity FrameCore do Fluent Api
    /// </summary>
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {

        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder
                .HasKey(s => s.ID);

            builder
                .HasMany(g => g.Contatos)
                .WithOne(g => g.Customer)
                .HasForeignKey(g => g.CustomerId)
                .HasPrincipalKey(g => g.ID);

            builder
                .HasMany(a => a.Addresses)
                .WithOne(a => a.Customer)
                .HasForeignKey(a => a.CustomerId)
                .HasPrincipalKey(a => a.ID);

            builder
                .Property(c => c.Cpf).HasColumnType("varchar(11)")
                .IsRequired();

            builder
                .Property(c => c.Sexo).IsRequired();



        }
    }
}
