﻿// <auto-generated />
using depot;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace test.Migrations
{
    [DbContext(typeof(DepotContext))]
    [Migration("20180213045322_fix_relations_v2")]
    partial class fix_relations_v2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("depot.Address", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedAt");

                    b.Property<int?>("CreatedByID");

                    b.Property<bool>("IsDeleted");

                    b.Property<double>("Latitude");

                    b.Property<string>("Locality");

                    b.Property<string>("Location");

                    b.Property<double>("Longitude");

                    b.Property<int>("UpdatedAt");

                    b.Property<int?>("UpdatedByID");

                    b.HasKey("ID");

                    b.HasIndex("CreatedByID");

                    b.HasIndex("UpdatedByID");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("depot.Contact", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AddressID");

                    b.Property<int>("CreatedAt");

                    b.Property<int?>("CreatedByID");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Phone");

                    b.Property<int>("UpdatedAt");

                    b.Property<int?>("UpdatedByID");

                    b.HasKey("ID");

                    b.HasIndex("AddressID");

                    b.HasIndex("CreatedByID");

                    b.HasIndex("UpdatedByID");

                    b.ToTable("Contact");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Contact");
                });

            modelBuilder.Entity("depot.ModelFile", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedAt");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("UpdatedAt");

                    b.HasKey("ID");

                    b.ToTable("ModelFile");
                });

            modelBuilder.Entity("depot.PartProducer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedAt");

                    b.Property<int?>("CreatedByID");

                    b.Property<bool>("IsDeleted");

                    b.Property<int?>("LogoID");

                    b.Property<string>("Name");

                    b.Property<int?>("SeoParameterId");

                    b.Property<string>("Site");

                    b.Property<int>("UpdatedAt");

                    b.Property<int?>("UpdatedByID");

                    b.HasKey("ID");

                    b.HasIndex("CreatedByID");

                    b.HasIndex("LogoID");

                    b.HasIndex("SeoParameterId");

                    b.HasIndex("UpdatedByID");

                    b.ToTable("PartProducer");
                });

            modelBuilder.Entity("depot.PartsSupplier", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedAt");

                    b.Property<string>("Email");

                    b.Property<string>("INN");

                    b.Property<bool>("IsDeleted");

                    b.Property<int?>("LogoID");

                    b.Property<string>("Name");

                    b.Property<string>("SearchName");

                    b.Property<int?>("SeoParameterId");

                    b.Property<string>("Site");

                    b.Property<int>("UpdatedAt");

                    b.HasKey("ID");

                    b.HasIndex("LogoID");

                    b.HasIndex("SeoParameterId");

                    b.ToTable("PartsSupplier");
                });

            modelBuilder.Entity("depot.ProducerCatalogItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedAt");

                    b.Property<string>("EnName");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ProducerCode");

                    b.Property<string>("ProducerCodeTrimmed")
                        .IsRequired();

                    b.Property<int?>("ProducerId")
                        .IsRequired();

                    b.Property<string>("RuName");

                    b.Property<int?>("SeoParameterId");

                    b.Property<int>("StatisticCounter");

                    b.Property<int>("UpdatedAt");

                    b.HasKey("ID");

                    b.HasAlternateKey("ProducerId", "ProducerCodeTrimmed");

                    b.HasIndex("ProducerCodeTrimmed");

                    b.HasIndex("SeoParameterId");

                    b.ToTable("ProducerCatalogItem");
                });

            modelBuilder.Entity("depot.ProducerToProducer", b =>
                {
                    b.Property<int>("FromId");

                    b.Property<int>("ToId");

                    b.HasKey("FromId", "ToId");

                    b.HasIndex("ToId");

                    b.ToTable("ProducerToProducer");
                });

            modelBuilder.Entity("depot.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("depot.SalePoint", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AddressID");

                    b.Property<int>("CreatedAt");

                    b.Property<int?>("CreatedByID");

                    b.Property<string>("DeliveryMethod");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int?>("PartsSupplierID");

                    b.Property<string>("Phone");

                    b.Property<int>("UpdatedAt");

                    b.Property<int?>("UpdatedByID");

                    b.HasKey("ID");

                    b.HasIndex("AddressID");

                    b.HasIndex("CreatedByID");

                    b.HasIndex("PartsSupplierID");

                    b.HasIndex("UpdatedByID");

                    b.ToTable("SalePoint");
                });

            modelBuilder.Entity("depot.SeoParameter", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedAt");

                    b.Property<int?>("CreatedByID");

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("UpdatedAt");

                    b.Property<int?>("UpdatedByID");

                    b.HasKey("ID");

                    b.HasIndex("CreatedByID");

                    b.HasIndex("UpdatedByID");

                    b.ToTable("SeoParameter");
                });

            modelBuilder.Entity("depot.SupplierPriceItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Count");

                    b.Property<int>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<bool>("IsAvailable");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("LastUploadedUpdated");

                    b.Property<string>("Name");

                    b.Property<int?>("PartsSupplierId")
                        .IsRequired();

                    b.Property<decimal>("Price");

                    b.Property<decimal>("PriceEu");

                    b.Property<decimal>("PriceUsd");

                    b.Property<string>("ProducerCode");

                    b.Property<string>("ProducerCodeTrimmed")
                        .IsRequired();

                    b.Property<int?>("ProducerId")
                        .IsRequired();

                    b.Property<string>("ProducerName");

                    b.Property<int>("Status");

                    b.Property<int>("UpdatedAt");

                    b.HasKey("ID");

                    b.HasAlternateKey("PartsSupplierId", "ProducerId", "ProducerCodeTrimmed")
                        .HasName("AK_SupplierPriceItem_PartsSupId_ProdId_ProdCodeTr");

                    b.HasIndex("ProducerCodeTrimmed");

                    b.HasIndex("ProducerId");

                    b.ToTable("SupplierPriceItem");
                });

            modelBuilder.Entity("depot.SupplierWarehouse", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AddressID");

                    b.Property<int>("CreatedAt");

                    b.Property<int?>("CreatedByID");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("IdForProducer");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.Property<int>("SupplierId");

                    b.Property<int>("UpdatedAt");

                    b.Property<int?>("UpdatedByID");

                    b.HasKey("ID");

                    b.HasIndex("AddressID");

                    b.HasIndex("CreatedByID");

                    b.HasIndex("SupplierId");

                    b.HasIndex("UpdatedByID");

                    b.ToTable("SupplierWarehouse");
                });

            modelBuilder.Entity("depot.TimeWork", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<int?>("SalePointID");

                    b.Property<int>("UpdatedAt");

                    b.HasKey("ID");

                    b.HasIndex("SalePointID");

                    b.ToTable("TimeWork");
                });

            modelBuilder.Entity("depot.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedAt");

                    b.Property<string>("Email");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Login");

                    b.Property<int?>("PartsSupplierID");

                    b.Property<string>("Password");

                    b.Property<int?>("RoleId");

                    b.Property<int>("UpdatedAt");

                    b.HasKey("ID");

                    b.HasIndex("PartsSupplierID");

                    b.HasIndex("RoleId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("depot.SupplierContact", b =>
                {
                    b.HasBaseType("depot.Contact");

                    b.Property<int?>("PartsSupplierID");

                    b.HasIndex("PartsSupplierID");

                    b.ToTable("SupplierContact");

                    b.HasDiscriminator().HasValue("SupplierContact");
                });

            modelBuilder.Entity("depot.WarehouseContact", b =>
                {
                    b.HasBaseType("depot.Contact");

                    b.Property<int?>("SupplierWarehouseID");

                    b.HasIndex("SupplierWarehouseID");

                    b.ToTable("WarehouseContact");

                    b.HasDiscriminator().HasValue("WarehouseContact");
                });

            modelBuilder.Entity("depot.Address", b =>
                {
                    b.HasOne("depot.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByID");

                    b.HasOne("depot.User", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedByID");
                });

            modelBuilder.Entity("depot.Contact", b =>
                {
                    b.HasOne("depot.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressID");

                    b.HasOne("depot.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByID");

                    b.HasOne("depot.User", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedByID");
                });

            modelBuilder.Entity("depot.PartProducer", b =>
                {
                    b.HasOne("depot.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByID");

                    b.HasOne("depot.ModelFile", "Logo")
                        .WithMany()
                        .HasForeignKey("LogoID");

                    b.HasOne("depot.SeoParameter", "SeoParameter")
                        .WithMany()
                        .HasForeignKey("SeoParameterId");

                    b.HasOne("depot.User", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedByID");
                });

            modelBuilder.Entity("depot.PartsSupplier", b =>
                {
                    b.HasOne("depot.ModelFile", "Logo")
                        .WithMany()
                        .HasForeignKey("LogoID");

                    b.HasOne("depot.SeoParameter", "SeoParameter")
                        .WithMany()
                        .HasForeignKey("SeoParameterId");
                });

            modelBuilder.Entity("depot.ProducerCatalogItem", b =>
                {
                    b.HasOne("depot.PartProducer", "Producer")
                        .WithMany()
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("depot.SeoParameter", "SeoParameter")
                        .WithMany()
                        .HasForeignKey("SeoParameterId");
                });

            modelBuilder.Entity("depot.ProducerToProducer", b =>
                {
                    b.HasOne("depot.PartProducer", "To")
                        .WithMany("SynonymsTo")
                        .HasForeignKey("FromId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("depot.PartProducer", "From")
                        .WithMany("SynonymsFrom")
                        .HasForeignKey("ToId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("depot.SalePoint", b =>
                {
                    b.HasOne("depot.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressID");

                    b.HasOne("depot.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByID");

                    b.HasOne("depot.PartsSupplier")
                        .WithMany("SalePoints")
                        .HasForeignKey("PartsSupplierID");

                    b.HasOne("depot.User", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedByID");
                });

            modelBuilder.Entity("depot.SeoParameter", b =>
                {
                    b.HasOne("depot.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByID");

                    b.HasOne("depot.User", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedByID");
                });

            modelBuilder.Entity("depot.SupplierPriceItem", b =>
                {
                    b.HasOne("depot.PartsSupplier", "PartsSupplier")
                        .WithMany()
                        .HasForeignKey("PartsSupplierId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("depot.PartProducer", "Producer")
                        .WithMany()
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("depot.SupplierWarehouse", b =>
                {
                    b.HasOne("depot.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressID");

                    b.HasOne("depot.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByID");

                    b.HasOne("depot.PartsSupplier", "Supplier")
                        .WithMany("Warehouses")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("depot.User", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedByID");
                });

            modelBuilder.Entity("depot.TimeWork", b =>
                {
                    b.HasOne("depot.SalePoint")
                        .WithMany("TimeWorks")
                        .HasForeignKey("SalePointID");
                });

            modelBuilder.Entity("depot.User", b =>
                {
                    b.HasOne("depot.PartsSupplier", "PartsSupplier")
                        .WithMany("Users")
                        .HasForeignKey("PartsSupplierID");

                    b.HasOne("depot.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("depot.SupplierContact", b =>
                {
                    b.HasOne("depot.PartsSupplier")
                        .WithMany("Contacts")
                        .HasForeignKey("PartsSupplierID");
                });

            modelBuilder.Entity("depot.WarehouseContact", b =>
                {
                    b.HasOne("depot.SupplierWarehouse")
                        .WithMany("Contacts")
                        .HasForeignKey("SupplierWarehouseID");
                });
#pragma warning restore 612, 618
        }
    }
}
