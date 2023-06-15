
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Configurations
{
    public class CourseDatailConfiguration : IEntityTypeConfiguration<CourseDetail>
    {
        public void Configure(EntityTypeBuilder<CourseDetail> builder)
        {
            builder.HasKey(x => x.CourseId);

            builder.Property(x => x.CreatedDate).IsRequired();

            builder.Property(x => x.Description).HasMaxLength(150);
            builder.Property(x => x.AbsenceLimit).IsRequired();
            builder.Property(x => x.CurrentAbsence).IsRequired();

            builder.HasOne(x => x.Course)
                   .WithOne(x => x.CourseDetail)
                   .HasForeignKey<CourseDetail>(x => x.CourseId);

        }
    }
}
