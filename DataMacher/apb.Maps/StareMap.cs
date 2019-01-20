using DataMacher.apb.Data;
using FluentNHibernate.Mapping;

namespace DataMacher.apb.Maps
{
    class StareMap : ClassMap<Stare>
    {
        public StareMap()
        {
            //Table used to store data
            Table("stare");

            // The primary key
            Id(x => x.Id_stare)
            .Not.Nullable()
            .Unique();

            // Our simple field, FluentNHibernate knows
            // how they go together because the field and
            // column are named the same.
            References(x => x.Instanta, "id_instanta")
            .Not.LazyLoad()
            .Not.Nullable();

            Map(x => x.Nume_intrebare)
            .Not.Nullable();

            Map(x => x.Data_intrebare)
            .Not.Nullable();

            Map(x => x.Adresa)
            .Not.Nullable();

            Map(x => x.Nume_avct)
            .Not.Nullable();

            Map(x => x.Data_fotocopiat)
            .Not.Nullable();

            Map(x => x.Nume_jdctr)
            .Not.Nullable();

        }
    }
}
