using BuckleUpApi.Core.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BuckleUpApi.Data.EntityConfigurations
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Email)
            .IsRequired()
            .HasColumnType("varchar(50)");

            builder.HasIndex(u => u.Email)
            .IsUnique();

            builder.Property(u => u.PasswordHash)
                .HasColumnType("varchar(750)")
                .IsRequired();

            builder.Property(u => u.HashSalt)
                .HasColumnType("varchar(700)")
                .IsRequired();

            builder.HasOne(u => u.Student)
            .WithOne(s => s.User);

            builder.HasOne(u => u.Teacher)
            .WithOne(t => t.User);

            builder.Property(u => u.RowVersion)
                .IsRowVersion();

        }
    }
}