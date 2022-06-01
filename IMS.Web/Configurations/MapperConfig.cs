using AutoMapper;
using IMS.Web.Data;
using IMS.Web.Models;

namespace IMS.Web.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Client, ClientVM>().ReverseMap();
            CreateMap<Client, ClientDisplayVM>().ReverseMap();

            CreateMap<ItemType, ItemTypeVM>().ReverseMap();
            CreateMap<ItemCategory, ItemCategoryVM>().ReverseMap();
            CreateMap<ItemModel, ItemModelVM>().ReverseMap();
            CreateMap<ItemStatus, ItemStatusVM>().ReverseMap();
            CreateMap<InboundInvoice, InboundInvoiceVM>().ReverseMap();
            CreateMap<OutboundInvoice, OutboundInvoiceVM>().ReverseMap();

            CreateMap<InventoryItem, InventoryItemVM>().ReverseMap();
            CreateMap<InventoryItem, InventoryItemDisplayVM>().ReverseMap();

            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
