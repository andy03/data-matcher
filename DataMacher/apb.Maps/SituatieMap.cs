using DataMacher.apb.Data;
using FluentNHibernate.Mapping;
using System;

namespace DataMacher.apb.Maps
{
    class SituatieMap : ClassMap<Situatie>
    {
        public SituatieMap()
        {
            {
                //Table used to store data
                Table("situatie");

                // The primary key
                Id(x => x.Id_situatie)
                .Not.Nullable()
                .GeneratedBy.Assigned()
                .Unique();

                // Our simple field, FluentNHibernate knows
                // how they go together because the field and
                // column are named the same.
                Map(x => x.Nume_situatie)
                .Not.Nullable();

                Map(x => x.Nr_zile_ramase)
                .Not.Nullable();

                Map(x => x.Descriere)
                .Nullable();
            }
        }
    }
}
