﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrivateTuition.Data.Concrete.EFCore;

#nullable disable

namespace PrivateTuition.Data.Migrations
{
    [DbContext(typeof(PrivateTuitionContext))]
    [Migration("20221121173625_wmethod")]
    partial class wmethod
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("PrivateTuition.Entity.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 11, 21, 20, 36, 25, 196, DateTimeKind.Local).AddTicks(5099),
                            IsDeleted = false,
                            Name = "Lise",
                            Url = "lise"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 11, 21, 20, 36, 25, 196, DateTimeKind.Local).AddTicks(5107),
                            IsDeleted = false,
                            Name = "İlköğretim",
                            Url = "ilkogretim"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 11, 21, 20, 36, 25, 196, DateTimeKind.Local).AddTicks(5108),
                            IsDeleted = false,
                            Name = "Bilgisayar",
                            Url = "bilgisayar"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2022, 11, 21, 20, 36, 25, 196, DateTimeKind.Local).AddTicks(5108),
                            IsDeleted = false,
                            Name = "Sınava Hazırlık",
                            Url = "sınava-hazırlık"
                        });
                });

            modelBuilder.Entity("PrivateTuition.Entity.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.Property<string>("il_adi")
                        .HasColumnType("TEXT");

                    b.Property<string>("plaka_kodu")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("PrivateTuition.Entity.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<byte>("Point")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StdComment")
                        .HasColumnType("TEXT");

                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeacherId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 11, 21, 20, 36, 25, 196, DateTimeKind.Local).AddTicks(5295),
                            IsDeleted = false,
                            Point = (byte)0,
                            StdComment = "Gerçekten alanında çok başarılı ve anlaşılır bir hoca",
                            StudentId = 1,
                            TeacherId = 1,
                            Title = "Çok iyii",
                            Url = "123"
                        });
                });

            modelBuilder.Entity("PrivateTuition.Entity.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CityId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.Property<string>("ilce_adi")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("PrivateTuition.Entity.LessonRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Expectations")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ResponseTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("ShowCardId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ShowCardId");

                    b.HasIndex("StudentId");

                    b.ToTable("LessonRequests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ContactNumber = "0545-719-73-78",
                            CreatedDate = new DateTime(2022, 11, 21, 20, 36, 25, 196, DateTimeKind.Local).AddTicks(5307),
                            Expectations = "Haftada 4 saat matematik dersi",
                            IsApproved = false,
                            IsDeleted = false,
                            ShowCardId = 1,
                            StudentId = 2
                        });
                });

            modelBuilder.Entity("PrivateTuition.Entity.ShowCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CityId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("LessonPrice")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("SubjectId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeacherId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.Property<int>("WorkMethods")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("ShowCards");
                });

            modelBuilder.Entity("PrivateTuition.Entity.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AvatarUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("District")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Job")
                        .HasColumnType("TEXT");

                    b.Property<string>("Language")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mail")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "İstanbul",
                            CreatedDate = new DateTime(2022, 11, 21, 20, 36, 25, 196, DateTimeKind.Local).AddTicks(5282),
                            District = "Florya",
                            IsDeleted = false,
                            Mail = "hsnkra@gmail.com",
                            Name = "Hasan Karaoğlan",
                            Url = "hasan-karaoglan"
                        },
                        new
                        {
                            Id = 2,
                            City = "İstanbul",
                            CreatedDate = new DateTime(2022, 11, 21, 20, 36, 25, 196, DateTimeKind.Local).AddTicks(5283),
                            District = "Avcılar",
                            IsDeleted = false,
                            Mail = "ynsgny@gmail.com",
                            Name = "Yunus Güney",
                            Url = "yunus"
                        });
                });

            modelBuilder.Entity("PrivateTuition.Entity.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 11, 21, 20, 36, 25, 196, DateTimeKind.Local).AddTicks(5188),
                            IsDeleted = false,
                            Name = "Matematik",
                            Url = "matematik"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 11, 21, 20, 36, 25, 196, DateTimeKind.Local).AddTicks(5189),
                            IsDeleted = false,
                            Name = "Fizik",
                            Url = "fizik"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 11, 21, 20, 36, 25, 196, DateTimeKind.Local).AddTicks(5190),
                            IsDeleted = false,
                            Name = "Kimya",
                            Url = "kimya"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2022, 11, 21, 20, 36, 25, 196, DateTimeKind.Local).AddTicks(5190),
                            IsDeleted = false,
                            Name = "C#",
                            Url = "c#"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2022, 11, 21, 20, 36, 25, 196, DateTimeKind.Local).AddTicks(5191),
                            IsDeleted = false,
                            Name = "Javascript",
                            Url = "javascript"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2022, 11, 21, 20, 36, 25, 196, DateTimeKind.Local).AddTicks(5192),
                            IsDeleted = false,
                            Name = "KPSS",
                            Url = "kpss"
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2022, 11, 21, 20, 36, 25, 196, DateTimeKind.Local).AddTicks(5192),
                            IsDeleted = false,
                            Name = "YGS-LYS",
                            Url = "ygs-lys"
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2022, 11, 21, 20, 36, 25, 196, DateTimeKind.Local).AddTicks(5193),
                            IsDeleted = false,
                            Name = "Hayat Bilgisi",
                            Url = "hayat-bilgisi"
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2022, 11, 21, 20, 36, 25, 196, DateTimeKind.Local).AddTicks(5193),
                            IsDeleted = false,
                            Name = "İngilizce",
                            Url = "ingilizce"
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2022, 11, 21, 20, 36, 25, 196, DateTimeKind.Local).AddTicks(5194),
                            IsDeleted = false,
                            Name = "IELTS-TOEFL",
                            Url = "ielts-toefl"
                        });
                });

            modelBuilder.Entity("PrivateTuition.Entity.SubjectCategory", b =>
                {
                    b.Property<int>("SubjectId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.HasKey("SubjectId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubjectCategories");

                    b.HasData(
                        new
                        {
                            SubjectId = 1,
                            CategoryId = 1
                        },
                        new
                        {
                            SubjectId = 2,
                            CategoryId = 1
                        },
                        new
                        {
                            SubjectId = 3,
                            CategoryId = 1
                        },
                        new
                        {
                            SubjectId = 9,
                            CategoryId = 1
                        },
                        new
                        {
                            SubjectId = 1,
                            CategoryId = 2
                        },
                        new
                        {
                            SubjectId = 2,
                            CategoryId = 2
                        },
                        new
                        {
                            SubjectId = 3,
                            CategoryId = 2
                        },
                        new
                        {
                            SubjectId = 9,
                            CategoryId = 2
                        },
                        new
                        {
                            SubjectId = 8,
                            CategoryId = 2
                        },
                        new
                        {
                            SubjectId = 6,
                            CategoryId = 4
                        },
                        new
                        {
                            SubjectId = 7,
                            CategoryId = 4
                        },
                        new
                        {
                            SubjectId = 10,
                            CategoryId = 4
                        },
                        new
                        {
                            SubjectId = 4,
                            CategoryId = 3
                        },
                        new
                        {
                            SubjectId = 5,
                            CategoryId = 3
                        });
                });

            modelBuilder.Entity("PrivateTuition.Entity.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AvatarUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Certificate")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("District")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Job")
                        .HasColumnType("TEXT");

                    b.Property<string>("Language")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mail")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Professions")
                        .HasColumnType("TEXT");

                    b.Property<byte>("RatingPoint")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ResponseRange")
                        .HasColumnType("TEXT");

                    b.Property<string>("TeacherInfo")
                        .HasColumnType("TEXT");

                    b.Property<int>("TeacherStatue")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TotalLesson")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "İstanbul",
                            CreatedDate = new DateTime(2022, 11, 21, 20, 36, 25, 196, DateTimeKind.Local).AddTicks(5265),
                            District = "Avcılar",
                            IsDeleted = false,
                            Mail = "hsnkra@gmail.com",
                            Name = "Semih Karaoğlan",
                            RatingPoint = (byte)0,
                            TeacherInfo = "5 Yıl deneyimli uzman öğretmen.",
                            TeacherStatue = 2,
                            TotalLesson = 0,
                            Url = "5-yil-deneyimli-uzman"
                        },
                        new
                        {
                            Id = 2,
                            City = "İstanbul",
                            CreatedDate = new DateTime(2022, 11, 21, 20, 36, 25, 196, DateTimeKind.Local).AddTicks(5267),
                            District = "Küçükçekmece",
                            IsDeleted = false,
                            Mail = "hsnkra@gmail.com",
                            Name = "Yasin Güney",
                            RatingPoint = (byte)0,
                            TeacherInfo = "6 Yıl deneyimli uzman öğretmen ve eğitim koçu.",
                            TeacherStatue = 3,
                            TotalLesson = 0,
                            Url = "5-yil-deneyimli-uzman-ogretmen"
                        });
                });

            modelBuilder.Entity("PrivateTuition.Entity.Comment", b =>
                {
                    b.HasOne("PrivateTuition.Entity.Student", "Student")
                        .WithMany("Comments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PrivateTuition.Entity.Teacher", "Teacher")
                        .WithMany("Comments")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("PrivateTuition.Entity.District", b =>
                {
                    b.HasOne("PrivateTuition.Entity.City", "City")
                        .WithMany("ilceler")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("PrivateTuition.Entity.LessonRequest", b =>
                {
                    b.HasOne("PrivateTuition.Entity.ShowCard", "ShowCard")
                        .WithMany("Requests")
                        .HasForeignKey("ShowCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PrivateTuition.Entity.Student", "Student")
                        .WithMany("Requests")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ShowCard");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("PrivateTuition.Entity.ShowCard", b =>
                {
                    b.HasOne("PrivateTuition.Entity.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PrivateTuition.Entity.Subject", "Subject")
                        .WithMany("ShowCards")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PrivateTuition.Entity.Teacher", "Teacher")
                        .WithMany("ShowCards")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("PrivateTuition.Entity.SubjectCategory", b =>
                {
                    b.HasOne("PrivateTuition.Entity.Category", "Category")
                        .WithMany("SubjectCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PrivateTuition.Entity.Subject", "Subject")
                        .WithMany("SubjectCategories")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("PrivateTuition.Entity.Category", b =>
                {
                    b.Navigation("SubjectCategories");
                });

            modelBuilder.Entity("PrivateTuition.Entity.City", b =>
                {
                    b.Navigation("ilceler");
                });

            modelBuilder.Entity("PrivateTuition.Entity.ShowCard", b =>
                {
                    b.Navigation("Requests");
                });

            modelBuilder.Entity("PrivateTuition.Entity.Student", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Requests");
                });

            modelBuilder.Entity("PrivateTuition.Entity.Subject", b =>
                {
                    b.Navigation("ShowCards");

                    b.Navigation("SubjectCategories");
                });

            modelBuilder.Entity("PrivateTuition.Entity.Teacher", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("ShowCards");
                });
#pragma warning restore 612, 618
        }
    }
}
