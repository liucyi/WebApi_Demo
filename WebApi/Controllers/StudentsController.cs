using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
   /// <summary>
   /// 学生api
   /// </summary>
    public class StudentsController : ApiController
    {
        /// <summary>
        /// 获取学生信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Student> GetStudents()
        {
            List<Student> listsStudents = new List<Student>();
            listsStudents.Add(new Student() { id = 1, name = "liuyi" });
            listsStudents.Add(new Student() { id = 2, name = "liuyi1" });
            listsStudents.Add(new Student() { id = 1, name = "liuyi2" });
            ;
            return listsStudents;

        }
    }
}
