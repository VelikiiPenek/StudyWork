using Microsoft.AspNetCore.Mvc;
using StudyWork.Models;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using Microsoft.Extensions.Configuration;
using Dapper;
using Microsoft.Identity.Client;

namespace StudyWork.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _config;

        public HomeController(ILogger<HomeController> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        } 

        public IActionResult Index()
        {
            var model = GetUsersD();
            var st = GetStuds();
            return View(st);    
            // return View(model);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private List<Users> GetUsersD()
        {
            
            using (IDbConnection db = Connection)
            {
                var result = db.Query<Users>("SELECT * FROM Pol;").ToList();

                return result;
            }
        }

        private void Aunt(string login,string password) 
        {
            using (IDbConnection db = Connection)
            {
                var result = db.Query<Users>("SELECT * FROM Pol;").ToArray();
                for (int i = 0; ; i++)
                {
                    if (login == Convert.ToString(result[i]) && password == Convert.ToString(result))
                    {
                     
                    }
                }
         
            }
        }


        public class Users
        {
            public int ID_User { get; set; }

            public string Login { get; set; }

            public string Password { get; set; }
        }

        private List<worker> GetWorkers()
        {
            using (IDbConnection db = Connection)
            {
                var result = db.Query<worker>("SELECT * FROM Worker;").ToList();

                return result;
            }
        }

        public class worker
        {
            public int ID_Worker { get; set; }
        }

        private List<employer> GetEmployers()
        {
            using (IDbConnection db = Connection)
            {
                var result = db.Query<employer>("SELECT * FROM Employer;").ToList();

                return result;
            }
        }

        public class employer
        {
            public int ID_Employer { get; set; }

            public string Company { get; set; }

            public string FamiliaEm { get; set; }

            public string NameEm { get; set; }

            public string OtchEm { get; set; }

        }

        private List<resume> GetResumes()
        {
            using (IDbConnection db = Connection)
            {
                var result = db.Query<resume>("SELECT * FROM Resume;").ToList();

                return result;
            }
        }
        public class resume
        {
            public int ID_Resume { get; set; }
            public string ProgLanguages { get; set; }
        }

        private List<stud> GetStuds()
        {
            using (IDbConnection db = Connection)
            {
                var result = db.Query<stud>("SELECT * FROM Stud;").ToList();

                return result;
            }
        }

        public class stud
        {
            public int ID_Stud { get; set; }
            public string FamiliaStud { get; set; }

            public string NameStud { get; set; }
            public string OtchStud { get; set; }

            public string Gr { get; set; }
            public string Specialization { get; set; }
            public string Email { get; set; }
        }

        private List<listStud> GetListStuds()
        {
            using (IDbConnection db = Connection)
            {
                var result = db.Query<listStud>("SELECT * FROM ListStud ;").ToList();

                return result;
            }
        }


        

        public class listStud
        {
            public int Individual_ID { get; set; }
        }


        private List<role> GetRolesP()
        {
            using (IDbConnection db = Connection)
            {
                var result = db.Query<role>("SELECT * FROM Role ;").ToList();
                return result;
            }


        }


        public class role
        {
            public int ID_Role { get; set; }

            public string Role { get; set; }

        }
    }
}
    