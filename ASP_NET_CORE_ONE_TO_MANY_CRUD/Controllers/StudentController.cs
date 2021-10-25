using ASP_NET_CORE_ONE_TO_MANY_CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET_CORE_ONE_TO_MANY_CRUD.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _db;

        

        public StudentController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult StudentList()
        {
            try
            {
                //var stdList = _db.tbl_Student.ToList();//for single Table
                var stdList = from s in _db.tbl_Student
                              join d in _db.tbl_Department
                              on s.DepId equals d.Id into Dep
                              from d in Dep.DefaultIfEmpty()

                              select new Student
                              {
                                  ID = s.ID,
                                  Name = s.Name,
                                  Email = s.Email,
                                  Mobile = s.Mobile,
                                  DepId = s.DepId,

                                  Department =  d
                              };


                return View(stdList);
            }
            catch
            {
                return View();
            }
        }


        public IActionResult Create(Student obj)
        {
            DepartmentLoad();
            return View(obj);
        }


        [HttpPost]
        public async Task<IActionResult> AddStudent(Student obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (obj.ID == 0)
                    {
                        _db.tbl_Student.Add(obj);
                        await _db.SaveChangesAsync();
                    }
                    else
                    {
                        _db.Entry(obj).State = EntityState.Modified;
                        await _db.SaveChangesAsync();
                    }

                    return RedirectToAction("StudentList");
                }
                return RedirectToAction("StudentList");
            }
            catch(Exception ex)
            {
                return RedirectToAction("Privacy");
            }
        }



        public void DepartmentLoad()
        {
            try
            {
                List<Department> depList = new List<Department>();
                depList = _db.tbl_Department.ToList();

                depList.Insert(0, new Department { Id=0,DepName="Please Select",DepChairman=""});
                ViewBag.DepList = depList;

            }catch(Exception ex)
            {
                
            }
        }

        public async Task<IActionResult> DeleteStd(int id)
        {
            try
            {
                var std = await _db.tbl_Student.FindAsync(id);

                if(std != null)
                {
                    _db.tbl_Student.Remove(std);
                    await _db.SaveChangesAsync();
                }

                return RedirectToAction("StudentList");
            }
            catch
            {
                return RedirectToAction("StudentList");
            }
        }
    }
}
