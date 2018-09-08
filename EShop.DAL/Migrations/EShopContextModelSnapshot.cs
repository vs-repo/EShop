﻿// <auto-generated />
using ApplicationCore.Entities.Attributes;
using EShop.Infrastructure.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(EShopContext))]
    partial class EShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApplicationCore.Entities.Attributes.AdditionalInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("IntValue");

                    b.Property<int?>("ProductAttributeId");

                    b.Property<int?>("ProductAttributeValueId");

                    b.Property<int?>("ProductId");

                    b.Property<string>("StringValue");

                    b.HasKey("Id");

                    b.HasIndex("ProductAttributeId");

                    b.HasIndex("ProductAttributeValueId");

                    b.HasIndex("ProductId");

                    b.ToTable("AdditionalInformations");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Attributes.ProductAttribute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("ValueType");

                    b.HasKey("Id");

                    b.ToTable("ProductAttributes");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Attributes.ProductAttributeValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ProductAttributeId");

                    b.Property<string>("ValueString");

                    b.HasKey("Id");

                    b.HasIndex("ProductAttributeId");

                    b.ToTable("ProductAttributeValues");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("Price");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Attributes.AdditionalInformation", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Attributes.ProductAttribute", "ProductAttribute")
                        .WithMany()
                        .HasForeignKey("ProductAttributeId");

                    b.HasOne("ApplicationCore.Entities.Attributes.ProductAttributeValue", "ProductAttributeValue")
                        .WithMany()
                        .HasForeignKey("ProductAttributeValueId");

                    b.HasOne("ApplicationCore.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Attributes.ProductAttributeValue", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Attributes.ProductAttribute", "ProductAttribute")
                        .WithMany()
                        .HasForeignKey("ProductAttributeId");
                });
#pragma warning restore 612, 618
        }
    }
}
