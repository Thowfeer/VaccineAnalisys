using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VaccineAnalysis.Core.Entites;
using VaccineAnalysis.Service.Dtos.VaccineInfoDto;
using VaccineAnalysis.Service.Dtos.VaccineTypeDto;
using VaccineAnalysis.Service.Interfaces;

namespace VaccineAnalysis.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccineController : ControllerBase
    {
        private IMapper _mapper;
        private IVaccineRepository _repository;

        public VaccineController(IMapper mapper,IVaccineRepository vaccineRepository)
        {
            _mapper = mapper;
            _repository = vaccineRepository;
        }
        [HttpPost]
        [Route("CreateUseVaccineInfo")]
        public async Task<IActionResult> CreateUseVaccineInfo(UserVaccineInfoCreateDto model)
        {
            try
            {
                return Ok(await _repository.Add(_mapper.Map<UserVaccineInfo>(model)));
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetAllInfo")]
        public async Task<IActionResult> GetAllInfo()
        {
            try
            {
                return Ok(_mapper.Map<UserVaccineInfoReadDto>(_repository.GetAll()));
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
        [HttpPost]
        [Route("CreateVaccineType")]
        public async Task<IActionResult> CreateVaccineType(VaccineTypeCreateDto model)
        {
            try
            {
                return Ok(_repository.CreateVaccineTypes(_mapper.Map<VaccineType>(model)));
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
