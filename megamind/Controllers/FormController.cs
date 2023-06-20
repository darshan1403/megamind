using megamind.datalayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace megamind.Controllers
{
    public class FormController : Controller
    {
        private readonly ApplicationDBContext _db;

        public FormController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var getResult = _db.forms.FromSqlRaw("GetDetails").ToList();
            return View(getResult);
        }
        [HttpPost]
        public IActionResult Submit(string name, string email, string phone_no, string address, string state, string city)
        {
            var param = new SqlParameter[]
            {
                new SqlParameter()
                {
                    ParameterName = "@Name",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = name
                },
                new SqlParameter()
                {
                    ParameterName = "@Email",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = email
                },
                new SqlParameter()
                {
                    ParameterName = "@Phone",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = phone_no
                },
                new SqlParameter()
                {
                    ParameterName = "@Address",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = address
                },
                new SqlParameter()
                {
                    ParameterName = "@State",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = state
                },
                new SqlParameter()
                {
                    ParameterName = "@City",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Value = city
                }
            };
            var getresult = _db.Database.ExecuteSqlRawAsync($"Exec StoreDatabase @Name , @Email, @Phone,@Address,@State,@City",param);
            return Redirect("/Home/Privacy");
        }

        public IActionResult Success()
        {
            var getResult = _db.forms.FromSqlRaw("GetDetails").ToList();
            return View(getResult);
        }

    }
}
