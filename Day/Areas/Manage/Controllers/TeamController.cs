using Day.DAL;
using Day.Helpers;
using Day.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day.Areas.Manage.Controllers
{
    [Area("manage")]
    public class TeamController : Controller
    {
        private AppDbContext _context;
        private IWebHostEnvironment _env;

        public TeamController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            var teamMembers = _context.TeamMembers.ToList();
            return View(teamMembers);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(TeamMember member)
        {

            if (member.ImageFile != null)
            {
                if(member.ImageFile.ContentType!="image/png" && member.ImageFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("ImageFile", "Image file must be png or jpeg!");
                    return View();
                }

                if (member.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "Image file must be less than 2MB!");
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError("ImageFile", "Image file is required!");
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            _context.TeamMembers.Add(member);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            var member = _context.TeamMembers.FirstOrDefault(x => x.Id == id);

            if (member == null)
                return RedirectToAction("error", "dashboard");


            return View(member);

        }
        [HttpPost]
        public IActionResult Edit(TeamMember member)
        {
            var existMember = _context.TeamMembers.FirstOrDefault(x => x.Id == member.Id);

            if (existMember == null)
                return RedirectToAction("error", "dashboard");

            if (existMember.ImageFile != null)
            {
                if (member.ImageFile.ContentType != "image/png" && member.ImageFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("ImageFile", "Image file must be png or jpeg!");
                    return View();
                }

                if (member.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "Image file must be less than 2MB!");
                    return View();
                }

                if (!ModelState.IsValid)
                    return View();

                var newFileName = FileManager.Save(_env.WebRootPath, "uploads/teamMembers", member.ImageFile);

                FileManager.Delete(_env.WebRootPath, "uploads/teamMembers", existMember.Image);

                existMember.Image = newFileName;
            }

            existMember.FullName = member.FullName;
            existMember.Profession = member.Profession;
            existMember.Desc = member.Desc;
            existMember.TwitterUrl = member.TwitterUrl;
            existMember.FacebookUrl = member.FacebookUrl;
            existMember.InstagramUrl = member.InstagramUrl;
            existMember.LinkedinUrl = member.LinkedinUrl;

            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            var member = _context.TeamMembers.FirstOrDefault(x => x.Id == id);

            if (member == null)
                return RedirectToAction("error", "dashboard");


            return View(member);
        }
        [HttpPost]
        public IActionResult Delete(TeamMember member)
        {
            var existMember = _context.TeamMembers.FirstOrDefault(x => x.Id == member.Id);

            if (existMember == null)
                RedirectToAction("error", "dashboard");

            FileManager.Delete(_env.WebRootPath, "uploads/teamMembers", existMember.Image);

            _context.TeamMembers.Remove(existMember);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
