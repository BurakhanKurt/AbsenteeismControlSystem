using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Entities.Models;

namespace Repositories.Seeds
{
    public class DaySeed : IEntityTypeConfiguration<Day>
    {
        public void Configure(EntityTypeBuilder<Day> builder)
        {
            builder.HasData(
                new Day { Id = 1, DayName = "Pazartesi" },
                new Day { Id = 2, DayName = "Salı" },
                new Day { Id = 3, DayName = "Çarşamba" },
                new Day { Id = 4, DayName = "Perşembe" },
                new Day { Id = 5, DayName = "Cuma" },
                new Day { Id = 6, DayName = "Cumartesi" },
                new Day { Id = 7, DayName = "Pazar" });
        }
    }
}
