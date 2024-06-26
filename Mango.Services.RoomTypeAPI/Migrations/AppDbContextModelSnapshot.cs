﻿// <auto-generated />
using Mango.Services.RoomTypeAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Mango.Services.RoomTypeAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Mango.Services.RoomTypeAPI.Models.RoomType", b =>
                {
                    b.Property<int>("RoomTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomTypeID"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int")
                        .HasColumnName("Capacity");

                    b.Property<string>("Discription")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Discription");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("RoomName");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Photo");

                    b.Property<string>("Services")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Services");

                    b.Property<decimal>("Size")
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("Size");

                    b.HasKey("RoomTypeID");

                    b.ToTable("RoomTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
