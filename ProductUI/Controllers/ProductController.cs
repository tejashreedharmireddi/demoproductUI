using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProductUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ProductUI.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Product> ProductList = new List<Product>();

            using (var client = new HttpClient())

            {

                var contentType = new MediaTypeWithQualityHeaderValue("application/json");

                client.DefaultRequestHeaders.Accept.Add(contentType);



                //client.DefaultRequestHeaders.Authorization =

                //new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("token"));



                using (var response = await client.GetAsync("https://localhost:44332/api/Product"))

                {

                    string apiResponse = await response.Content.ReadAsStringAsync();

                    ProductList = JsonConvert.DeserializeObject<List<Product>>(apiResponse);

                }

            }

            return View(ProductList);

        }
        [HttpGet]
        // GET: ProductController/Details/5
        public async Task<IActionResult> GetProductById(int id)
        {
            Product pr = new Product();
            using (var client = new HttpClient())

            {

                var contentType = new MediaTypeWithQualityHeaderValue("application/json");

                client.DefaultRequestHeaders.Accept.Add(contentType);



                //client.DefaultRequestHeaders.Authorization =

                //new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("token"));



                using (var response = await client.GetAsync("https://localhost:44332/api/Product/" + id))

                {

                    string apiResponse = await response.Content.ReadAsStringAsync();

                    pr = JsonConvert.DeserializeObject<Product>(apiResponse);

                }

            }
            return View(pr);
        }

        // GET: ProductController/Create
        
    }
}
