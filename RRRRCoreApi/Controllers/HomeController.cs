using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RRRRCoreApi.ApplicationDbContext;
using RRRRCoreApi.Model;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace RRRRCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly Add_G db;
        public HomeController(Add_G db)
        {
            this.db = db;
        }

        [HttpGet]
        [Route("Get/Table")]
        public List<Employee> Display()
        {

            var res = db.Employees.ToList();
            return res;
        }
        [HttpPost]
        [Route("Post/Table")]
        public HttpResponseMessage FormPage(Employee pro)
        {
            if (pro.Id == 0)
            {
                db.Employees.Add(pro);
                db.SaveChanges();

            }
            else
            {
                db.Employees.Update(pro);
                db.SaveChanges();
            }



            HttpResponseMessage res = new HttpResponseMessage(HttpStatusCode.OK);


            return res;
        }

        [HttpGet]
        [Route("Edit/Table")]
        public Employee Edit(int Id)
        {
            var res1 = db.Employees.Where(m => m.Id == Id).FirstOrDefault();




            return res1;
        }
        [HttpDelete]
        [Route("Delete/Table")]
        public HttpResponseMessage Delete(int Id)
        {
            var res2 = db.Employees.Where(m => m.Id == Id).FirstOrDefault();
            db.Employees.Remove(res2);
            db.SaveChanges();

            HttpResponseMessage res5 = new HttpResponseMessage(HttpStatusCode.OK);


            return res5;
        }
        [HttpPost]
        [Route("Login/Table")]
        public UserInfo Login(UserInfo info)
        {

            UserInfo objnew = new UserInfo();


            var d = db.Users.Where(m => m.UserName == info.UserName).FirstOrDefault();
            if (d == null)
            {

                objnew.UserName = "Email not found";


            }
            else
            {
                if (d.UserName == info.UserName && d.Password == info.Password)
                {

                    objnew.ID = d.ID;

                    objnew.UserName = d.UserName;
                    objnew.Password = d.Password;

                }
                else
                {


                    objnew.Password = "Invalid password";

                }

            }

            return objnew;


        }

    }
}
