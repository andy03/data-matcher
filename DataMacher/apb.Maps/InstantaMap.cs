using DataMacher.apb.Data;
using FluentNHibernate.Mapping;

namespace DataMacher.apb.Maps
{
    class InstantaMap : ClassMap<Instanta>
    {
        public InstantaMap()
        {
            //Table used to store data
            Table("instanta");

            // The primary key
            Id(x => x.Id_instanta);

            // Our simple field, FluentNHibernate knows
            // how they go together because the field and
            // column are named the same.
            Map(x => x.Nume_instanta);
        }
    }
}
