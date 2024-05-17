﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TechVagas_EstagioTech.Data;

#nullable disable

namespace TechVagas_EstagioTech.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.AlunoModel", b =>
                {
                    b.Property<int>("AlunoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("alunoid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AlunoId"));

                    b.Property<int?>("AlunoModelAlunoId")
                        .HasColumnType("integer");

                    b.Property<string>("AreaInteresse")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("areainteresse");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("bairro");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("character varying(9)")
                        .HasColumnName("cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("cidade");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("character varying(14)")
                        .HasColumnName("cpf");

                    b.Property<string>("Curriculo")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("curriculo");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("datanascimento");

                    b.Property<string>("DisponibilidadeHorario")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("character varying(35)")
                        .HasColumnName("disponibilidadehorario");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("email");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("endereco");

                    b.Property<string>("Experiencias")
                        .IsRequired()
                        .HasMaxLength(350)
                        .HasColumnType("character varying(350)")
                        .HasColumnName("experiencias");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("genero");

                    b.Property<string>("Habilidades")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("habilidades");

                    b.Property<int>("Idade")
                        .HasColumnType("integer")
                        .HasColumnName("idade");

                    b.Property<string>("NivelEscolaridade")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)")
                        .HasColumnName("nivelescolaridade");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("nome");

                    b.Property<string>("NumeroMatricula")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("numeromatricula");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("character varying(12)")
                        .HasColumnName("rg");

                    b.Property<bool>("StatusAluno")
                        .HasColumnType("boolean")
                        .HasColumnName("statusaluno");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("character varying(14)")
                        .HasColumnName("telefone");

                    b.HasKey("AlunoId");

                    b.HasIndex("AlunoModelAlunoId");

                    b.ToTable("aluno");
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.ApontamentoModel", b =>
                {
                    b.Property<int>("idApontamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("apontamentoid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idApontamento"));

                    b.Property<int?>("CoordenadorEstagioModelidCoordenadorEstagio")
                        .HasColumnType("integer");

                    b.Property<DateOnly?>("dataApontamento")
                        .IsRequired()
                        .HasColumnType("date")
                        .HasColumnName("dataApontamento");

                    b.Property<string>("descricaoApontamento")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("descricaoApontamento");

                    b.Property<int>("idCoordenadorEstagio")
                        .HasColumnType("integer")
                        .HasColumnName("coordenadorestagioid");

                    b.HasKey("idApontamento");

                    b.HasIndex("CoordenadorEstagioModelidCoordenadorEstagio");

                    b.HasIndex("idCoordenadorEstagio");

                    b.ToTable("apontamento");
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.CargoModel", b =>
                {
                    b.Property<int>("CargoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("cargoid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CargoId"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("descricao");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("tipo");

                    b.HasKey("CargoId");

                    b.ToTable("cargo");
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.ConcedenteModel", b =>
                {
                    b.Property<int>("concedenteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("concedenteid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("concedenteId"));

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)")
                        .HasColumnName("cnpj");

                    b.Property<string>("Localidade")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("localidade");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)")
                        .HasColumnName("razaosocial");

                    b.Property<string>("ResponsavelEstagio")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("responsavelestagio");

                    b.HasKey("concedenteId");

                    b.ToTable("concedente");
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.ContratoEstagioModel", b =>
                {
                    b.Property<int>("idContratoEstagio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ContratoEstagioid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idContratoEstagio"));

                    b.Property<int?>("CoordenadorEstagioidCoordenadorEstagio")
                        .HasColumnType("integer");

                    b.Property<int?>("SupervisorEstagioidSupervisor")
                        .HasColumnType("integer");

                    b.Property<int?>("TipoEstagioidTipoEstagio")
                        .HasColumnType("integer");

                    b.Property<string>("cargaSemanal")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("cargasemanal");

                    b.Property<string>("cargaTotal")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("cargatotal");

                    b.Property<DateOnly?>("dataFim")
                        .IsRequired()
                        .HasColumnType("date")
                        .HasColumnName("datafim");

                    b.Property<DateOnly?>("dataInicio")
                        .IsRequired()
                        .HasColumnType("date")
                        .HasColumnName("datainicio");

                    b.Property<string>("horarioEntrada")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("Horario de Entrada");

                    b.Property<string>("horarioSaida")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("Horario de Saida");

                    b.Property<int>("idCoordenadorEstagio")
                        .HasColumnType("integer")
                        .HasColumnName("coordenadorestagioid");

                    b.Property<int>("idSupervisorEstagio")
                        .HasColumnType("integer")
                        .HasColumnName("supervisorestagioid");

                    b.Property<int>("idTipoEstagio")
                        .HasColumnType("integer")
                        .HasColumnName("tipoestagioid");

                    b.Property<string>("notaFinal")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("notafinal");

                    b.Property<string>("salario")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("salario");

                    b.Property<string>("situacao")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("situacao");

                    b.Property<bool>("statusContratoEstagio")
                        .HasColumnType("boolean")
                        .HasColumnName("Status do ContratoEstagio");

                    b.HasKey("idContratoEstagio");

                    b.HasIndex("CoordenadorEstagioidCoordenadorEstagio");

                    b.HasIndex("SupervisorEstagioidSupervisor");

                    b.HasIndex("TipoEstagioidTipoEstagio");

                    b.ToTable("contratoestagio");
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.CoordenadorEstagioModel", b =>
                {
                    b.Property<int>("idCoordenadorEstagio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("coordenadorestagioid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idCoordenadorEstagio"));

                    b.Property<bool>("StatusCoordenadorEstagio")
                        .HasColumnType("boolean")
                        .HasColumnName("statuscoordenador");

                    b.Property<DateOnly?>("dataCadastro")
                        .IsRequired()
                        .HasColumnType("date")
                        .HasColumnName("datacadastro");

                    b.HasKey("idCoordenadorEstagio");

                    b.ToTable("coordenadorestagio");
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.CursoModel", b =>
                {
                    b.Property<int>("cursoid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("cursoid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("cursoid"));

                    b.Property<string>("nomeCurso")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("nomecurso");

                    b.Property<string>("turnoCurso")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("turnocurso");

                    b.HasKey("cursoid");

                    b.ToTable("curso");
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.DocumentoModel", b =>
                {
                    b.Property<int>("idDocumento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("documentoid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idDocumento"));

                    b.Property<string>("descricaoDocumento")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("descricao");

                    b.Property<string>("situacaoDocumento")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("situacao");

                    b.HasKey("idDocumento");

                    b.ToTable("documento");
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.DocumentoNecessarioModel", b =>
                {
                    b.Property<int>("idDocumentoNecessario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("documentonecessarioid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idDocumentoNecessario"));

                    b.Property<int?>("TipoDocumentoModelidTipoDocumento")
                        .HasColumnType("integer");

                    b.Property<int?>("TipoEstagioModelidTipoEstagio")
                        .HasColumnType("integer");

                    b.Property<int>("idTipoDocumento")
                        .HasColumnType("integer")
                        .HasColumnName("tipodocumentoid");

                    b.Property<int>("idTipoEstagio")
                        .HasColumnType("integer")
                        .HasColumnName("tipoestagioid");

                    b.HasKey("idDocumentoNecessario");

                    b.HasIndex("TipoDocumentoModelidTipoDocumento");

                    b.HasIndex("TipoEstagioModelidTipoEstagio");

                    b.HasIndex("idTipoDocumento");

                    b.HasIndex("idTipoEstagio");

                    b.ToTable("documentonecessario");

                    b.HasData(
                        new
                        {
                            idDocumentoNecessario = 1,
                            idTipoDocumento = 1,
                            idTipoEstagio = 1
                        },
                        new
                        {
                            idDocumentoNecessario = 2,
                            idTipoDocumento = 2,
                            idTipoEstagio = 1
                        },
                        new
                        {
                            idDocumentoNecessario = 3,
                            idTipoDocumento = 3,
                            idTipoEstagio = 1
                        },
                        new
                        {
                            idDocumentoNecessario = 4,
                            idTipoDocumento = 4,
                            idTipoEstagio = 1
                        },
                        new
                        {
                            idDocumentoNecessario = 5,
                            idTipoDocumento = 4,
                            idTipoEstagio = 2
                        });
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.DocumentoVersaoModel", b =>
                {
                    b.Property<int>("idDocumentoVersao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("documentoversaoid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idDocumentoVersao"));

                    b.Property<string>("Anexo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("anexo");

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("comentario");

                    b.Property<DateOnly?>("Data")
                        .IsRequired()
                        .HasColumnType("date")
                        .HasColumnName("data");

                    b.Property<int>("DocumentoId")
                        .HasColumnType("integer")
                        .HasColumnName("documentoid");

                    b.Property<string>("Situacao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("situacao");

                    b.HasKey("idDocumentoVersao");

                    b.HasIndex("DocumentoId");

                    b.ToTable("documentoversao");
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.InstituicaoEnsinoModel", b =>
                {
                    b.Property<int>("idInstituicaoEnsino")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idInstituicaoEnsino"));

                    b.Property<string>("LocalInstituicao")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("character varying(120)")
                        .HasColumnName("local");

                    b.Property<string>("NomeInstituicao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("nomeinstituicao");

                    b.Property<string>("TelefoneInstituicao")
                        .IsRequired()
                        .HasMaxLength(17)
                        .HasColumnType("character varying(17)")
                        .HasColumnName("telefone");

                    b.HasKey("idInstituicaoEnsino");

                    b.ToTable("instituicaoensino");
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.MatriculaModel", b =>
                {
                    b.Property<int>("MatriculaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("matriculaid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MatriculaId"));

                    b.Property<int>("AlunoId")
                        .HasColumnType("integer")
                        .HasColumnName("alunoid");

                    b.Property<int?>("AlunosAlunoId")
                        .HasColumnType("integer");

                    b.Property<string>("NumeroMatricula")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("numeromatricula");

                    b.Property<int>("cursoid")
                        .HasColumnType("integer")
                        .HasColumnName("cursoid");

                    b.HasKey("MatriculaId");

                    b.HasIndex("AlunosAlunoId");

                    b.HasIndex("cursoid");

                    b.ToTable("matricula");
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.SupervisorEstagioModel", b =>
                {
                    b.Property<int>("idSupervisor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("supervisorid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idSupervisor"));

                    b.Property<bool>("statusSupervisor")
                        .HasColumnType("boolean")
                        .HasColumnName("status");

                    b.HasKey("idSupervisor");

                    b.ToTable("supervisorestagio");
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.TipoDocumentoModel", b =>
                {
                    b.Property<int>("idTipoDocumento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("tipodocumentoid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idTipoDocumento"));

                    b.Property<bool>("Status")
                        .HasColumnType("boolean")
                        .HasColumnName("statustipodocumento");

                    b.Property<string>("descricaoTipoDocumento")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("descricao");

                    b.HasKey("idTipoDocumento");

                    b.ToTable("tipodocumento");

                    b.HasData(
                        new
                        {
                            idTipoDocumento = 1,
                            Status = false,
                            descricaoTipoDocumento = "Contrato Social"
                        },
                        new
                        {
                            idTipoDocumento = 2,
                            Status = false,
                            descricaoTipoDocumento = "CLT"
                        },
                        new
                        {
                            idTipoDocumento = 3,
                            Status = false,
                            descricaoTipoDocumento = "Especificação"
                        },
                        new
                        {
                            idTipoDocumento = 4,
                            Status = false,
                            descricaoTipoDocumento = "Seguro de assistentes pessoais"
                        });
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.TipoEstagioModel", b =>
                {
                    b.Property<int>("idTipoEstagio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("tipoestagioid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("idTipoEstagio"));

                    b.Property<string>("descricaoTipoEstagio")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("descricao");

                    b.HasKey("idTipoEstagio");

                    b.ToTable("tipoestagio");

                    b.HasData(
                        new
                        {
                            idTipoEstagio = 1,
                            descricaoTipoEstagio = "Equivalência"
                        },
                        new
                        {
                            idTipoEstagio = 2,
                            descricaoTipoEstagio = "Normal"
                        });
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.VagasModel", b =>
                {
                    b.Property<int>("VagasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("vagasid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("VagasId"));

                    b.Property<int>("CargoId")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("DataLimite")
                        .HasColumnType("date")
                        .HasColumnName("datalimite");

                    b.Property<DateOnly>("DataPublicacao")
                        .HasColumnType("date")
                        .HasColumnName("datapublicacao");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("descricao");

                    b.Property<string>("HorarioEntrada")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("horarioentrada");

                    b.Property<string>("HorarioSaida")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("horariosaida");

                    b.Property<string>("Localidade")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)")
                        .HasColumnName("localidade");

                    b.Property<string>("LocalidadeTrabalho")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("localidadetrabalho");

                    b.Property<int>("Quantidade")
                        .HasColumnType("integer")
                        .HasColumnName("quantidade");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)")
                        .HasColumnName("titulo");

                    b.Property<string>("TotalHorasSemanis")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("totalhorassemanais");

                    b.Property<int>("concedenteId")
                        .HasColumnType("integer");

                    b.HasKey("VagasId");

                    b.HasIndex("CargoId");

                    b.HasIndex("concedenteId");

                    b.ToTable("vagas");
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.AlunoModel", b =>
                {
                    b.HasOne("TechVagas_EstagioTech.Objects.Model.Entities.AlunoModel", null)
                        .WithMany("Alunos")
                        .HasForeignKey("AlunoModelAlunoId");
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.ApontamentoModel", b =>
                {
                    b.HasOne("TechVagas_EstagioTech.Objects.Model.Entities.CoordenadorEstagioModel", null)
                        .WithMany("Apontamento")
                        .HasForeignKey("CoordenadorEstagioModelidCoordenadorEstagio");

                    b.HasOne("TechVagas_EstagioTech.Objects.Model.Entities.CoordenadorEstagioModel", "CoordenadorEstagio")
                        .WithMany()
                        .HasForeignKey("idCoordenadorEstagio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CoordenadorEstagio");
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.ContratoEstagioModel", b =>
                {
                    b.HasOne("TechVagas_EstagioTech.Objects.Model.Entities.CoordenadorEstagioModel", "CoordenadorEstagio")
                        .WithMany("ContratoEstagio")
                        .HasForeignKey("CoordenadorEstagioidCoordenadorEstagio");

                    b.HasOne("TechVagas_EstagioTech.Objects.Model.Entities.SupervisorEstagioModel", "SupervisorEstagio")
                        .WithMany("ContratoEstagio")
                        .HasForeignKey("SupervisorEstagioidSupervisor");

                    b.HasOne("TechVagas_EstagioTech.Objects.Model.Entities.TipoEstagioModel", "TipoEstagio")
                        .WithMany("ContratoEstagio")
                        .HasForeignKey("TipoEstagioidTipoEstagio");

                    b.Navigation("CoordenadorEstagio");

                    b.Navigation("SupervisorEstagio");

                    b.Navigation("TipoEstagio");
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.DocumentoNecessarioModel", b =>
                {
                    b.HasOne("TechVagas_EstagioTech.Objects.Model.Entities.TipoDocumentoModel", null)
                        .WithMany("DocumentosNecessarios")
                        .HasForeignKey("TipoDocumentoModelidTipoDocumento");

                    b.HasOne("TechVagas_EstagioTech.Objects.Model.Entities.TipoEstagioModel", null)
                        .WithMany("DocumentosNecessarios")
                        .HasForeignKey("TipoEstagioModelidTipoEstagio");

                    b.HasOne("TechVagas_EstagioTech.Objects.Model.Entities.TipoDocumentoModel", "TipoDocumento")
                        .WithMany()
                        .HasForeignKey("idTipoDocumento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechVagas_EstagioTech.Objects.Model.Entities.TipoEstagioModel", "TipoEstagio")
                        .WithMany()
                        .HasForeignKey("idTipoEstagio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoDocumento");

                    b.Navigation("TipoEstagio");
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.DocumentoVersaoModel", b =>
                {
                    b.HasOne("TechVagas_EstagioTech.Objects.Model.Entities.DocumentoModel", "Documento")
                        .WithMany("DocumentoVersoes")
                        .HasForeignKey("DocumentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Documento");
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.MatriculaModel", b =>
                {
                    b.HasOne("TechVagas_EstagioTech.Objects.Model.Entities.AlunoModel", "Alunos")
                        .WithMany()
                        .HasForeignKey("AlunosAlunoId");

                    b.HasOne("TechVagas_EstagioTech.Objects.Model.Entities.CursoModel", "Curso")
                        .WithMany("Matricula")
                        .HasForeignKey("cursoid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Alunos");

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.VagasModel", b =>
                {
                    b.HasOne("TechVagas_EstagioTech.Objects.Model.Entities.CargoModel", "Cargo")
                        .WithMany()
                        .HasForeignKey("CargoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TechVagas_EstagioTech.Objects.Model.Entities.ConcedenteModel", "Concedente")
                        .WithMany("Vagas")
                        .HasForeignKey("concedenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cargo");

                    b.Navigation("Concedente");
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.AlunoModel", b =>
                {
                    b.Navigation("Alunos");
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.ConcedenteModel", b =>
                {
                    b.Navigation("Vagas");
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.CoordenadorEstagioModel", b =>
                {
                    b.Navigation("Apontamento");

                    b.Navigation("ContratoEstagio");
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.CursoModel", b =>
                {
                    b.Navigation("Matricula");
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.DocumentoModel", b =>
                {
                    b.Navigation("DocumentoVersoes");
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.SupervisorEstagioModel", b =>
                {
                    b.Navigation("ContratoEstagio");
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.TipoDocumentoModel", b =>
                {
                    b.Navigation("DocumentosNecessarios");
                });

            modelBuilder.Entity("TechVagas_EstagioTech.Objects.Model.Entities.TipoEstagioModel", b =>
                {
                    b.Navigation("ContratoEstagio");

                    b.Navigation("DocumentosNecessarios");
                });
#pragma warning restore 612, 618
        }
    }
}
