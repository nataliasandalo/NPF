using NPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace NPF.Controllers
{
    public class DivisorController : ApiController
    {
        //// GET: divisor
        //public ActionResult Index()
        //{
        //    return View();
        //}

        // GET api/divisor
        public List<DivisivelBy11> Get(List<int> numeros)
        {
            numeros = new List<int>() { 165, 1716, 439087, 678, 139081};

            var list = new List<DivisivelBy11>();
            var modelo = new DivisivelBy11();

            if (numeros != null)
            {
                foreach (var item in numeros)
                {
                    modelo = new DivisivelBy11
                    {
                        Numero = item
                    };

                    if (modelo.Numero%11 == 0)
                    {
                        modelo.IsDivisivelBy11 = true;
                    }
                    else
                    {
                        modelo.IsDivisivelBy11 = false;
                    }

                    list.Add(modelo);
                }
            }

            return list;
        }
    }
}