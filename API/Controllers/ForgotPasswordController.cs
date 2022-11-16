using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Authorize]
    public  class ForgotPasswordController:BaseApiController
    {
        public ActionResult ForgotPassword()
        {
            

            return Ok("Admins or moderators can see this");
        }
    }
}
