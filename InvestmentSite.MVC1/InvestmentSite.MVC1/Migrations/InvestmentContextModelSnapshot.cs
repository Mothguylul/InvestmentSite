﻿// <auto-generated />
using InvestmentSite.MVC1.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InvestmentSite.MVC1.Migrations
{
    [DbContext(typeof(InvestmentContext))]
    partial class InvestmentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.20");

            modelBuilder.Entity("InvestmentSite.MVC1.Models.ExpenseItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<int>("ExpenseTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PortfolioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PortfolioId");

                    b.ToTable("ExpenseItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 1600.0m,
                            ExpenseTypeId = 1,
                            PortfolioId = 1
                        },
                        new
                        {
                            Id = 2,
                            Amount = 180.0m,
                            ExpenseTypeId = 2,
                            PortfolioId = 1
                        });
                });

            modelBuilder.Entity("InvestmentSite.MVC1.Models.ExpenseType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ExpenseTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Mortgage Payment"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Car Payment"
                        },
                        new
                        {
                            Id = 3,
                            Type = "Other Loan Payment"
                        },
                        new
                        {
                            Id = 4,
                            Type = "Purchase - Groceries"
                        },
                        new
                        {
                            Id = 5,
                            Type = "Purchase - Entertainment"
                        },
                        new
                        {
                            Id = 6,
                            Type = "Taxes"
                        },
                        new
                        {
                            Id = 7,
                            Type = "Utilities"
                        });
                });

            modelBuilder.Entity("InvestmentSite.MVC1.Models.IncomeItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<int>("IncomeTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PortfolioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PortfolioId");

                    b.ToTable("IncomeItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 2000.0m,
                            IncomeTypeId = 1,
                            PortfolioId = 1
                        },
                        new
                        {
                            Id = 2,
                            Amount = 30.0m,
                            IncomeTypeId = 5,
                            PortfolioId = 1
                        });
                });

            modelBuilder.Entity("InvestmentSite.MVC1.Models.IncomeType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("IncomeTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Salary"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Interest"
                        },
                        new
                        {
                            Id = 3,
                            Type = "Sales"
                        },
                        new
                        {
                            Id = 4,
                            Type = "Inheritance"
                        },
                        new
                        {
                            Id = 5,
                            Type = "Gift"
                        });
                });

            modelBuilder.Entity("InvestmentSite.MVC1.Models.Portfolio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Portfolios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("InvestmentSite.MVC1.Models.ExpenseItem", b =>
                {
                    b.HasOne("InvestmentSite.MVC1.Models.Portfolio", null)
                        .WithMany("ExpenseItems")
                        .HasForeignKey("PortfolioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InvestmentSite.MVC1.Models.IncomeItem", b =>
                {
                    b.HasOne("InvestmentSite.MVC1.Models.Portfolio", null)
                        .WithMany("IncomeItems")
                        .HasForeignKey("PortfolioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InvestmentSite.MVC1.Models.Portfolio", b =>
                {
                    b.Navigation("ExpenseItems");

                    b.Navigation("IncomeItems");
                });
#pragma warning restore 612, 618
        }
    }
}
