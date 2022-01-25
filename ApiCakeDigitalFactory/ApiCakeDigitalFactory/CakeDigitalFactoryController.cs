using ApiCakeDigitalFactory.Models;
using HostManager.Backend.Helpers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HostManager.Backend.Features
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CakeDigitalFactoryController : ControllerBase
    {
        private readonly CakeFactoryAppService _CakeFactoryAppService;
        public CakeDigitalFactoryController(CakeFactoryAppService CakeFactoryAppService)
        {
            _CakeFactoryAppService = CakeFactoryAppService;
        }

        [HttpGet]
        [Route("login/{user}")]
        public ActionResult getLoginValidation(string user, string password)
        {
            Response response = _CakeFactoryAppService.ValidateLogin(user, password);
            return Ok(response);
        }

        [HttpPost]
        [Route("create-user")]
        public ActionResult createUser(Usuario request)
        {
            Response response = _CakeFactoryAppService.CreateUser(request);
            return Ok(response);
        }

        [HttpPost]
        [Route("create-producto")]
        public ActionResult createProduct(Producto request)
        {
            Response response = _CakeFactoryAppService.CreateProduct(request);
            return Ok(response);
        }

        [HttpPost]
        [Route("create-detalle")]
        public ActionResult createDetails(Detalle request)
        {
            Response response = _CakeFactoryAppService.CreateDetail(request);
            return Ok(response);
        }

    }
}
