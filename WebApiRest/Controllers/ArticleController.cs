using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiRest.Controllers
{
    public class ArticleController : ApiController
    {
        //DB conection reference
        private MiBaseDeDatosEntities Context = new MiBaseDeDatosEntities();
        // Method GET /api/article
        [HttpGet]
        public IEnumerable<MiTabla> Get()
        {
            using (MiBaseDeDatosEntities db = new MiBaseDeDatosEntities())
            {
                return db.MiTablas.ToList();
            }
        }
        // Method Get by ID /api/article/{id}
        [HttpGet]
        public MiTabla Get(int id)
        {
            //call the connection to the database
            using (MiBaseDeDatosEntities db = new MiBaseDeDatosEntities())
            {
                return db.MiTablas.FirstOrDefault(x => x.ID == id); 
            }
        }
        //Method Post api/Article
        [HttpPost]
        public IHttpActionResult AddName([FromBody] MiTabla mitabla)
        {
            if (ModelState.IsValid)
            {
                Context.MiTablas.Add(mitabla);
                Context.SaveChanges();
                return Ok(mitabla);
            }
            else
            {
                return BadRequest();
            }
        }
        //Method Update api/Article/{id}
        [HttpPut]
        public IHttpActionResult UpdateName(int id, [FromBody] MiTabla mitabla)
        {
            if(ModelState.IsValid)
            {
                var TablaExist = Context.MiTablas.Count(e => e.ID== id)>0;
                if (TablaExist)
                {
                    Context.Entry(mitabla).State = System.Data.Entity.EntityState.Modified;
                    Context.SaveChanges(); 
                    return Ok(mitabla);
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return BadRequest();
            }
        }
        //Method Delete api/Article/{id}
        [HttpDelete]
        public IHttpActionResult DeleteName(int ID) 
        {
            var Name = Context.MiTablas.Find(ID);
            if(Name != null)
            {
                Context.MiTablas.Remove(Name);
                Context.SaveChanges(); 
                return Ok(Name);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
