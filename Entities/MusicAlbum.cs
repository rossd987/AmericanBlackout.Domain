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
    
    public partial class MusicAlbum
    {
        public MusicAlbum()
        {
            this.MusicRecordings = new HashSet<MusicRecording>();
            this.URLs = new HashSet<URL>();
        }
    
        public int Id { get; set; }
        public string SchemaId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string ProductionType { get; set; }
        public string ReleaseType { get; set; }
        public string Genre { get; set; }
        public Nullable<int> ByArtist { get; set; }
        public string UPC { get; set; }
        public Nullable<System.DateTime> ReleaseDate { get; set; }
    
        public virtual MusicGroup MusicGroup { get; set; }
        public virtual ICollection<MusicRecording> MusicRecordings { get; set; }
        public virtual ICollection<URL> URLs { get; set; }
    }
}
