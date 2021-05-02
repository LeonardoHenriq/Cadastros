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
    public class PfController : ControllerBase
    {
        public readonly IRepository _repo;
        public PfController(IRepository repo)
        {
            _repo = repo;

        }

        //api/Pf/
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _repo.GetAllPfAsync();

                return Ok(result);
            }
            catch (Exception ex)
            {

                return BadRequest($"Erro! {ex.Message}");
            }
        }
        //api/Pf/id
        [HttpGet("{PfId}")]
        public async Task<IActionResult> GetByPfId(int PfId)
        {
            try
            {
                var result = await _repo.GetPfAsyncById(PfId);

                return Ok(result);
            }
            catch (Exception ex)
            {

                return BadRequest($"Erro! {ex.Message}");
            }
        }
        //api/Pf/
        [HttpPost]
        public async Task<IActionResult> post(Pf model)
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
        //api/Pf/id
        [HttpPut("{pfId}")]
        public async Task<IActionResult> put(int pfId,Pf model)
        {
            try
            {
                var pf = await _repo.GetPfAsyncById(pfId);
                if (pf == null) return NotFound("pessoa fisica não encotrada!");

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
        //api/Pf/id
        [HttpDelete("{pfId}")]
        public async Task<IActionResult> delete(int pfId)
        {
            try
            {
                var pf = await _repo.GetPfAsyncById(pfId);
                if (pf == null) return NotFound();

                _repo.Delete(pf);

                if (await _repo.SaveChangesAsync())
                {
                    return Ok(new { message ="Excluido"});
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
