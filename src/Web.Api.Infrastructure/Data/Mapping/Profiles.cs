using AutoMapper;
using Web.Api.Core.Domain.Entities;
using Web.Api.Infrastructure.Identity;


namespace Web.Api.Infrastructure.Data.Mapping
{
    public class DataProfile : Profile
    {
        public DataProfile()
        {
            CreateMap<User, AppUser<int>>().ConstructUsing(u => new AppUser<int> {UserName = u.UserName, Email = u.Email}).ForMember(au=>au.Id,opt=>opt.Ignore());
            CreateMap<AppUser<int>, User>().ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email)).
                                       ForMember(dest=> dest.PasswordHash, opt=> opt.MapFrom(src=>src.PasswordHash)).
                                       ForAllOtherMembers(opt=>opt.Ignore());
            

        }
    }
}
