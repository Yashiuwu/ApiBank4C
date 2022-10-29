﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Persistence.Configuration
{
    public class ClientConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nombre)
                .HasMaxLength(80)
                .IsRequired();
            builder.Property(p => p.Apellido)
                .HasMaxLength(80)
                .IsRequired();
            builder.Property(p => p.FechaDeNacimiento)
                .IsRequired();
            builder.Property(p => p.Telefono)
                .HasMaxLength(10)
                .IsRequired();
            builder.Property(p => p.Email)
                .HasMaxLength(100);
            builder.Property(p => p.Direccion)
                .HasMaxLength(120)
                .IsRequired();
            builder.Property(p => p.Edad);
            builder.Property(p => p.CreatedBy)
                .HasMaxLength(30);
            builder.Property(p => p.LasModifiedBy)
                .HasMaxLength(30);

        }
    }
}
