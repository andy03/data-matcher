
using DataMacher.apb.Data;
using FluentNHibernate.Mapping;

namespace DataMacher.apb.Maps
{
    class ActMap : ClassMap<Act>
    {
        public ActMap()
        {
            //Table used to store data
            Table("act");

            // The primary key
            Id(x => x.Id_act)
            .Not.Nullable()
            .GeneratedBy.Assigned()
            .Unique();

            // Our simple field, FluentNHibernate knows
            // how they go together because the field and
            // column are named the same.
            Map(x => x.Tip_act)
            .Not.Nullable();
            Map(x => x.Data)
            .Not.Nullable();

            References(x => x.Stare, "id_stare")
            .Not.Nullable();

            //References(x => x.Situatie, "id_situatie")
            //.Not.Nullable();

        }
    }
}
