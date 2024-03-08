using Delivery.User.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SistemaUsuarios.Api.Models;
using SistemaUsuarios.Data.Entities;
using SistemaUsuarios.Data.Helpers;
using SistemaUsuarios.Data.Repositories;

namespace Delivery.User.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetUserController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(List<GetUserModel>), 200)]
        public IActionResult GetUserById(GetUserModel model)
        {
            try
            {
                var usuarioRepository = new UsuarioRepository();
                var usuario = new Usuario();

                if (usuarioRepository.GetById(model.Id) != null)
                {
                    usuario = usuarioRepository.GetById(model.Id);  
                }

                return StatusCode(200, usuario);

            }
            catch (Exception e)
            {
                return StatusCode(500, new { mensagem = e.Message });
            }
        }
    }
}
