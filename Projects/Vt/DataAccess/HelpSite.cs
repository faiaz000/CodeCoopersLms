//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class HelpSite
    {
        public HelpSite()
        {
            this.ContentHelpSites = new HashSet<ContentHelpSite>();
        }
    
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Tags { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime Changed { get; set; }
    
        public virtual ICollection<ContentHelpSite> ContentHelpSites { get; set; }
    }
}
