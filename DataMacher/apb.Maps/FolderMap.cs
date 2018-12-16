using DataMacher.apb.Data;
using FluentNHibernate.Mapping;

namespace DataMacher.apb.Maps
{
    class FolderMap : ClassMap<Folder>
    {
        public FolderMap()
        {
            //Table used to store data
            Table("dosar");

            // The primary key
            Id(x => x.Id_dosar)
            .Not.Nullable()
            .GeneratedBy.Assigned()
            .Unique();

            // Our simple field, FluentNHibernate knows
            // how they go together because the field and
            // column are named the same.
            Map(x => x.Cod_value_a)
            .Not.Nullable();

            Map(x => x.Cod_value_b)
            .Not.Nullable();

             Map(x => x.Cod_value_c)
            .Not.Nullable();

            Map(x => x.Cod_value_d)
            .Not.Nullable();

            Map(x => x.Cod_value)
            .Not.Nullable();

            Map(x => x.Nume_titular)
            .Not.Nullable();

            Map(x => x.Nume_client)
            .Not.Nullable();

            References(x => x.Instanta, "id_instanta")
            .Not.Nullable();

            References(x => x.Act, "id_act")
            .Not.Nullable();

        }
    }
}
