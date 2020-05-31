using Microsoft.EntityFrameworkCore;
using KLADobj.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace KLADobj.InfrastructureServices.Gateways.Database
{
    public class KLADobjContext : DbContext
    {
        public DbSet<kladobj> KLADobjs { get; set; }

        public KLADobjContext(DbContextOptions options)
            : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            FillTestData(modelBuilder);
        }
        private void FillTestData(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<kladobj>().HasData(
                new
                {
                    Id = 1L,
                    Name = "Домодедовское кладбище",
                    Address = "Московская область, г. Домодедово, вблизи д. Истомиха, территория Домодедовское кладбище",
                    ChillType = "урной в землю, гробом в землю",
                    Free = "закрытое",
                    
                },
                new
                {
                    Id = 2L,
                    Name = "Жохово кладбище",
                    Address = "деревня Жохово",
                    ChillType = "гробом в землю",
                    Free = "закрытое",

                },
                new
                {
                    Id = 3L,
                    Name = "Захарьинское кладбище",
                    Address = "улица Николая Сироткина",
                    ChillType = "урной в землю,гробом в землю",
                    Free = "открытое",

                },
                new
                {
                    Id = 4L,
                    Name = "Зеленоградское (Северное) кладбище",
                    Address = "Зеленоград, Проезд N 710, дом 19 стр. 1, 3, 4",
                    ChillType = "урной в открытый колумбарий, урной в землю, гробом в землю",
                    Free = "закрытое",

                }
               
            );
        }
    }
}
