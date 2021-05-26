using Microsoft.AspNetCore.Mvc;
using exercise5v2.Models;
using exercise5v2.DataContext;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace exercise5v2.Controllers
{
    public class ShroomController : Controller
    {
        private readonly DBContext _myDb;

        public ShroomController(DBContext myDb){
            _myDb = myDb;
        }


        public IActionResult RegisterMushroom(MushroomModel m){
            // Console.Write(m.ScientificName);
            if(ModelState.IsValid){
                _myDb.Add(m);
                _myDb.SaveChanges();
            }
            return RedirectToAction("ShowAll");
        }


        
        public IActionResult ShowAll(){
            return View(_myDb.Shrooms.ToList());
        }

        public ActionResult Index(){    
            return View();
        }

        [HttpPost]
        public IActionResult Edit(MushroomModel m){
            if(ModelState.IsValid){
                _myDb.Shrooms.Update(m);
                _myDb.SaveChanges();
            }
            
            return RedirectToAction("ShowAll");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id){
            // Console.WriteLine("Hello rldw");
            MushroomModel res = await _myDb.Shrooms.FirstOrDefaultAsync(m=> m.ScientificName.Equals(id));
            return View(res);
        }

        public async Task<IActionResult> Delete(string id){
            var res = await _myDb.Shrooms.FirstOrDefaultAsync(m=> m.ScientificName.Equals(id));
            _myDb.Shrooms.Remove(res);
            await _myDb.SaveChangesAsync();
            return RedirectToAction("ShowAll");
        }
    }
}
