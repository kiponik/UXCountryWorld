﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UXCountryWorld
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class LocalDBWorldCountryEntities1 : DbContext
    {
        public LocalDBWorldCountryEntities1()
            : base("name=LocalDBWorldCountryEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<RegionPopulation_Result> RegionPopulation()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RegionPopulation_Result>("RegionPopulation");
        }
    }
}
