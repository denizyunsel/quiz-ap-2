﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuizAPI.models;

#nullable disable

namespace QuizAPI.Migrations
{
    [DbContext(typeof(QuizDbContext))]
    partial class QuizDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("QuizAPI.models.Participant", b =>
                {
                    b.Property<int>("participantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("participantId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<int>("TimeTaken")
                        .HasColumnType("int");

                    b.HasKey("participantId");

                    b.ToTable("Participant");
                });

            modelBuilder.Entity("QuizAPI.models.Question", b =>
                {
                    b.Property<int>("QnId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QnId"), 1L, 1);

                    b.Property<int>("Answer")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("QnInWords")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("option1")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("option2")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("option3")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("option4")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("QnId");

                    b.ToTable("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
