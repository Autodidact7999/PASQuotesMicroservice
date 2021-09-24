﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PolicyAdmin.QuotesMS.API.Data;

namespace PolicyAdmin.QuotesMS.API.Migrations
{
    [DbContext(typeof(QuotesContext))]
    partial class QuotesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PolicyAdmin.QuotesMS.API.Models.QuoteMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BusinessValueRangeFrom")
                        .HasColumnType("int");

                    b.Property<int>("BusinessValueRangeTo")
                        .HasColumnType("int");

                    b.Property<int>("PropertyType")
                        .HasColumnType("int");

                    b.Property<int>("PropertyValueRangeFrom")
                        .HasColumnType("int");

                    b.Property<int>("PropertyValueRangeTo")
                        .HasColumnType("int");

                    b.Property<int>("Quote")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("QuotesMaster");
                });
#pragma warning restore 612, 618
        }
    }
}
