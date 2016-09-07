using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MediaCollectionCore.Entities;

namespace MediaCollectionCore.Migrations
{
    [DbContext(typeof(MediaDbContext))]
    partial class MediaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MediaCore.MediaType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("MediaType");
                });

            modelBuilder.Entity("MediaCore.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<int?>("MediaCategoryId");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("MediaCategoryId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MediaCore.Movie", b =>
                {
                    b.HasOne("MediaCore.MediaType", "MediaCategory")
                        .WithMany()
                        .HasForeignKey("MediaCategoryId");
                });
        }
    }
}
