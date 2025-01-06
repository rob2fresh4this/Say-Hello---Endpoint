using Microsoft.AspNetCore.Mvc;// this allows us to add our api controller

namespace SayHello.Controllers
{
    [ApiController]// this tells the file to read the api controller
    [Route("[controller]")]// removing the api/ we nolonger need to type the api to the url
    public class SayHelloController : ControllerBase
    {
        public List<string> sayHello = new();

        public SayHelloController(){
            sayHello.Add("Say Hello");
        }


        [HttpPost]
        [Route("Addname/{nameToAdd}")]
        public List<string> Addname(string nameToAdd)
        {
            sayHello.Add("Hello " + nameToAdd);
            return sayHello;
        }     
    }
}