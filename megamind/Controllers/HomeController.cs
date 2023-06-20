using megamind.datalayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace megamind.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDBContext _db;

        public HomeController( ApplicationDBContext db)
        {
            _db= db;
        }

        public IActionResult Index()
        {
            var getResult = _db.forms.FromSqlRaw("GetDetails").ToList();
            return View(getResult);
            //return View();
        }

        public IActionResult Privacy()
        {
            var getResult = _db.forms.FromSqlRaw("GetDetails").ToList();
            return View(getResult);
        }
        public IActionResult GetResult(int? Id) 
        {
            var getSingleData = _db.forms.FromSqlRaw($"getSingleRecord {Id}").AsEnumerable().FirstOrDefault();
            return View(getSingleData);
        }
        [HttpPost] 
        public async Task<IActionResult> UpdateDetails(int Id,string name, string email, string phone_no, string address, string state, string city)
        {
            var param = new SqlParameter[]
            {
                new SqlParameter()
                {
                    ParameterName = "@Id",
                    SqlDbType = System.Data.SqlDbType.Int,
                    Value = Id
                },
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
            var updateDetails = await _db.Database.ExecuteSqlRawAsync($"Exec UpdateDatabase @Id,@Name,@Email,@Phone,@Address,@State,@City",param);
            if(updateDetails == 1)
            {
                return Redirect("/Home/Privacy");
            }
            else
            {
                return View();
            }
        }
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            var form =  _db.forms.FromSqlRaw($"getSingleRecord {id}").AsEnumerable().FirstOrDefault();

            if (form == null)
            {
                return NotFound();
            }

            return View(form);
        }
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var form = _db.forms.FromSqlRaw($"getSingleRecord {id}").AsEnumerable().FirstOrDefault();

            if (form == null)
            {
                return NotFound();
            }

            await _db.Database.ExecuteSqlInterpolatedAsync($"EXEC DeleteFromDatabase {id}");

            return Redirect("/Home/Privacy");
        }
    }
}