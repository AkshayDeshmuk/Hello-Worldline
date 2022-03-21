using AssignmentPopulationCount.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AssignmentPopulationCount.Controllers
{
    public class PopulationInfoController : Controller
    {
        private readonly IPopulationInfoService _populationInfoService;

        public PopulationInfoController(IPopulationInfoService populationInfoService)
        {
            _populationInfoService = populationInfoService;
        }

        public IActionResult Index()
        {
            return View();
        }
        // GET: PopulationInfoController
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> IndexAsync(string pinCode)
        {
            var populationInfo = await _populationInfoService.GetCategoryWisePopulationForPinCodeAsync(pinCode);
            return View(populationInfo);
        }


    }
}
