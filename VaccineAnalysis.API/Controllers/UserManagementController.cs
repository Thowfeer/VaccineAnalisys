using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VaccineAnalysis.API.Model;
using VaccineAnalysis.Core.Entites;
using VaccineAnalysis.Service.Dtos.UserInfoDto;
using VaccineAnalysis.Service.Interfaces;

namespace VaccineAnalysis.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserManagementController : ControllerBase
    {
        private IMapper _mapper;
        private IUserRepository _userRepository;

        public UserManagementController(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        [HttpPost]
        [Route("CreateUser")]
        public async Task<IActionResult> CreateUser(UserCreationDto model)
        {
            try
            {
                return Ok(await _userRepository.Add(_mapper.Map<UserInfo>(model)));
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
        [HttpPut]
        [Route("DeleteUser")]
        public async Task<IActionResult> DeleteUser(long userId)
        {
            try
            {
                return Ok(await _userRepository.DeleteUser(userId));
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetAllUser")]
        public async Task<IActionResult> GetAllUser()
        {
            try
            {
                return Ok(_mapper.Map<UserInfoReadDto>(await _userRepository.GetAll()));
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
