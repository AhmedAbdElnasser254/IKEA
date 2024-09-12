﻿using LinkDev.IKEA.DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDev.IKEA.DAL.Data.Configurations
{
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {

        public void Configure(EntityTypeBuilder<Department> builder)
        {
            // Fluent APIs for "Department" Domain

            builder.Property(D => D.Id).UseIdentityColumn(10, 10);
            builder.Property(D => D.Code).HasColumnType("varchar(20)").IsRequired();
            builder.Property(D => D.Name).HasColumnType("varchar(50)").IsRequired();
            builder.Property(D => D.CreatedOn).HasDefaultValue("GETDATE()");
          // builder.Property(D => D.CreatedBy).HasDefaultValue("GETDATE()");
            builder.Property(D => D.LastModifiedOn).HasComputedColumnSql("GETDATE()");
          // builder.Property(D => D.LastModifiedBy).HasComputedColumnSql("GETDATE()");




        }
    }
}
