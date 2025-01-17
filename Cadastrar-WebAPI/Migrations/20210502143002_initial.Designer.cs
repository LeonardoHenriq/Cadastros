﻿// <auto-generated />
using Cadastrar_WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cadastrar_WebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210502143002_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("Cadastrar_WebAPI.Models.Pf", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("cpf")
                        .HasColumnType("TEXT");

                    b.Property<string>("endereco")
                        .HasColumnType("TEXT");

                    b.Property<int>("idade")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Pf");

                    b.HasData(
                        new
                        {
                            id = 1,
                            cpf = "111.111.111-11",
                            endereco = "rua: xyz",
                            idade = 22,
                            nome = "Marta",
                            telefone = "(17)99150-9019"
                        },
                        new
                        {
                            id = 2,
                            cpf = "111.111.111-11",
                            endereco = "rua: xyz",
                            idade = 22,
                            nome = "Paula",
                            telefone = "(17)99150-9019"
                        },
                        new
                        {
                            id = 3,
                            cpf = "111.111.111-11",
                            endereco = "rua: xyz",
                            idade = 22,
                            nome = "Laura",
                            telefone = "(17)99150-9019"
                        },
                        new
                        {
                            id = 4,
                            cpf = "111.111.111-11",
                            endereco = "rua: xyz",
                            idade = 22,
                            nome = "Luiza",
                            telefone = "(17)99150-9019"
                        },
                        new
                        {
                            id = 5,
                            cpf = "111.111.111-11",
                            endereco = "rua: xyz",
                            idade = 22,
                            nome = "Lucas",
                            telefone = "(17)99150-9019"
                        },
                        new
                        {
                            id = 6,
                            cpf = "111.111.111-11",
                            endereco = "rua: xyz",
                            idade = 22,
                            nome = "Pedro",
                            telefone = "(17)99150-9019"
                        },
                        new
                        {
                            id = 7,
                            cpf = "111.111.111-11",
                            endereco = "rua: xyz",
                            idade = 22,
                            nome = "Paulo",
                            telefone = "(17)99150-9019"
                        });
                });

            modelBuilder.Entity("Cadastrar_WebAPI.Models.Pj", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("cnpj")
                        .HasColumnType("TEXT");

                    b.Property<string>("endereco")
                        .HasColumnType("TEXT");

                    b.Property<string>("razsoc")
                        .HasColumnType("TEXT");

                    b.Property<string>("telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Pj");

                    b.HasData(
                        new
                        {
                            id = 1,
                            cnpj = "111.111.111/0001-1",
                            endereco = "rua: xjh",
                            razsoc = "data par",
                            telefone = "(17)3333-3333"
                        },
                        new
                        {
                            id = 2,
                            cnpj = "222.222.222/0001-1",
                            endereco = "rua: abc",
                            razsoc = "riopretrans",
                            telefone = "(17)3333-3333"
                        },
                        new
                        {
                            id = 3,
                            cnpj = "333.333.333/0001-1",
                            endereco = "rua: yaz",
                            razsoc = "transreal",
                            telefone = "(17)3333-3333"
                        },
                        new
                        {
                            id = 4,
                            cnpj = "444.444.444/0001-1",
                            endereco = "rua: asd",
                            razsoc = "real rondonia",
                            telefone = "(17)3333-3333"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
