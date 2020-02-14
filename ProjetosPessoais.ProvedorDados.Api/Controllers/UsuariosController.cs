using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetosPessoais.Dominio.Model.Request.Usuario;
using ProjetosPessoais.Dominio.Model.Response.ResponseMessage;
using ProjetosPessoais.Dominio.Servicos.Interfaces.Usuario;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetosPessoais.ProvedorDados.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioServico _usuarioServico;
        public UsuariosController(IUsuarioServico usuarioServico)
        {
            _usuarioServico = usuarioServico;
        }

        [HttpGet]
        public async Task<ResponseMessage> GetAll()
        {
            return await _usuarioServico.GetAll();
        }

        [HttpGet("{id}", Name = "GetUsuario")]
        public IActionResult GetById(long id)
        {
            var usuario = _usuarioServico.Find(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return new ObjectResult(usuario);
        }

        [AllowAnonymous]
        [HttpPost("autenticar")]
        public IActionResult Autenticar([FromBody] UsuarioModel usuario)
        {
            var _usuario = _usuarioServico.Autenticar(usuario.Nome, usuario.Senha);

            if (_usuario == null)
                return Unauthorized();

            return new ObjectResult(_usuario);
        }

        [HttpPost]
        public IActionResult Create([FromBody] UsuarioModel usuario)
        {
            if (usuario == null)
            {
                return BadRequest();
            }

            _usuarioServico.Add(usuario);

            return CreatedAtRoute("GetUsuario", new { id = usuario.UsuarioId }, usuario);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] UsuarioModel usuario)
        {
            if (usuario == null || usuario.UsuarioId != id)
            {
                return BadRequest();
            }

            var _usuario = _usuarioServico.Find(id);
            if (_usuario == null)
            {
                return NotFound();
            }

            //_usuario.Email = usuario.Email;
            //_usuario.Nome = usuario.Nome;

            _usuarioServico.Update(_usuario);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var usuario = _usuarioServico.Find(id);

            if (usuario == null)
                return NotFound();

            _usuarioServico.Remove(id);

            return new NoContentResult();
        }
    }
}