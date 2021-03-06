// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using exercise5v2.DataContext;

namespace excercise5v2.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("exercise5v2.Models.MushroomModel", b =>
                {
                    b.Property<string>("ScientificName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Biome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CapShape")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommonName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GillColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hymenophore")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SporePrintColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Veil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("isPoisonous")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isPsychoactive")
                        .HasColumnType("bit");

                    b.HasKey("ScientificName");

                    b.ToTable("Shrooms");
                });
#pragma warning restore 612, 618
        }
    }
}
