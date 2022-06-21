using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Net.Http;
using artesaniaApi.Models;

namespace artesaniaApi.Controllers
{
    public class ProductoController : Controller
    {
        [System.Web.Http.HttpPost]
        public IHttpActionResult add(Models.artesaniaEntities arte)
        {
           using(Models.artesaniaEntities bdd= new Models.artesaniaEntities())
            {
                var prod = new Models.Producto();
                prod.nombre = "Lampara";
                prod.descripcion = "Echa de barro";
                prod.cantidad = 10;
                prod.precio = 2.50;
                bdd.Producto.Add(prod);
                bdd.SaveChanges();
                
            }
            return Ok("AGREGADO");
        }

       
    }
}