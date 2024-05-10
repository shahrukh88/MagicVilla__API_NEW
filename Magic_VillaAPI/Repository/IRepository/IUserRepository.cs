using Magic_VillaAPI.Models;
using Magic_VillaAPI.Models.Dto;

namespace Magic_VillaAPI.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser (string username);

        Task<LoginResponseDTO>Login(LoginRequestDTO loginRequestDto);

        Task<UserDTO> Register(RegistrationRequestDto registerationRequestDTO);


    }
}
