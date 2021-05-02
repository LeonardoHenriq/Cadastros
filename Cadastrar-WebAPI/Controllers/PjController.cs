using Cadastrar_WebAPI.Data;
using Cadastrar_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastrar_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PjController : ControllerBase
    {
        public readonly IRepository _repo;
        public PjController(IRepository repo)
        {
            _repo = repo;

        }
        //api/Pj/
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _repo.GetAllPjAsync();

                return Ok(result);
            }
            catch (Exception ex)
            {

                return BadRequest($"Erro! {ex.Message}");
            }
        }
        //api/Pj/id
        [HttpGet("{PjId}")]
        public async Task<IActionResult> GetByPjId(int PjId)
        {
            try
            {
                var result = await _repo.GetPjAsyncById(PjId);

                return Ok(result);
            }
            catch (Exception ex)
            {

                return BadRequest($"Erro! {ex.Message}");
            }
        }
        //api/Pj/
        [HttpPost]
        public async Task<IActionResult> post(Pj model)
        {
            try
            {
                _repo.Add(model);

                if (await _repo.SaveChangesAsync())
                {
                    return Ok(model);
                }
            }
            catch (Exception ex)
            {

                return BadRequest($"Erro! {ex.Message}");
            }

            return BadRequest();
        }
        //api/Pj/id
        [HttpPut("{pjId}")]
        public async Task<IActionResult> put(int pjId, Pj model)
        {
            try
            {
                var pj = await _repo.GetPjAsyncById(pjId);
                if (pj == null) return NotFound("pessoa juridica não encotrada!");

                _repo.Update(model);

                if (await _repo.SaveChangesAsync())
                {
                    return Ok(model);
                }
            }
            catch (Exception ex)
            {

                return BadRequest($"Erro! {ex.Message}");
            }

            return BadRequest();
        }
        //api/Pj/id
        [HttpDelete("{pjId}")]
        public async Task<IActionResult> delete(int pjId)
        {
            try
            {
                var pj = await _repo.GetPjAsyncById(pjId);
                if (pj == null) return NotFound();

                _repo.Delete(pj);

                if (await _repo.SaveChangesAsync())
                {
                    return Ok(new { message = "Excluido" });
                }
            }
            catch (Exception ex)
            {

                return BadRequest($"Erro! {ex.Message}");
            }

            return BadRequest();
        }
    }
}
