﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QL_SinhVien.Data;

#nullable disable

namespace QL_SinhVien.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230528033655_Create_Table_QuanLySV")]
    partial class Create_Table_QuanLySV
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("QL_SinhVien.Models.Khoa", b =>
                {
                    b.Property<string>("MaKhoa")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenKhoa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaKhoa");

                    b.ToTable("Khoa");
                });

            modelBuilder.Entity("QL_SinhVien.Models.Lop", b =>
                {
                    b.Property<string>("MaLop")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenLop")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaLop");

                    b.ToTable("Lop");
                });

            modelBuilder.Entity("QL_SinhVien.Models.QuanLySV", b =>
                {
                    b.Property<string>("MaSV")
                        .HasColumnType("TEXT");

                    b.Property<string>("NgaySinh")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenKhoa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenLop")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenSV")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaSV");

                    b.HasIndex("TenKhoa");

                    b.HasIndex("TenLop");

                    b.ToTable("QuanLySV");
                });

            modelBuilder.Entity("QL_SinhVien.Models.QuanLySV", b =>
                {
                    b.HasOne("QL_SinhVien.Models.Khoa", "Khoa")
                        .WithMany()
                        .HasForeignKey("TenKhoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QL_SinhVien.Models.Lop", "Lop")
                        .WithMany()
                        .HasForeignKey("TenLop")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Khoa");

                    b.Navigation("Lop");
                });
#pragma warning restore 612, 618
        }
    }
}
