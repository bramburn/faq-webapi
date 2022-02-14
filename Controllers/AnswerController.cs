using FAQApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FAQApi.Controllers;

[ApiController]
[Route("answer")]
public class AnswerController: ControllerBase
{
    // [HttpGet("/")]
    // public IEnumerable<Answers> index()
    // {
    //     //todo
    //     
    // }

    [HttpGet("/")]
    public ActionResult<String> index()
    {
        return "test";
    }
    
}