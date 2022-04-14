﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using fishfirmtask4;

#nullable disable

namespace fishfirmtask4.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FishermanTeam", b =>
                {
                    b.Property<int>("FishermenId")
                        .HasColumnType("int");

                    b.Property<int>("TeamsId")
                        .HasColumnType("int");

                    b.HasKey("FishermenId", "TeamsId");

                    b.HasIndex("TeamsId");

                    b.ToTable("FishermanTeam");
                });

            modelBuilder.Entity("fishfirmtask4.Boat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateConstruct")
                        .HasColumnType("datetime2");

                    b.Property<int>("Displacement")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Type")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Boats");
                });

            modelBuilder.Entity("fishfirmtask4.Catch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FishId")
                        .HasColumnType("int");

                    b.Property<int>("VisitFishPlaceId")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FishId");

                    b.HasIndex("VisitFishPlaceId");

                    b.ToTable("Catches");
                });

            modelBuilder.Entity("fishfirmtask4.Fish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Kind")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Fish");
                });

            modelBuilder.Entity("fishfirmtask4.Fisherman", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Position")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Fishermen");
                });

            modelBuilder.Entity("fishfirmtask4.FishingOut", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BoatId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateRelease")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateReturn")
                        .HasColumnType("datetime2");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BoatId");

                    b.HasIndex("TeamId");

                    b.ToTable("FishingOuts");
                });

            modelBuilder.Entity("fishfirmtask4.FishPlace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("FishPlaces");
                });

            modelBuilder.Entity("fishfirmtask4.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("fishfirmtask4.VisitFishPlace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOut")
                        .HasColumnType("datetime2");

                    b.Property<int>("FishPlaceId")
                        .HasColumnType("int");

                    b.Property<int>("FishingOutId")
                        .HasColumnType("int");

                    b.Property<int>("Quality")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FishPlaceId");

                    b.HasIndex("FishingOutId");

                    b.ToTable("VisitFishPlaces");
                });

            modelBuilder.Entity("FishermanTeam", b =>
                {
                    b.HasOne("fishfirmtask4.Fisherman", null)
                        .WithMany()
                        .HasForeignKey("FishermenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fishfirmtask4.Team", null)
                        .WithMany()
                        .HasForeignKey("TeamsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("fishfirmtask4.Catch", b =>
                {
                    b.HasOne("fishfirmtask4.Fish", "Fish")
                        .WithMany("Catches")
                        .HasForeignKey("FishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fishfirmtask4.VisitFishPlace", "VisitFishPlace")
                        .WithMany("Catches")
                        .HasForeignKey("VisitFishPlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fish");

                    b.Navigation("VisitFishPlace");
                });

            modelBuilder.Entity("fishfirmtask4.FishingOut", b =>
                {
                    b.HasOne("fishfirmtask4.Boat", "Boat")
                        .WithMany("FishingOuts")
                        .HasForeignKey("BoatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fishfirmtask4.Team", "Team")
                        .WithMany("FishingOuts")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Boat");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("fishfirmtask4.VisitFishPlace", b =>
                {
                    b.HasOne("fishfirmtask4.FishPlace", "FishPlace")
                        .WithMany("VisitFishPlaces")
                        .HasForeignKey("FishPlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fishfirmtask4.FishingOut", "FishingOut")
                        .WithMany("VisitFishPlaces")
                        .HasForeignKey("FishingOutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FishPlace");

                    b.Navigation("FishingOut");
                });

            modelBuilder.Entity("fishfirmtask4.Boat", b =>
                {
                    b.Navigation("FishingOuts");
                });

            modelBuilder.Entity("fishfirmtask4.Fish", b =>
                {
                    b.Navigation("Catches");
                });

            modelBuilder.Entity("fishfirmtask4.FishingOut", b =>
                {
                    b.Navigation("VisitFishPlaces");
                });

            modelBuilder.Entity("fishfirmtask4.FishPlace", b =>
                {
                    b.Navigation("VisitFishPlaces");
                });

            modelBuilder.Entity("fishfirmtask4.Team", b =>
                {
                    b.Navigation("FishingOuts");
                });

            modelBuilder.Entity("fishfirmtask4.VisitFishPlace", b =>
                {
                    b.Navigation("Catches");
                });
#pragma warning restore 612, 618
        }
    }
}
