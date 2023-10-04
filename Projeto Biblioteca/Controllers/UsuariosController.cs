﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto_Biblioteca.Models;

namespace Projeto_Biblioteca.Controllers {
    public class UsuariosController : Controller
        {

        private readonly AppDbContext _context;
        public UsuariosController(AppDbContext context) { 
        
            _context = context;
        }

        public async Task<IActionResult> Index() {

            var dados = await _context.Usuarios.ToListAsync(); 

            return View(dados);   
        }

        public IActionResult Create()
            {

            return View();  
        }

        [HttpPost]
        public async Task<IActionResult> Create(Usuario usuario) {

            if (ModelState.IsValid) 
            {
                _context.Usuarios.Add(usuario);
                await _context.SaveChangesAsync(); 
                return RedirectToAction("Index");

            }

            return View();
        }

    }
}
