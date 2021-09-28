using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationReact.Models;


namespace WebApplicationReact.Controllers
{
    public class ExelController:Controller 
    {
        [HttpPost]
        [Route("api/UploadFile")]
        public void Upload(NpoiRead model)
        {
           
        }
    }
}
