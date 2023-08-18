using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Http;
using UManagement.Roles.Dto;
using UManagement.Users.Dto;
using UserManagement.Asposes.Dto;
using UserManagement.Users.Dto;

namespace UManagement.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
        Task<string> PostFileImport(IFormFile file);
        Task<string> ImportFileAsync(string pathFile);
        Task<IDictionary<string, object>> UpdateMultiUser(List<ImportUserReqDto> input);
        Task<IDictionary<string, object>> CreateOrEditMultiUser(ImportUserReqDto input);
        Task<FileDto> ExportFileExcel(ExcelInfoDto excelif);

    }
}
