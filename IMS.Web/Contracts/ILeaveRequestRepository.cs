using IMS.Web.Data;
using IMS.Web.Models;

namespace IMS.Web.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task CreateLeaveRequest(LeaveRequestCreateVM model);
    }
}
