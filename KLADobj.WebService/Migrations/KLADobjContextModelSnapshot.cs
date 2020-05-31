﻿// <auto-generated />
using KLADobj.InfrastructureServices.Gateways.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KLADobj.WebService.Migrations
{
    [DbContext(typeof(KLADobjContext))]
    partial class KLADobjContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("KLADobj.DomainObjects.kladobj", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("ChillType")
                        .HasColumnType("TEXT");

                    b.Property<string>("Free")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("KLADobjs");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Address = "Московская область, г. Домодедово, вблизи д. Истомиха, территория Домодедовское кладбище",
                            ChillType = "урной в землю, гробом в землю",
                            Free = "закрытое",
                            Name = "Домодедовское кладбище"
                        },
                        new
                        {
                            Id = 2L,
                            Address = "деревня Жохово",
                            ChillType = "гробом в землю",
                            Free = "закрытое",
                            Name = "Жохово кладбище"
                        },
                        new
                        {
                            Id = 3L,
                            Address = "улица Николая Сироткина",
                            ChillType = "урной в землю,гробом в землю",
                            Free = "открытое",
                            Name = "Захарьинское кладбище"
                        },
                        new
                        {
                            Id = 4L,
                            Address = "Зеленоград, Проезд N 710, дом 19 стр. 1, 3, 4",
                            ChillType = "урной в открытый колумбарий, урной в землю, гробом в землю",
                            Free = "закрытое",
                            Name = "Зеленоградское (Северное) кладбище"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
