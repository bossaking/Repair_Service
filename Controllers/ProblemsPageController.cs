using Repair_Service.DAL;
using Repair_Service.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.Controllers
{
    public class ProblemsPageController : PageController
    {

        public ProblemsPageController() : base() { }

        public async Task<ObservableCollection<Problem>> GetProblemsAsync()
        {
            ObservableCollection<Problem> problems = new ObservableCollection<Problem>();
            await Task.Run(() => problems = database.GetProblems());
            return problems;
        }

        public async Task<bool> AddNewProblemAsync(Problem problem)
        {
            return await Task.Run(() => database.AddNewProblem(problem));
        }

        public async Task<bool> UpdateProblemAsync(Problem problem)
        {
            return await Task.Run(() => database.UpdateProblem(problem));
        }

        public async Task<bool> DeleteProblemAsync(Problem problem)
        {
            return await Task.Run(() => database.DeleteProblem(problem));
        }

        public async Task<bool> RefreshProblems()
        {
            return await Task.Run(() => (database as ProxyDatabase).RefreshProblems());
        }

    }
}
