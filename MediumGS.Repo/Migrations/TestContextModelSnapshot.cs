﻿// <auto-generated />
using MediumGS.Repo.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace MediumGS.Repo.Migrations
{
    [DbContext(typeof(TestContext))]
    partial class TestContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("MediumGS.Data.Concrete.Meta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<bool?>("Deleted");

                    b.Property<string>("Name");

                    b.Property<int>("PageContentID");

                    b.HasKey("Id");

                    b.HasIndex("PageContentID");

                    b.ToTable("Meta");
                });

            modelBuilder.Entity("MediumGS.Data.Concrete.PageContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("Deleted");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("PageContent");
                });

            modelBuilder.Entity("MediumGS.Data.Concrete.Schema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("Deleted");

                    b.Property<string>("Description");

                    b.Property<string>("Headline");

                    b.Property<string>("Name");

                    b.Property<int>("PageContentID");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("PageContentID");

                    b.ToTable("Schema");
                });

            modelBuilder.Entity("MediumGS.Data.Concrete.Slot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("Deleted");

                    b.Property<string>("Html");

                    b.Property<string>("Name");

                    b.Property<int>("PageContentID");

                    b.HasKey("Id");

                    b.HasIndex("PageContentID");

                    b.ToTable("Slot");
                });

            modelBuilder.Entity("MediumGS.Data.Concrete.Meta", b =>
                {
                    b.HasOne("MediumGS.Data.Concrete.PageContent", "PageContent")
                        .WithMany("Metas")
                        .HasForeignKey("PageContentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MediumGS.Data.Concrete.Schema", b =>
                {
                    b.HasOne("MediumGS.Data.Concrete.PageContent", "PageContent")
                        .WithMany("Schemas")
                        .HasForeignKey("PageContentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MediumGS.Data.Concrete.Slot", b =>
                {
                    b.HasOne("MediumGS.Data.Concrete.PageContent", "PageContent")
                        .WithMany("Slots")
                        .HasForeignKey("PageContentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
