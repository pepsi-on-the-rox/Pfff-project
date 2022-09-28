using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pfff.Data;
using Pfff.Models;


namespace Pfff.Controllers
{
    public class CameraController : Controller
    {
        private readonly AppDbContext _context;
        

        public CameraController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Camera
        public async Task<IActionResult> Index()
        {

           
            

            return View(await _context.Cameras.ToListAsync());
        }




        // GET: Camera/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Cameras == null)
            {
                return NotFound();
            }

            var camera = await _context.Cameras
                .FirstOrDefaultAsync(m => m.CameraID == id);
            if (camera == null)
            {
                return NotFound();
            }

            return View(camera);
        }

        // GET: Camera/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Camera/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CameraID,Latitute,Longitude,Specificatie,Beschrijving")] Camera camera)
        {
            if (ModelState.IsValid)
            {
                _context.Add(camera);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(camera);
        }

        // GET: Camera/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Cameras == null)
            {
                return NotFound();
            }

            var camera = await _context.Cameras.FindAsync(id);
            if (camera == null)
            {
                return NotFound();
            }
            return View(camera);
        }

        // POST: Camera/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CameraID,Latitute,Longitude,Specificatie,Beschrijving")] Camera camera)
        {
            if (id != camera.CameraID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(camera);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CameraExists(camera.CameraID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(camera);
        }

        // GET: Camera/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Cameras == null)
            {
                return NotFound();
            }

            var camera = await _context.Cameras
                .FirstOrDefaultAsync(m => m.CameraID == id);
            if (camera == null)
            {
                return NotFound();
            }

            return View(camera);
        }

        // POST: Camera/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Cameras == null)
            {
                return Problem("Entity set 'AppDbContext.Cameras'  is null.");
            }
            var camera = await _context.Cameras.FindAsync(id);
            if (camera != null)
            {
                _context.Cameras.Remove(camera);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CameraExists(int id)
        {
          return _context.Cameras.Any(e => e.CameraID == id);
        }
    }
}
