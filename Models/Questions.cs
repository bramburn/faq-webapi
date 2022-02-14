using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FAQApi.Models;

[Table("questions")]
public class Questions
{
    [Column("id")]
    public int QuestionID { get; set; }
    [Column("question")]
    public string Question { get; set; } = null!;

    public DateTime DateCreated { get; set; }
    public virtual List<Answers> Answers { get; set; } = null!;
}

