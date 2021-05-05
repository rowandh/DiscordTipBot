﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TipBot.Database;

namespace TipBot.Migrations
{
    [DbContext(typeof(BotDbContext))]
    partial class BotDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity("TipBot.Database.Models.AddressModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<bool>("Used");

                    b.HasKey("Id");

                    b.ToTable("UnusedAddresses");
                });

            modelBuilder.Entity("TipBot.Database.Models.DiscordUserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Balance");

                    b.Property<string>("DepositAddress");

                    b.Property<ulong>("DiscordUserId");

                    b.Property<decimal>("LastCheckedReceivedAmountByAddress");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TipBot.Database.Models.QuizModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnswerHash");

                    b.Property<DateTime>("CreationTime");

                    b.Property<ulong>("CreatorDiscordUserId");

                    b.Property<int>("DurationMinutes");

                    b.Property<string>("Question");

                    b.Property<decimal>("Reward");

                    b.HasKey("Id");

                    b.ToTable("ActiveQuizes");
                });

            modelBuilder.Entity("TipBot.Database.Models.TipModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<DateTime>("CreationTime");

                    b.Property<ulong>("ReceiverDiscordUserId");

                    b.Property<string>("ReceiverDiscordUserName");

                    b.Property<ulong>("SenderDiscordUserId");

                    b.Property<string>("SenderDiscordUserName");

                    b.HasKey("Id");

                    b.ToTable("TipsHistory");
                });
#pragma warning restore 612, 618
        }
    }
}
