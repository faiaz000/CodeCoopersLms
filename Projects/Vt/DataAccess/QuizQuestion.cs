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
    
    public partial class QuizQuestion
    {
        public System.Guid Id { get; set; }
        public System.Guid QuizId { get; set; }
        public System.Guid QuestionId { get; set; }
        public int SerialNo { get; set; }
        public bool IsActive { get; set; }
    
        public virtual Question Question { get; set; }
        public virtual Quiz Quiz { get; set; }
    }
}
