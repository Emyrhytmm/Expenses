using Expenses.DataAccess.Ripositories.Abstract;
using Expenses.Models;
using Microsoft.AspNetCore.Mvc;

namespace Expenses.Web.Controllers
{
    public class ExpensesController : Controller
    {
        private readonly IExpensesRepository _expense;
        public IActionResult Index(string searching)
        {
            List<ExpenseModel> list = new List<ExpenseModel>();
            if
        }
        //
    }
}
