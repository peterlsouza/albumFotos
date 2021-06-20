using AlbumFotos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumFotos.ViewComponents
{
    public class ImagemViewComponent : ViewComponent
    {
        private readonly MyDbContext _context;

        public ImagemViewComponent(MyDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            return View(await _context.Imagens.Where(x => x.AlbumId == id).ToListAsync());
        }
    }
}
