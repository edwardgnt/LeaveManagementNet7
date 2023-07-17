using AutoMapper;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            // Convert from Data Model into View Model 
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
