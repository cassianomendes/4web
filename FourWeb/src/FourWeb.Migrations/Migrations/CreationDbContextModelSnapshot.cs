using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FourWeb.Migrations;
using FourWeb.Business.Shop.Domain.ValueObjects;

namespace FourWeb.Migrations.Migrations
{
    [DbContext(typeof(CreationDbContext))]
    partial class CreationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FourWeb.Abstraction.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<bool>("IsAdmin");

                    b.Property<bool>("IsCustomer");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasDiscriminator<bool>("IsCustomer").HasValue(false);
                });

            modelBuilder.Entity("FourWeb.Migrations.DatabaseModel.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<int?>("CustomerId");

                    b.Property<string>("Name");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Province");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("FourWeb.Migrations.DatabaseModel.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("FourWeb.Migrations.DatabaseModel.DiscountCoupon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<decimal>("Discount");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("DiscountCoupon");
                });

            modelBuilder.Entity("FourWeb.Migrations.DatabaseModel.FeaturedShowCase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("FeaturedShowCase");
                });

            modelBuilder.Entity("FourWeb.Migrations.DatabaseModel.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("Date");

                    b.Property<int>("DiscountCouponId");

                    b.Property<int>("PaymentId");

                    b.Property<int>("PaymentMethodId");

                    b.Property<int>("ShippingId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DiscountCouponId");

                    b.HasIndex("PaymentId");

                    b.HasIndex("PaymentMethodId");

                    b.HasIndex("ShippingId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("FourWeb.Migrations.DatabaseModel.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OrderId");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<decimal>("UnitCost");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("FourWeb.Migrations.DatabaseModel.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<DateTime>("Paid");

                    b.Property<decimal>("Total");

                    b.HasKey("Id");

                    b.ToTable("Payment");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Payment");
                });

            modelBuilder.Entity("FourWeb.Migrations.DatabaseModel.PaymentMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("InterestRate");

                    b.Property<int>("Parcels");

                    b.HasKey("Id");

                    b.ToTable("PaymentMethod");
                });

            modelBuilder.Entity("FourWeb.Migrations.DatabaseModel.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<int?>("FeaturedShowCaseId");

                    b.Property<string>("Image");

                    b.Property<decimal>("Price");

                    b.Property<int?>("ProductId");

                    b.Property<int>("QuantityOnHand");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("FeaturedShowCaseId");

                    b.HasIndex("ProductId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("FourWeb.Migrations.DatabaseModel.Shipping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AddressId");

                    b.Property<decimal>("ShippingPrice");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Shipping");
                });

            modelBuilder.Entity("FourWeb.Migrations.DatabaseModel.ShoppingCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CustomerId");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("ShoppingCart");
                });

            modelBuilder.Entity("FourWeb.Migrations.DatabaseModel.ShoppingCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<int?>("ShoppingCartId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("ShoppingCartItem");
                });

            modelBuilder.Entity("FourWeb.Migrations.DatabaseModel.SpecialOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<decimal>("DiscountPercentage");

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("SpecialOffer");
                });

            modelBuilder.Entity("FourWeb.Migrations.DatabaseModel.SpecialOfferProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("ProductId");

                    b.Property<int>("SpecialOfferId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("SpecialOfferId");

                    b.ToTable("SpecialOfferProduct");
                });

            modelBuilder.Entity("FourWeb.Migrations.DatabaseModel.TechnicalDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int?>("ProductId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("TechnicalDetail");
                });

            modelBuilder.Entity("FourWeb.Migrations.DatabaseModel.Customer", b =>
                {
                    b.HasBaseType("FourWeb.Abstraction.Domain.Entities.User");

                    b.Property<string>("CreditCartNumber");

                    b.Property<string>("DocumentNumber");

                    b.Property<string>("Name");

                    b.ToTable("Customer");

                    b.HasDiscriminator().HasValue(true);
                });

            modelBuilder.Entity("FourWeb.Migrations.DatabaseModel.BankSlip", b =>
                {
                    b.HasBaseType("FourWeb.Migrations.DatabaseModel.Payment");


                    b.ToTable("BankSlip");

                    b.HasDiscriminator().HasValue("BankSlip");
                });

            modelBuilder.Entity("FourWeb.Migrations.DatabaseModel.CreditCard", b =>
                {
                    b.HasBaseType("FourWeb.Migrations.DatabaseModel.Payment");

                    b.Property<string>("CardNumber");

                    b.Property<int>("CardType");

                    b.Property<int>("ExpirationMonth");

                    b.Property<int>("ExpirationYear");

                    b.Property<string>("Name");

                    b.Property<int>("SecurityCode");

                    b.ToTable("CreditCard");

                    b.HasDiscriminator().HasValue("CreditCard");
                });

            modelBuilder.Entity("FourWeb.Migrations.DatabaseModel.Address", b =>
                {
                    b.HasOne("FourWeb.Migrations.DatabaseModel.Customer")
                        .WithMany("ShippingAddress")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("FourWeb.Migrations.DatabaseModel.Order", b =>
                {
                    b.HasOne("FourWeb.Migrations.DatabaseModel.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FourWeb.Migrations.DatabaseModel.DiscountCoupon", "DiscountCoupon")
                        .WithMany()
                        .HasForeignKey("DiscountCouponId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FourWeb.Migrations.DatabaseModel.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FourWeb.Migrations.DatabaseModel.PaymentMethod", "PaymentMethod")
                        .WithMany()
                        .HasForeignKey("PaymentMethodId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FourWeb.Migrations.DatabaseModel.Shipping", "Shipping")
                        .WithMany()
                        .HasForeignKey("ShippingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FourWeb.Migrations.DatabaseModel.OrderItem", b =>
                {
                    b.HasOne("FourWeb.Migrations.DatabaseModel.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FourWeb.Migrations.DatabaseModel.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FourWeb.Migrations.DatabaseModel.Product", b =>
                {
                    b.HasOne("FourWeb.Migrations.DatabaseModel.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FourWeb.Migrations.DatabaseModel.FeaturedShowCase")
                        .WithMany("Products")
                        .HasForeignKey("FeaturedShowCaseId");

                    b.HasOne("FourWeb.Migrations.DatabaseModel.Product")
                        .WithMany("RelatedProducts")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("FourWeb.Migrations.DatabaseModel.Shipping", b =>
                {
                    b.HasOne("FourWeb.Migrations.DatabaseModel.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");
                });

            modelBuilder.Entity("FourWeb.Migrations.DatabaseModel.ShoppingCart", b =>
                {
                    b.HasOne("FourWeb.Migrations.DatabaseModel.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("FourWeb.Migrations.DatabaseModel.ShoppingCartItem", b =>
                {
                    b.HasOne("FourWeb.Migrations.DatabaseModel.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FourWeb.Migrations.DatabaseModel.ShoppingCart")
                        .WithMany("ShoppingCartItems")
                        .HasForeignKey("ShoppingCartId");
                });

            modelBuilder.Entity("FourWeb.Migrations.DatabaseModel.SpecialOfferProduct", b =>
                {
                    b.HasOne("FourWeb.Migrations.DatabaseModel.Product", "Product")
                        .WithMany("SpecialOfferProduct")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FourWeb.Migrations.DatabaseModel.SpecialOffer", "SpecialOffer")
                        .WithMany("SpecialOfferProducts")
                        .HasForeignKey("SpecialOfferId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FourWeb.Migrations.DatabaseModel.TechnicalDetail", b =>
                {
                    b.HasOne("FourWeb.Migrations.DatabaseModel.Product")
                        .WithMany("TechnicalDetails")
                        .HasForeignKey("ProductId");
                });
        }
    }
}
