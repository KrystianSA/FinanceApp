﻿// <auto-generated />
using FinanceApp.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinanceApp.DataAccess.Migrations
{
    [DbContext(typeof(HomeBudgetStorageContext))]
    [Migration("20230426124325_AddBills")]
    partial class AddBills
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BillMoney", b =>
                {
                    b.Property<int>("BillsId")
                        .HasColumnType("int");

                    b.Property<int>("MoneyId")
                        .HasColumnType("int");

                    b.HasKey("BillsId", "MoneyId");

                    b.HasIndex("MoneyId");

                    b.ToTable("BillMoney");
                });

            modelBuilder.Entity("FinanceApp.DataAccess.Entities.Bill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("FinanceApp.DataAccess.Entities.GroupOfTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GroupOfTransaction");
                });

            modelBuilder.Entity("FinanceApp.DataAccess.Entities.Money", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GroupOfTransactionId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("GroupOfTransactionId");

                    b.ToTable("Money");
                });

            modelBuilder.Entity("BillMoney", b =>
                {
                    b.HasOne("FinanceApp.DataAccess.Entities.Bill", null)
                        .WithMany()
                        .HasForeignKey("BillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinanceApp.DataAccess.Entities.Money", null)
                        .WithMany()
                        .HasForeignKey("MoneyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FinanceApp.DataAccess.Entities.Money", b =>
                {
                    b.HasOne("FinanceApp.DataAccess.Entities.GroupOfTransaction", "GroupOfTransaction")
                        .WithMany("Money")
                        .HasForeignKey("GroupOfTransactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GroupOfTransaction");
                });

            modelBuilder.Entity("FinanceApp.DataAccess.Entities.GroupOfTransaction", b =>
                {
                    b.Navigation("Money");
                });
#pragma warning restore 612, 618
        }
    }
}