// <auto-generated />
using BuildingMarket.Properties.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BuildingMarket.Properties.Infrasructure.Migrations
{
    [DbContext(typeof(PropertiesDbContext))]
    partial class PropertiesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

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

                    b.Property<string>("District")
                        .HasMaxLength(255)
                        .HasColumnType("character varying")
                        .HasColumnName("district");

                    b.Property<int>("Floor")
                        .HasColumnType("int")
                        .HasColumnName("floor");

                    b.Property<int>("NumberOfRooms")
                        .HasColumnType("int")
                        .HasColumnName("number_of_rooms");

                    b.Property<string>("SellerId")
                        .HasColumnType("text")
                        .HasColumnName("seller_id");

                    b.Property<float>("Space")
                        .HasColumnType("real")
                        .HasColumnName("space");

                    b.Property<int>("TotalFloorsInBuilding")
                        .HasColumnType("int")
                        .HasColumnName("total_floors_in_building");

                    b.Property<string>("Type")
                        .HasMaxLength(255)
                        .HasColumnType("character varying")
                        .HasColumnName("type");

                    b.HasKey("Id");

                    b.ToTable("Properties", "properties");
                });
#pragma warning restore 612, 618
        }
    }
}