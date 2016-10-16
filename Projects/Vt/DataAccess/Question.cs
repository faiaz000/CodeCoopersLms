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
    
    public partial class Question
    {
        public Question()
        {
            this.Options = new HashSet<Option>();
            this.QuizQuestions = new HashSet<QuizQuestion>();
            this.TraineeQuizAnswerHistories = new HashSet<TraineeQuizAnswerHistory>();
        }
    
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime Changed { get; set; }
        public int Type { get; set; }
    
        public virtual ICollection<Option> Options { get; set; }
        public virtual ICollection<QuizQuestion> QuizQuestions { get; set; }
        public virtual ICollection<TraineeQuizAnswerHistory> TraineeQuizAnswerHistories { get; set; }
    }
}
