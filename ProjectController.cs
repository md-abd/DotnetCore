using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project_Abdullah1.Models;
using Microsoft.EntityFrameworkCore;

namespace Project_Abdullah1.Controllers
{
    public class ProjectController : Controller
    {
        private readonly Baseline1 _context;
        public ProjectController(Baseline1 context)
        {
            _context = context;
        }

        //Faculty Personel Information
        public async Task<IActionResult> FacultyInfoIndex(string searchBy, string search)
        {
            if (searchBy == "Faculty_Name")
            {
                return View(await _context.FacultyInformation.Where(x => x.Faculty_Name.StartsWith(search) || search == null).ToListAsync());
            }
            else
            {
                return View(await _context.FacultyInformation.Where(x => x.Highest_Qualification.StartsWith(search)|| search == null).ToListAsync());
            }
        }
        
        [HttpGet]
        public IActionResult FacultyInfoCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> FacultyInfoCreate(FacultyInformation a)
        {
            if (ModelState.IsValid)
            {
                _context.Add(a);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(FacultyInfoIndex));
            }
            return View(a);
        }
        [HttpGet]
        public async Task<IActionResult> FacultyInfoDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var b = await _context.FacultyInformation
                .FirstOrDefaultAsync(m => m.Faculty_ID == id);
            if (b == null)
            {
                return NotFound();
            }
            return View(b);
        }
        [HttpPost, ActionName("FacultyInfoDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var b = await _context.FacultyInformation.FindAsync(id);
            _context.FacultyInformation.Remove(b);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(FacultyInfoIndex));
        }

        [HttpGet]
        public async Task<IActionResult> FacultyInfoEdit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("FacultyInfoIndex");
            }
            var c = await _context.FacultyInformation.FindAsync(id);
            return View(c);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FacultyInfoEdit(FacultyInformation d)
        {
            if (ModelState.IsValid)
            {
                _context.Update(d);
                await _context.SaveChangesAsync();
                return RedirectToAction("FacultyInfoIndex");
            }
            return View(d);
        }








        //Faculty Skills and Certification

        public async Task<IActionResult> FacultyCertIndex(string searchBy, string search)
        {
            if (searchBy == "Faculty_Skill")
            {
                return View(await _context.FacultyCertification.Where(x => x.Faculty_Skill.StartsWith(search) || search == null).ToListAsync());
            }
            else
            {
                return View(await _context.FacultyCertification.Where(x => x.Certification_Title.StartsWith(search) || search == null).ToListAsync());
            }
        }

        [HttpGet]
        public IActionResult FacultyCertCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> FacultyCertCreate(FacultyCertification a)
        {
            if (ModelState.IsValid)
            {
                _context.Add(a);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(FacultyCertIndex));
            }
            return View(a);
        }


        [HttpGet]
        public async Task<IActionResult> FacultyCertDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var b = await _context.FacultyCertification
                .FirstOrDefaultAsync(m => m.Faculty_ID == id);
            if (b == null)
            {
                return NotFound();
            }
            return View(b);
        }
        [HttpPost, ActionName("FacultyCertDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed1(int id)
        {
            var b = await _context.FacultyCertification.FindAsync(id);
            _context.FacultyCertification.Remove(b);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(FacultyCertIndex));
        }

        [HttpGet]
        public async Task<IActionResult> FacultyCertEdit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("FacultyCertIndex");
            }
            var c = await _context.FacultyCertification.FindAsync(id);
            return View(c);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FacultyCertEdit(FacultyCertification d)
        {
            if (ModelState.IsValid)
            {
                _context.Update(d);
                await _context.SaveChangesAsync();
                return RedirectToAction("FacultyCertIndex");
            }
            return View(d);
        }




        //Module Registration

        public async Task<IActionResult> ModuleIndex(string searchBy, string search)
        {
            if (searchBy == "Technology_Name")
            {
                return View(await _context.ModuleRegistration.Where(x => x.Technology_Name.StartsWith(search) || search == null).ToListAsync());
            }
            else
            {
                return View(await _context.ModuleRegistration.Where(x => x.Domain_Description.StartsWith(search) || search == null).ToListAsync());
            }
        }


        [HttpGet]
        public IActionResult ModuleCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ModuleCreate(ModuleRegistration a)
        {
            if (ModelState.IsValid)
            {
                _context.Add(a);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ModuleIndex));
            }
            return View(a);
        }


        [HttpGet]
        public async Task<IActionResult> ModuleDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var b = await _context.ModuleRegistration
                .FirstOrDefaultAsync(m => m.M_ID == id);
            if (b == null)
            {
                return NotFound();
            }
            return View(b);
        }
        [HttpPost, ActionName("ModuleDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed2(int id)
        {
            var b = await _context.ModuleRegistration.FindAsync(id);
            _context.ModuleRegistration.Remove(b);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ModuleIndex));
        }

        [HttpGet]
        public async Task<IActionResult> ModuleEdit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("ModuleIndex");
            }
            var c = await _context.ModuleRegistration.FindAsync(id);
            return View(c);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ModuleEdit(ModuleRegistration d)
        {
            if (ModelState.IsValid)
            {
                _context.Update(d);
                await _context.SaveChangesAsync();
                return RedirectToAction("ModuleIndex");
            }
            return View(d);
        }








        //Batch Allocation

   

        public async Task<IActionResult> BatchAllocateIndex()
        {
                return View(await _context.BatchAllocation.ToListAsync());
           
        }

        [HttpGet]
        public IActionResult BatchAllocateCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BatchAllocateCreate(BatchAllocation a)
        {
            if (ModelState.IsValid)
            {
                _context.Add(a);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(BatchAllocateIndex));
            }
            return View(a);
        }

        [HttpGet]
        public async Task<IActionResult> BatchAllocateDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var b = await _context.BatchAllocation
                .FirstOrDefaultAsync(m => m.Domain_ID == id);
            if (b == null)
            {
                return NotFound();
            }
            return View(b);
        }
        [HttpPost, ActionName("BatchAllocateDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed3(int id)
        {
            var b = await _context.BatchAllocation.FindAsync(id);
            _context.BatchAllocation.Remove(b);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(BatchAllocateIndex));
        }

        [HttpGet]
        public async Task<IActionResult> BatchAllocateEdit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("BatchAllocateIndex");
            }
            var c = await _context.BatchAllocation.FindAsync(id);
            return View(c);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BatchAllocateEdit(BatchAllocation d)
        {
            if (ModelState.IsValid)
            {
                _context.Update(d);
                await _context.SaveChangesAsync();
                return RedirectToAction("BatchAllocateIndex");
            }
            return View(d);
        }








        //Batch Update Search

        public async Task<IActionResult> BatchInfoIndex()
        {
            return View(await _context.BatchUpdateSearch.ToListAsync());
        }

        [HttpGet]
        public IActionResult BatchInfoCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BatchInfoCreate(BatchUpdateSearch a)
        {
            if (ModelState.IsValid)
            {
                _context.Add(a);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(BatchInfoIndex));
            }
            return View(a);
        }

        [HttpGet]
        public async Task<IActionResult> BatchInfoDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var b = await _context.BatchUpdateSearch
                .FirstOrDefaultAsync(m => m.ID == id);
            if (b == null)
            {
                return NotFound();
            }
            return View(b);
        }
        [HttpPost, ActionName("BatchInfoDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed4(int id)
        {
            var b = await _context.BatchUpdateSearch.FindAsync(id);
            _context.BatchUpdateSearch.Remove(b);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(BatchInfoIndex));
        }

        [HttpGet]
        public async Task<IActionResult> BatchInfoEdit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("BatchInfoIndex");
            }
            var c = await _context.BatchUpdateSearch.FindAsync(id);
            return View(c);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BatchInfoEdit(BatchUpdateSearch d)
        {
            if (ModelState.IsValid)
            {
                _context.Update(d);
                await _context.SaveChangesAsync();
                return RedirectToAction("BatchInfoIndex");
            }
            return View(d);
        }





        //Report Submission

        public async Task<IActionResult> ReportInfoIndex()
        {
            return View(await _context.BatchInfoTable.ToListAsync());
        }

        [HttpGet]
        public IActionResult ReportInfoCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ReportInfoCreate(BatchInfoTable a)
        {
            if (ModelState.IsValid)
            {
                _context.Add(a);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ReportInfoIndex));
            }
            return View(a);
        }

        [HttpGet]
        public async Task<IActionResult> ReportInfoDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var b = await _context.BatchInfoTable
                .FirstOrDefaultAsync(m => m.ID == id);
            if (b == null)
            {
                return NotFound();
            }
            return View(b);
        }
        [HttpPost, ActionName("ReportInfoDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed5(int id)
        {
            var b = await _context.BatchInfoTable.FindAsync(id);
            _context.BatchInfoTable.Remove(b);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ReportInfoIndex));
        }

        [HttpGet]
        public async Task<IActionResult> ReportInfoEdit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("ReportInfoIndex");
            }
            var c = await _context.BatchInfoTable.FindAsync(id);
            return View(c);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ReportInfoEdit(BatchInfoTable d)
        {
            if (ModelState.IsValid)
            {
                _context.Update(d);
                await _context.SaveChangesAsync();
                return RedirectToAction("ReportInfoIndex");
            }
            return View(d);
        }





        //Award and Credit


        public async Task<IActionResult> AwardInfoIndex()
        {
           
        return View(await _context.BatchScreen.ToListAsync());
            
        }

        [HttpGet]
        public IActionResult AwardInfoCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AwardInfoCreate(BatchScreen a)
        {
            if (ModelState.IsValid)
            {
                _context.Add(a);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(AwardInfoIndex));
            }
            return View(a);
        }

        [HttpGet]
        public async Task<IActionResult> AwardInfoDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var b = await _context.BatchScreen
                .FirstOrDefaultAsync(m => m.F_ID == id);
            if (b == null)
            {
                return NotFound();
            }
            return View(b);
        }
        [HttpPost, ActionName("AwardInfoDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed6(int id)
        {
            var b = await _context.BatchScreen.FindAsync(id);
            _context.BatchScreen.Remove(b);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(AwardInfoIndex));
        }

        [HttpGet]
        public async Task<IActionResult> AwardInfoEdit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("AwardInfoIndex");
            }
            var c = await _context.BatchScreen.FindAsync(id);
            return View(c);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AwardInfoEdit(BatchScreen d)
        {
            if (ModelState.IsValid)
            {
                _context.Update(d);
                await _context.SaveChangesAsync();
                return RedirectToAction("AwardInfoIndex");
            }
            return View(d);
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Login a)
        {
            bool isValid = _context.Login.Any(x => x.UserName == a.UserName && x.Password == a.Password);
            if (isValid)
            {
                return RedirectToAction(nameof(HomePage));
            }
            else
            {
                ModelState.AddModelError("", "Invalid username and password");
            }
            return View();
        }
     
        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Signup(Login b)
        {
            _context.Login.Add(b);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Login));

        }
        public async Task<IActionResult> LoginIndex()
        {
            return View(await _context.Login.ToListAsync());
        }

        public IActionResult HomePage()
        {
            return View();
        }

        public IActionResult Info()
        {
            return View();
        }
        public IActionResult Info1()
        {
            return View();
        }
        public IActionResult Info2()
        {
            return View();
        }
        public IActionResult Info3()
        {
            return View();
        }
        public IActionResult Info4()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Courses()
        {
            return View();
        }
        public IActionResult Ranking()
        {
            return View();
        }
    }
}
