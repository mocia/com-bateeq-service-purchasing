﻿// <auto-generated />
using Com.DanLiris.Service.Purchasing.Lib;
using Com.DanLiris.Service.Purchasing.Lib.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Com.DanLiris.Service.Purchasing.Lib.Migrations
{
    [DbContext(typeof(PurchasingDbContext))]
    [Migration("20180522071356_PurchaseRequest")]
    partial class PurchaseRequest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Com.DanLiris.Service.Purchasing.Lib.Models.Expedition.PurchasingDocumentExpedition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("BankExpenditureNoteNo")
                        .HasMaxLength(255);

                    b.Property<string>("CashierDivisionBy")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("CashierDivisionDate");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("Currency")
                        .HasMaxLength(255);

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<string>("DivisionCode")
                        .HasMaxLength(255);

                    b.Property<string>("DivisionName")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset>("DueDate");

                    b.Property<string>("FinanceDivisionBy")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("FinanceDivisionDate");

                    b.Property<string>("InvoiceNo")
                        .HasMaxLength(255);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("NotVerifiedReason")
                        .HasMaxLength(255);

                    b.Property<int>("Position");

                    b.Property<string>("SendToCashierDivisionBy")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("SendToCashierDivisionDate");

                    b.Property<string>("SendToFinanceDivisionBy")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("SendToFinanceDivisionDate");

                    b.Property<string>("SendToPurchasingDivisionBy")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("SendToPurchasingDivisionDate");

                    b.Property<string>("SendToVerificationDivisionBy")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("SendToVerificationDivisionDate");

                    b.Property<string>("SupplierCode")
                        .HasMaxLength(255);

                    b.Property<string>("SupplierName")
                        .HasMaxLength(255);

                    b.Property<double>("TotalPaid");

                    b.Property<DateTimeOffset>("UPODate");

                    b.Property<string>("UnitPaymentOrderNo")
                        .HasMaxLength(255);

                    b.Property<string>("VerificationDivisionBy")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset?>("VerificationDivisionDate");

                    b.Property<DateTimeOffset?>("VerifyDate");

                    b.HasKey("Id");

                    b.ToTable("PurchasingDocumentExpeditions");
                });

            modelBuilder.Entity("Com.DanLiris.Service.Purchasing.Lib.Models.PurchaseRequestModel.PurchaseRequest", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("BudgetCode")
                        .HasMaxLength(255);

                    b.Property<string>("BudgetId")
                        .HasMaxLength(255);

                    b.Property<string>("BudgetName")
                        .HasMaxLength(1000);

                    b.Property<string>("CategoryCode")
                        .HasMaxLength(255);

                    b.Property<string>("CategoryId")
                        .HasMaxLength(255);

                    b.Property<string>("CategoryName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<DateTimeOffset>("Date");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<string>("DivisionCode")
                        .HasMaxLength(255);

                    b.Property<string>("DivisionId")
                        .HasMaxLength(255);

                    b.Property<string>("DivisionName")
                        .HasMaxLength(1000);

                    b.Property<DateTimeOffset>("ExpectedDeliveryDate");

                    b.Property<bool>("Internal");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsPosted");

                    b.Property<bool>("IsUsed");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("No")
                        .HasMaxLength(255);

                    b.Property<string>("Remark");

                    b.Property<int>("Status");

                    b.Property<string>("UId")
                        .HasMaxLength(255);

                    b.Property<string>("UnitCode")
                        .HasMaxLength(255);

                    b.Property<string>("UnitId")
                        .HasMaxLength(255);

                    b.Property<string>("UnitName")
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.ToTable("PurchaseRequests");
                });

            modelBuilder.Entity("Com.DanLiris.Service.Purchasing.Lib.Models.PurchaseRequestModel.PurchaseRequestItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("ProductCode")
                        .HasMaxLength(255);

                    b.Property<string>("ProductId")
                        .HasMaxLength(255);

                    b.Property<string>("ProductName")
                        .HasMaxLength(4000);

                    b.Property<long>("PurchaseRequestId");

                    b.Property<long>("Quantity");

                    b.Property<string>("Remark");

                    b.Property<string>("Uom")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("PurchaseRequestId");

                    b.ToTable("PurchaseRequestItems");
                });

            modelBuilder.Entity("Com.DanLiris.Service.Purchasing.Lib.Models.PurchaseRequestModel.PurchaseRequestItem", b =>
                {
                    b.HasOne("Com.DanLiris.Service.Purchasing.Lib.Models.PurchaseRequestModel.PurchaseRequest", "PurchaseRequest")
                        .WithMany("Items")
                        .HasForeignKey("PurchaseRequestId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
