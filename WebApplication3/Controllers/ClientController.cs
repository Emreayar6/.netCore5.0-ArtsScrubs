using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Repositories;

namespace WebApplication3.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            ClientRepository clientRepository = new ClientRepository();
            return View(clientRepository.TList());
        }
    }
}
