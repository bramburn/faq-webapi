using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace FAQApi.Models;

public class Answers
{
        [Column("id")]
        public int AnswersId { get; set; }
        [Column("answer")]
        public string Answer { get; set; } = null!;
        [Column("datecreated")]
        public DateTime dateCreated { get; set; }
        
        public virtual Questions Questions { get; set; } = null!;
}