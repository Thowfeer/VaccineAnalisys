using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineAnalysis.Core.Entites;
using VaccineAnalysis.Service.Dtos.UserInfoDto;
using VaccineAnalysis.Service.Dtos.VaccineInfoDto;
using VaccineAnalysis.Service.Dtos.VaccineTypeDto;

namespace VaccineAnalysis.Service.Profiles
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<UserCreationDto, UserInfo>();
            CreateMap<UserInfo, UserInfoReadDto>();
            CreateMap<VaccineTypeCreateDto,VaccineType >();
            CreateMap<VaccineType,VaccineTypeReadDto >();
            CreateMap<UserVaccineInfo, UserVaccineInfoReadDto>();
            CreateMap<UserVaccineInfoCreateDto, UserVaccineInfo>();
        }
    }
}
