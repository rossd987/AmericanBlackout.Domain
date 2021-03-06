//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class MusicGroup
    {
        public MusicGroup()
        {
            this.MusicAlbums = new HashSet<MusicAlbum>();
            this.VideoObjects = new HashSet<VideoObject>();
            this.MusicEvents = new HashSet<MusicEvent>();
            this.OrganizationRoles = new HashSet<OrganizationRole>();
            this.URLs = new HashSet<URL>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string SchemaId { get; set; }
        public Nullable<int> FoundingLocation { get; set; }
        public string Genre { get; set; }
    
        public virtual ICollection<MusicAlbum> MusicAlbums { get; set; }
        public virtual Place Place { get; set; }
        public virtual ICollection<VideoObject> VideoObjects { get; set; }
        public virtual ICollection<MusicEvent> MusicEvents { get; set; }
        public virtual ICollection<OrganizationRole> OrganizationRoles { get; set; }
        public virtual ICollection<URL> URLs { get; set; }
    }
}
