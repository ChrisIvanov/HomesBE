﻿// <auto-generated />
using System;
using BuildingMarket.Properties.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BuildingMarket.Properties.Infrastructure.Migrations
{
    [DbContext(typeof(PropertiesDbContext))]
    partial class PropertiesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BuildingMarket.Properties.Domain.Entities.AdditionalUserData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .HasMaxLength(255)
                        .HasColumnType("character varying")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasMaxLength(255)
                        .HasColumnType("character varying")
                        .HasColumnName("last_name");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15)
                        .HasColumnType("character varying")
                        .HasColumnName("phone_number");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.ToTable("AdditionalData", "security", t =>
                        {
                            t.ExcludeFromMigrations();
                        });
                });

            modelBuilder.Entity("BuildingMarket.Properties.Domain.Entities.BuildingType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("character varying")
                        .HasColumnName("building_type");

                    b.HasKey("Id");

                    b.ToTable("BuildingType", "properties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Тухла"
                        },
                        new
                        {
                            Id = 2,
                            Description = "ЕПК"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Панел"
                        });
                });

            modelBuilder.Entity("BuildingMarket.Properties.Domain.Entities.Exposure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Exposures");
                });

            modelBuilder.Entity("BuildingMarket.Properties.Domain.Entities.Finish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("character varying")
                        .HasColumnName("finish_type");

                    b.HasKey("Id");

                    b.ToTable("Finish", "properties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Акт 16"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Акт 15"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Акт 14"
                        },
                        new
                        {
                            Id = 4,
                            Description = "В Строеж"
                        },
                        new
                        {
                            Id = 5,
                            Description = "На Зелено"
                        });
                });

            modelBuilder.Entity("BuildingMarket.Properties.Domain.Entities.Furnishment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("character varying")
                        .HasColumnName("furnishment_type");

                    b.HasKey("Id");

                    b.ToTable("Furnishment", "properties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Необзаведен"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Обзаведен"
                        },
                        new
                        {
                            Id = 3,
                            Description = "До ключ"
                        });
                });

            modelBuilder.Entity("BuildingMarket.Properties.Domain.Entities.Garage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("character varying")
                        .HasColumnName("garage_type");

                    b.HasKey("Id");

                    b.ToTable("Garage", "properties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Без"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Включен в цената"
                        },
                        new
                        {
                            Id = 3,
                            Description = "С възможност"
                        });
                });

            modelBuilder.Entity("BuildingMarket.Properties.Domain.Entities.Heating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("character varying")
                        .HasColumnName("heating_type");

                    b.HasKey("Id");

                    b.ToTable("Heating", "properties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Без"
                        },
                        new
                        {
                            Id = 2,
                            Description = "ТЕЦ"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Електричество"
                        });
                });

            modelBuilder.Entity("BuildingMarket.Properties.Domain.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageURL")
                        .HasColumnType("text")
                        .HasColumnName("image_url");

                    b.Property<int>("PropertyId")
                        .HasColumnType("integer")
                        .HasColumnName("property_id");

                    b.HasKey("Id");

                    b.ToTable("Images", "properties", t =>
                        {
                            t.ExcludeFromMigrations();
                        });
                });

            modelBuilder.Entity("BuildingMarket.Properties.Domain.Entities.Neighborhood", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("character varying")
                        .HasColumnName("region");

                    b.Property<string>("Region")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Neighbourhoods", "properties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Банишора",
                            Region = "Север"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Белите брези",
                            Region = "Юг"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Бенковски",
                            Region = "Север"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Борово",
                            Region = "Юг"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Бояна",
                            Region = "Юг"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Бъкстон",
                            Region = "Юг"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Витоша",
                            Region = "Юг"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Гевгелийски квартал",
                            Region = "Запад"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Гео Милев",
                            Region = "Изток"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Гоце Делчев",
                            Region = "Юг"
                        },
                        new
                        {
                            Id = 12,
                            Description = "Дианабад",
                            Region = "Юг"
                        },
                        new
                        {
                            Id = 13,
                            Description = "Драгалевци",
                            Region = "Юг"
                        },
                        new
                        {
                            Id = 14,
                            Description = "Дружба",
                            Region = "Изток"
                        },
                        new
                        {
                            Id = 15,
                            Description = "Дървеница",
                            Region = "Юг"
                        },
                        new
                        {
                            Id = 16,
                            Description = "Западен парк",
                            Region = "Запад"
                        },
                        new
                        {
                            Id = 17,
                            Description = "Захарна фабрика",
                            Region = "Север"
                        },
                        new
                        {
                            Id = 18,
                            Description = "Иван Вазов",
                            Region = "Юг"
                        },
                        new
                        {
                            Id = 19,
                            Description = "Изгрев",
                            Region = "Юг"
                        },
                        new
                        {
                            Id = 20,
                            Description = "Изток",
                            Region = "Изток"
                        },
                        new
                        {
                            Id = 21,
                            Description = "Илинден",
                            Region = "Север"
                        },
                        new
                        {
                            Id = 22,
                            Description = "Илиянци",
                            Region = "Север"
                        },
                        new
                        {
                            Id = 23,
                            Description = "Княжево",
                            Region = "Юг"
                        },
                        new
                        {
                            Id = 24,
                            Description = "Красна поляна",
                            Region = "Запад"
                        },
                        new
                        {
                            Id = 25,
                            Description = "Красно село",
                            Region = "Юг"
                        },
                        new
                        {
                            Id = 26,
                            Description = "Крива река",
                            Region = "Юг"
                        },
                        new
                        {
                            Id = 27,
                            Description = "Кръстова вада",
                            Region = "Юг"
                        },
                        new
                        {
                            Id = 28,
                            Description = "Лагерът",
                            Region = "Запад"
                        },
                        new
                        {
                            Id = 29,
                            Description = "Левски",
                            Region = "Изток"
                        },
                        new
                        {
                            Id = 30,
                            Description = "Лозенец",
                            Region = "Юг"
                        },
                        new
                        {
                            Id = 31,
                            Description = "Люлин",
                            Region = "Запад"
                        },
                        new
                        {
                            Id = 32,
                            Description = "Малашевци",
                            Region = "Изток"
                        },
                        new
                        {
                            Id = 33,
                            Description = "Малинова долина",
                            Region = "Юг"
                        },
                        new
                        {
                            Id = 34,
                            Description = "Манастирски ливади",
                            Region = "Юг"
                        },
                        new
                        {
                            Id = 35,
                            Description = "Младост",
                            Region = "Юг"
                        },
                        new
                        {
                            Id = 36,
                            Description = "Модерно предградие",
                            Region = "Север"
                        },
                        new
                        {
                            Id = 37,
                            Description = "Мусагеница",
                            Region = "Юг"
                        },
                        new
                        {
                            Id = 38,
                            Description = "Надежда",
                            Region = "Север"
                        },
                        new
                        {
                            Id = 39,
                            Description = "Обеля",
                            Region = "Север"
                        },
                        new
                        {
                            Id = 40,
                            Description = "Оборище",
                            Region = "Изток"
                        },
                        new
                        {
                            Id = 41,
                            Description = "Овча купел",
                            Region = "Запад"
                        },
                        new
                        {
                            Id = 42,
                            Description = "Орландовци",
                            Region = "Север"
                        },
                        new
                        {
                            Id = 43,
                            Description = "Павлово",
                            Region = "Юг"
                        },
                        new
                        {
                            Id = 44,
                            Description = "Подуяне",
                            Region = "Изток"
                        },
                        new
                        {
                            Id = 45,
                            Description = "Разсадника-Коньовица",
                            Region = "Запад"
                        },
                        new
                        {
                            Id = 46,
                            Description = "Редута",
                            Region = "Изток"
                        },
                        new
                        {
                            Id = 47,
                            Description = "Света Троица",
                            Region = "Запад"
                        },
                        new
                        {
                            Id = 48,
                            Description = "Симеоново",
                            Region = "Юг"
                        },
                        new
                        {
                            Id = 49,
                            Description = "Славия",
                            Region = "Запад"
                        },
                        new
                        {
                            Id = 50,
                            Description = "Слатина",
                            Region = "Изток"
                        },
                        new
                        {
                            Id = 51,
                            Description = "Стрелбище",
                            Region = "Юг"
                        },
                        new
                        {
                            Id = 52,
                            Description = "Студентски град",
                            Region = "Юг"
                        },
                        new
                        {
                            Id = 53,
                            Description = "Сухата река",
                            Region = "Изток"
                        },
                        new
                        {
                            Id = 54,
                            Description = "Факултета",
                            Region = "Запад"
                        },
                        new
                        {
                            Id = 55,
                            Description = "Хаджи Димитър",
                            Region = "Изток"
                        },
                        new
                        {
                            Id = 56,
                            Description = "Хиподрумът",
                            Region = "Запад"
                        },
                        new
                        {
                            Id = 57,
                            Description = "Хладилникът",
                            Region = "Юг"
                        },
                        new
                        {
                            Id = 58,
                            Description = "Христо Ботев",
                            Region = "Изток"
                        },
                        new
                        {
                            Id = 59,
                            Description = "Център",
                            Region = "Централен"
                        },
                        new
                        {
                            Id = 60,
                            Description = "Яворов",
                            Region = "Изток"
                        });
                });

            modelBuilder.Entity("BuildingMarket.Properties.Domain.Entities.NumberOfRooms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("character varying")
                        .HasColumnName("number_of_rooms_type");

                    b.HasKey("Id");

                    b.ToTable("NumberOfRoomsType", "properties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Едностаен"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Двустаен"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Тристаен"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Четиристаен"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Многостаен"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Мезонет"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Гараж"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Склад"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Таванско помещение"
                        });
                });

            modelBuilder.Entity("BuildingMarket.Properties.Domain.Entities.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("BrokerId")
                        .HasColumnType("text")
                        .HasColumnName("broker_id");

                    b.Property<string>("BuildingType")
                        .HasMaxLength(255)
                        .HasColumnType("character varying")
                        .HasColumnName("building_type");

                    b.Property<DateTime>("CreatedOnUtcTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamptz")
                        .HasDefaultValue(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc))
                        .HasColumnName("created_on_utc_time");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Exposure")
                        .HasColumnType("text");

                    b.Property<string>("Finish")
                        .HasMaxLength(255)
                        .HasColumnType("character varying")
                        .HasColumnName("finish");

                    b.Property<int>("Floor")
                        .HasColumnType("integer")
                        .HasColumnName("floor");

                    b.Property<string>("Furnishment")
                        .HasMaxLength(255)
                        .HasColumnType("character varying")
                        .HasColumnName("furnishment");

                    b.Property<string>("Garage")
                        .HasMaxLength(255)
                        .HasColumnType("character varying")
                        .HasColumnName("garage");

                    b.Property<string>("Heating")
                        .HasMaxLength(255)
                        .HasColumnType("character varying")
                        .HasColumnName("heating");

                    b.Property<string>("Neighbourhood")
                        .HasMaxLength(255)
                        .HasColumnType("character varying")
                        .HasColumnName("neighbourhood");

                    b.Property<string>("NumberOfRooms")
                        .HasMaxLength(255)
                        .HasColumnType("character varying")
                        .HasColumnName("number_of_rooms");

                    b.Property<float>("Price")
                        .HasColumnType("real")
                        .HasColumnName("price");

                    b.Property<string>("SellerId")
                        .HasColumnType("text")
                        .HasColumnName("seller_id");

                    b.Property<float>("Space")
                        .HasColumnType("real")
                        .HasColumnName("space");

                    b.Property<int>("TotalFloorsInBuilding")
                        .HasColumnType("integer")
                        .HasColumnName("total_floors_in_building");

                    b.HasKey("Id");

                    b.ToTable("Properties", "properties");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users", "security", t =>
                        {
                            t.ExcludeFromMigrations();
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
