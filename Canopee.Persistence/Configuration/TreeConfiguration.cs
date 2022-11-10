using Canopee.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Canopee.Persistence.Configuration
{
    public class TreeConfiguration : IEntityTypeConfiguration<Tree>
    {
        public void Configure(EntityTypeBuilder<Tree> builder)
        {
            //builder.HasKey(x => x.Id);
            //builder.HasData(new Tree
            //{
            //    NameFr = "Sapin baumier",
            //    NameEn = "Balsam Fir",
            //    NameLa = "Abies balsamea"
            //},
            // builder.HasData(new Tree
            // {
            //     NameFr = "Sapin baumier nain",
            //     NameEn = "Dwarf Balsam Fir",
            //     NameLa = "Abies balsamea 'Nana'"
            // }
            //));
        }
    }
}
