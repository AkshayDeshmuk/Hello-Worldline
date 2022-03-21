using WorldlineServiceReference;
using System.Threading.Tasks;

namespace AssignmentPopulationCount.Services
{
    public interface IPopulationInfoService
    {
        Task<PopulationInfo> GetCategoryWisePopulationForPinCodeAsync(string pinCode);
    }
}
