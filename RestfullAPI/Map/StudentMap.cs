using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentsRestfullAPI.DB;

namespace StudentsRestfullAPI.Map
{
    public class StudentMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable(nameof(Student));   
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FName)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(x => x.FName)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
