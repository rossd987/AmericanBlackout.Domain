﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AmericanBlackout.Domain.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ABEntities : DbContext
    {
        public ABEntities()
            : base("name=ABEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<ItemAvailability> ItemAvailabilities { get; set; }
        public virtual DbSet<MusicAlbum> MusicAlbums { get; set; }
        public virtual DbSet<MusicEvent> MusicEvents { get; set; }
        public virtual DbSet<MusicGroup> MusicGroups { get; set; }
        public virtual DbSet<MusicRecording> MusicRecordings { get; set; }
        public virtual DbSet<Offer> Offers { get; set; }
        public virtual DbSet<OrganizationRole> OrganizationRoles { get; set; }
        public virtual DbSet<Place> Places { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<URL> URLs { get; set; }
        public virtual DbSet<VideoObject> VideoObjects { get; set; }
    }
}
