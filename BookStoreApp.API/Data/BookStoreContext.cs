using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BookStoreApp.API.Data
{
    public partial class BookStoreContext : IdentityDbContext<ApiUser>
    {
        public BookStoreContext()
        {
        }

        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; } = null!;
        public virtual DbSet<Book> Books { get; set; } = null!;

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Author>(entity =>
            {
                entity.Property(e => e.Bio).HasMaxLength(250);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasIndex(e => e.Isbn, "UQ__Books__447D36EAAC4438AB")
                    .IsUnique();

                entity.Property(e => e.Image).HasMaxLength(50);

                entity.Property(e => e.Isbn)
                    .HasMaxLength(50)
                    .HasColumnName("ISBN");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Summary).HasMaxLength(250);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK_Books_ToTable");
            });

            modelBuilder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole { Name="User",NormalizedName="USER",Id= "bc0301cd-074e-47b9-b82b-574dbfa22d47" },
                    new IdentityRole { Name = "Administrator", NormalizedName = "ADMINISTRATOR", Id = "59cbc1ba-3586-49f0-9eb5-f67dc977b8d0" }

                    );
            var hasher = new PasswordHasher<ApiUser>();
            modelBuilder.Entity<ApiUser>()
                .HasData(
                    new ApiUser { Id= "871de0c6-8dbb-4e43-b4de-5c1a41c735bd",
                            Email="admin@bookstore.com",
                            NormalizedEmail="ADMINBOOKSTORE.COM",
                            UserName= "admin@bookstore.com" ,
                            NormalizedUserName= "ADMINBOOKSTORE.COM",
                            FirstName="System",
                            LastName="Admin",
                            PasswordHash=hasher.HashPassword(null,"P@ssword1")
                    },
                    new ApiUser { Id = "dd2bf4e1-2d7c-4011-985f-638bffc646dc" ,Email = "admin@bookstore.com",
                        NormalizedEmail = "ADMINBOOKSTORE.COM",
                        UserName = "user@bookstore.com",
                        NormalizedUserName = "USERBOOKSTORE.COM",
                        FirstName = "System",
                        LastName = "User",
                        PasswordHash = hasher.HashPassword(null, "P@ssword1")
                    }

                    );
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId= "bc0301cd-074e-47b9-b82b-574dbfa22d47",
                    UserId= "871de0c6-8dbb-4e43-b4de-5c1a41c735bd"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "59cbc1ba-3586-49f0-9eb5-f67dc977b8d0",
                    UserId = "dd2bf4e1-2d7c-4011-985f-638bffc646dc"
                }
                );
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
