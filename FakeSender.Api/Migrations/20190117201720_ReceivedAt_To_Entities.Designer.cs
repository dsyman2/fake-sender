﻿// <auto-generated />
using System;
using FakeSender.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FakeSender.Api.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20190117201720_ReceivedAt_To_Entities")]
    partial class ReceivedAt_To_Entities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity("FakeSender.Api.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Balance");

                    b.Property<string>("Login")
                        .IsRequired();

                    b.Property<DateTime>("ReceivedAt");

                    b.Property<string>("Service")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("FakeSender.Api.Models.ApnsQuery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplePassTypeId");

                    b.Property<string>("PushToken");

                    b.Property<DateTime>("ReceivedAt");

                    b.HasKey("Id");

                    b.ToTable("ApnsQueryBox");
                });

            modelBuilder.Entity("FakeSender.Api.Models.Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Attachments");

                    b.Property<string>("Html");

                    b.Property<DateTime>("ReceivedAt");

                    b.Property<string>("Subject");

                    b.Property<string>("To");

                    b.HasKey("Id");

                    b.ToTable("EmailBox");
                });

            modelBuilder.Entity("FakeSender.Api.Models.Sms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Message");

                    b.Property<DateTime>("ReceivedAt");

                    b.Property<string>("To");

                    b.HasKey("Id");

                    b.ToTable("SmsBox");
                });
#pragma warning restore 612, 618
        }
    }
}
