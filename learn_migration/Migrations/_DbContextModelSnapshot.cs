// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using learn_migration.Infrastructure.DataModels;

#nullable disable

namespace learn_migration.Migrations
{
    [DbContext(typeof(_DbContext))]
    partial class _DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("learn_migration.Infrastructure.DataModels.TbGenero", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("genero");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Genero" }, "tb_genero_genero_key")
                        .IsUnique();

                    b.ToTable("tb_genero", (string)null);
                });

            modelBuilder.Entity("learn_migration.Infrastructure.DataModels.TbInscrito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DataPub")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_pub");

                    b.Property<int>("Genero")
                        .HasColumnType("int")
                        .HasColumnName("genero");

                    b.Property<int>("Instituicao")
                        .HasColumnType("int")
                        .HasColumnName("instituicao");

                    b.Property<int>("Jogador")
                        .HasColumnType("int")
                        .HasColumnName("jogador");

                    b.HasKey("Id");

                    b.HasIndex("Genero");

                    b.HasIndex("Instituicao");

                    b.HasIndex("Jogador");

                    b.ToTable("tb_inscrito", (string)null);
                });

            modelBuilder.Entity("learn_migration.Infrastructure.DataModels.TbInstituicao", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Nome" }, "tb_instituicao_nome_key")
                        .IsUnique();

                    b.ToTable("tb_instituicao", (string)null);
                });

            modelBuilder.Entity("learn_migration.Infrastructure.DataModels.TbJogador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DataNasc")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_nasc");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("nome");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("sobrenome");

                    b.HasKey("Id");

                    b.ToTable("tb_jogador", (string)null);
                });

            modelBuilder.Entity("learn_migration.Infrastructure.DataModels.TbInscrito", b =>
                {
                    b.HasOne("learn_migration.Infrastructure.DataModels.TbGenero", "GeneroNavigation")
                        .WithMany("TbInscritos")
                        .HasForeignKey("Genero")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("tb_inscrito_genero_fkey");

                    b.HasOne("learn_migration.Infrastructure.DataModels.TbInstituicao", "InstituicaoNavigation")
                        .WithMany("TbInscritos")
                        .HasForeignKey("Instituicao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("tb_inscrito_instituicao_fkey");

                    b.HasOne("learn_migration.Infrastructure.DataModels.TbJogador", "JogadorNavigation")
                        .WithMany("TbInscritos")
                        .HasForeignKey("Jogador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("tb_inscrito_jogador_fkey");

                    b.Navigation("GeneroNavigation");

                    b.Navigation("InstituicaoNavigation");

                    b.Navigation("JogadorNavigation");
                });

            modelBuilder.Entity("learn_migration.Infrastructure.DataModels.TbGenero", b =>
                {
                    b.Navigation("TbInscritos");
                });

            modelBuilder.Entity("learn_migration.Infrastructure.DataModels.TbInstituicao", b =>
                {
                    b.Navigation("TbInscritos");
                });

            modelBuilder.Entity("learn_migration.Infrastructure.DataModels.TbJogador", b =>
                {
                    b.Navigation("TbInscritos");
                });
#pragma warning restore 612, 618
        }
    }
}
