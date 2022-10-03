using AutoMapper;
using Domain;
using Domain.DTOs;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserDTO>()
                .ForMember(dest => dest.Certifications,
                                opt => opt.MapFrom
                                (
                                src => src.Certifications
                                .Select(cer => cer.Name).ToList()
                                )
                           );

            CreateMap<UserDTO, User>()
                .ForMember(dest => dest.Certifications,
                opt => opt.MapFrom(
                    src => src.Certifications.
                    Select(cer => new Certification { Name = cer })
                                   )
                            );

            CreateMap<UserRegistrationModel, User>()
               .ForMember(dest => dest.Certifications,
               opt => opt.MapFrom(
                   src => src.Certifications.
                   Select(cer => new Certification { Name = cer })
                                  )
                           ).ForMember(dest => dest.UserName,
               opt => opt.MapFrom(src => src.Name));

            /*  CreateMap<Certification, UserCertificationDTO>()
                  .ForMember(dest =>
                            dest.Name,
              opt => opt.MapFrom(src => src.Name)).ReverseMap();*/


        }



    }



}