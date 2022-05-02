using ASP.NET_Students_Database_Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_Students_Database_Example.Controllers
{
    public class HomeController : Controller
    {
        List<Student> students = new List<Student>();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowPicture()
        {

            return View();
        }

        public ActionResult ShowTable()
        {
            students = GetAllStudentsSortedByGrade();
            return View(students);
        }

        private List<Student> GetAllStudents()
        {
            using (StudentsDBEntities sdbe = new StudentsDBEntities())
            {
                return sdbe.Students.ToList();
            }
        }

        private List<Student> GetAllStudentsSortedByGrade()
        {
            using (StudentsDBEntities sdbe = new StudentsDBEntities())
            {
                return sdbe.Students.OrderByDescending(x => x.Grade).ToList();
            }
        }
    }
}