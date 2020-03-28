using FirstMVC_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC_Application.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetStudentName() 
        {
            Student student = new Student();
            student.StudentName = "Lara";
            return View(student);
        }
    }
}