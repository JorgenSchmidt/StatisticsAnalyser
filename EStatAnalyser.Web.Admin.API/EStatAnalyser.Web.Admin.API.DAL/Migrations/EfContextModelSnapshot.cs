﻿// <auto-generated />
using EStatAnalyser.Web.Admin.API.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EStatAnalyser.Web.Admin.API.DAL.Migrations
{
    [DbContext(typeof(EfContext))]
    partial class EfContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EStatAnalyser.Web.Admin.API.Core.Entities.Data", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("DataType")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("WasAnalysed")
                        .HasColumnType("boolean");

                    b.Property<string>("XFieldName")
                        .HasColumnType("text");

                    b.Property<string>("YFieldName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("DATAS");
                });

            modelBuilder.Entity("EStatAnalyser.Web.Admin.API.Core.Entities.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("DataId")
                        .HasColumnType("integer");

                    b.Property<double>("X")
                        .HasColumnType("double precision");

                    b.Property<double>("Y")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("DataId");

                    b.ToTable("VALUES");
                });

            modelBuilder.Entity("EStatAnalyser.Web.Admin.API.Core.Entities.Value", b =>
                {
                    b.HasOne("EStatAnalyser.Web.Admin.API.Core.Entities.Data", "CurrentData")
                        .WithMany("Values")
                        .HasForeignKey("DataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CurrentData");
                });

            modelBuilder.Entity("EStatAnalyser.Web.Admin.API.Core.Entities.Data", b =>
                {
                    b.Navigation("Values");
                });
#pragma warning restore 612, 618
        }
    }
}
