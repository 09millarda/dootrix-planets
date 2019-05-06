﻿// <auto-generated />
using Dootrix.Planets.Data.SQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dootrix.Planets.Data.SQL.Migrations
{
    [DbContext(typeof(DbStateContext))]
    [Migration("20190505165439_add-planetary-order")]
    partial class addplanetaryorder
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dootrix.Planets.Data.SQL.Models.ExtraInformation", b =>
                {
                    b.Property<int>("ExtraInformationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PlanetId");

                    b.Property<string>("Text");

                    b.Property<string>("Title");

                    b.HasKey("ExtraInformationId");

                    b.HasIndex("PlanetId");

                    b.ToTable("ExtraInformation");
                });

            modelBuilder.Entity("Dootrix.Planets.Data.SQL.Models.Planet", b =>
                {
                    b.Property<int>("PlanetId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AstronomicalUnits");

                    b.Property<string>("Description");

                    b.Property<decimal>("Diameter");

                    b.Property<decimal>("Mass");

                    b.Property<string>("Name");

                    b.Property<int>("PlanetaryOrder");

                    b.HasKey("PlanetId");

                    b.ToTable("Planets");
                });

            modelBuilder.Entity("Dootrix.Planets.Data.SQL.Models.ExtraInformation", b =>
                {
                    b.HasOne("Dootrix.Planets.Data.SQL.Models.Planet", "Planet")
                        .WithMany("ExtraInformation")
                        .HasForeignKey("PlanetId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
