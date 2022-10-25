//Marcel Rodriguez
//10-25-22
//Asking Questions
//This controller will ask the user for a name and a time in the url and output both in a sentence.
//Peer review - Griffin Parker - This program works exactly as it should. It takes the user's name and the time they woke up through the URL
//The code looks organized and makes sense. Well Done!!
using Microsoft.AspNetCore.Mvc;

namespace RodriguezMAskingQuestionsEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class EndpointController : ControllerBase
{
    [HttpGet]
    [Route("asking/{name}/{timeAwake}")]

    public string AskingQuestions(string name, string timeAwake)
    {
        return $"Hello {name}, you woke up at {timeAwake}! Hope you got lots of rest :)";
    }
}
