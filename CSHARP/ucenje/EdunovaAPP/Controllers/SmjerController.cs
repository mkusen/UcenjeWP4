﻿using EdunovaAPP.Data;
using EdunovaAPP.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace EdunovaAPP.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class SmjerController : ControllerBase
    {
        //dependecy injection
        //1. definiraš privatno svojstvo
        private readonly EdunovaContext _context;

        //2.proslijediš instancu kroz konstruktor
        public SmjerController(EdunovaContext context)
        {
            _context = context;
        }

        //rute

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Smjerovi);
        }

        [HttpGet]
        [Route("{sifra:int}")]
        public IActionResult GetBySifra(int sifra)
        {
            return Ok(_context.Smjerovi.Find(sifra));
        }

        [HttpPost]
        public IActionResult Post(Smjer smjer)
        {
            _context.Smjerovi.Add(smjer);
            _context.SaveChanges();
            return StatusCode(StatusCodes.Status201Created, smjer);
        }

        [HttpPut]
        [Route("{sifra:int}")]
        [Produces("application/jason")]
        public IActionResult Put(int sifra, Smjer smjer)
        {
            var smjerIzBaze = _context.Smjerovi.Find(sifra);
            smjerIzBaze.Naziv = smjer.Naziv;
            smjerIzBaze.Trajanje  = smjer.Trajanje;
            smjerIzBaze.Cijena = smjer.Cijena;
            smjerIzBaze.IzvodiSeOd = smjer.IzvodiSeOd;
            smjerIzBaze.Vaucer = smjer.Vaucer;


            _context.Smjerovi.Update(smjerIzBaze);
            _context.SaveChanges();

            return Ok(new { poruka = "Uspješno promijenjeno" });

        }

        [HttpDelete]
        [Route("{sifra:int}")]
        [Produces("application/jason")]

        public IActionResult Delete(int sifra)
        {
            var smjerIzBaze = _context.Smjerovi.Find(sifra);
            _context.Smjerovi.Remove(smjerIzBaze);
            _context.SaveChanges();
            return Ok(new { poruka = "uspješno obrisano" });
        }

    }
}
