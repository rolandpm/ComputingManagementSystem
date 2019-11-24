﻿// <auto-generated />
using ComputingManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ComputingManagementSystem.Data;

namespace ComputingManagementSystem.Migrations
{
    [DbContext(typeof(ComputingManagementSystemContext))]
    partial class ComputingManagementSystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ComputingManagementSystem.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<bool>("ItemCheckedOut");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Professor");
                });

            modelBuilder.Entity("ComputingManagementSystem.Models.ProfessorSoftware", b =>
                {
                    b.Property<int>("SoftwareId");

                    b.Property<int>("ProfessorId");

                    b.HasKey("SoftwareId", "ProfessorId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("ProfessorSoftware");
                });

            modelBuilder.Entity("ComputingManagementSystem.Models.Software", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LinkToSoftware");

                    b.Property<string>("SoftwareName");

                    b.Property<string>("VersionNum");

                    b.HasKey("Id");

                    b.ToTable("Software");
                });

            modelBuilder.Entity("ComputingManagementSystem.Models.ProfessorSoftware", b =>
                {
                    b.HasOne("ComputingManagementSystem.Models.Professor", "Professor")
                        .WithMany("ProfessorSoftware")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ComputingManagementSystem.Models.Software", "Software")
                        .WithMany("ProfessorSoftware")
                        .HasForeignKey("SoftwareId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
