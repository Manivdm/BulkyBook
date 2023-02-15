using BulkyBook.DataAccess;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using BulkyBook.Models.ViewModels;
using BulkyBook.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Security.Claims;

namespace BulkyBookWeb.Controllers
    
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        // private readonly IWebHostEnvironment _hostEnvironment;

        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            //IEnumerable<User> objUserList = _unitOfWork.User.GetAll();
            //return View(objUserList);
            return View();
        }

      
     

    }
}
