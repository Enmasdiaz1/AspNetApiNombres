
using AspNetWebApiNombres.Context;
using AspNetWebApiNombres.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetWebApiNombres.Controllers
{

    [ApiController]
    [Route("[api/Controller]")]
    public class EjemploController : Controller
    {
        private NombreContext _nombreContext;



        // GET: api/<EjemploController>
        [HttpGet("~/GetAllNames")]
        public IEnumerable<Nombre> Get()
        {
            return _nombreContext.Nombres;
        }




        // GET api/<EjemploController>/5
        [HttpGet("~/GetByID")]
        public Nombre Get(int id)
        {
            return _nombreContext.Nombres.FirstOrDefault(s => s.Id == id);
        }












    }
}
