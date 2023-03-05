using Microsoft.AspNetCore.Mvc;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
using API_.NET.model.account;
using System.ComponentModel.DataAnnotations;

namespace API_.NET.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
       
        // POST api/<AccountController/login>
        [HttpPost(Name = "login" )]
        public model.account.Login Post([FromBody] Login user, [FromHeader(Name = "Accept")][Required] string Accept , 
        [FromHeader(Name = "Host")][Required]   string Host  ,  [FromHeader(Name = "User-Agent")][Required] string UserAgent)
        {
            var context = HttpContext.Response;
            return API_.NET.view.Login.Login.LoginUser(context,user);
        }

      
    }
}
