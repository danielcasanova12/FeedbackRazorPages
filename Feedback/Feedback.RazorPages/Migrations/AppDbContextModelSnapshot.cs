﻿// <auto-generated />
using System;
using Feedback.RazorPages.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Feedback.RazorPages.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("Feedback.RazorPages.Models.FeedbackModel", b =>
                {
                    b.Property<int?>("IdFeedback")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Avaliacao")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DataFeedback")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailCliente")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeCliente")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdFeedback");

                    b.ToTable("Eventos", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
