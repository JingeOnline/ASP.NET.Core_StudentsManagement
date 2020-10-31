﻿// <auto-generated />
using ASP.NET.Core_StudentsManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASP.NET.Core_StudentsManagement.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201031095406_UpdateStudentModelWithPhotoPath")]
    partial class UpdateStudentModelWithPhotoPath
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASP.NET.Core_StudentsManagement.Models.StudentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Dynasty")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 20,
                            Dynasty = 4,
                            Email = "libai@gmail.com",
                            Name = "李白",
                            PhotoPath = "1.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Age = 33,
                            Dynasty = 4,
                            Email = "baijuyi@gmail.com",
                            Name = "白居易",
                            PhotoPath = "2.jpg"
                        },
                        new
                        {
                            Id = 3,
                            Age = 45,
                            Dynasty = 4,
                            Email = "dufu@gmail.com",
                            Name = "杜甫",
                            PhotoPath = "3.jpg"
                        },
                        new
                        {
                            Id = 4,
                            Age = 51,
                            Dynasty = 4,
                            Email = "wangwei@hotmail.com",
                            Name = "王维",
                            PhotoPath = "4.jpg"
                        },
                        new
                        {
                            Id = 5,
                            Age = 88,
                            Dynasty = 1,
                            Email = "quyuan@outlook.com",
                            Name = "屈原",
                            PhotoPath = "5.jpg"
                        },
                        new
                        {
                            Id = 6,
                            Age = 31,
                            Dynasty = 5,
                            Email = "sushi@163.com",
                            Name = "苏轼",
                            PhotoPath = "6.jpg"
                        },
                        new
                        {
                            Id = 7,
                            Age = 25,
                            Dynasty = 3,
                            Email = "taoyuanming@hotmail.com",
                            Name = "陶渊明",
                            PhotoPath = "7.jpg"
                        },
                        new
                        {
                            Id = 8,
                            Age = 30,
                            Dynasty = 4,
                            Email = "lishangyin@gmail.com",
                            Name = "李商隐",
                            PhotoPath = "8.jpg"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
