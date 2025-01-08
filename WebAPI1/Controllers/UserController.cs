using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI1.Models;

namespace WebAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        private readonly isha_sys_devContext _isha_sys_dev;

        // public UserController(isha_sys_devContext isha_sys_dev)
        // {
        //     _isha_sys_dev = isha_sys_dev;
        // }
        //
        // [HttpGet]
        // public IEnumerable<user_info> Get()
        // {
        //     return _isha_sys_dev.user_info;
        // }
        //
        // public class LoginDto
        // {
        //     public string Username { get; set; }
        //     public string Password { get; set; }
        // }
        //
        // [HttpPost("login")]
        // public IActionResult Login([FromBody] LoginDto loginDto)
        // {
        //     byte[] salt = new byte[128 / 8];
        //     // 使用 LINQ 查詢用戶
        //     var user = _isha_sys_dev.user_info
        //         .FirstOrDefault(u => u.username == loginDto.Username);
        //
        //     if (user == null)
        //     {
        //         // 返回未授權狀態碼和錯誤訊息
        //         return Unauthorized(new { message = "沒有這人" });
        //     }
        //
        //     // 從數據庫中獲取存儲的密文和 salt
        //     var storedHashedPassword = user.password; // 數據庫中的密文
        //     var storedSalt = Convert.FromBase64String(user.salt); // 數據庫中的 salt
        //
        //     // 使用用戶輸入的密碼和存儲的 salt 進行加密
        //     var inputHashedPassword = Convert.ToBase64String(
        //         KeyDerivation.Pbkdf2(
        //             password: loginDto.Password,
        //             salt: storedSalt,
        //             prf: KeyDerivationPrf.HMACSHA1,
        //             iterationCount: 5000,
        //             numBytesRequested: 256 / 8
        //         )
        //     );
        //
        //     // 比較加密後的密碼是否匹配
        //     if (inputHashedPassword != storedHashedPassword)
        //     {
        //         Console.WriteLine(inputHashedPassword);
        //         Console.WriteLine(storedHashedPassword);
        //         // 返回未授權狀態碼和錯誤訊息
        //         return Unauthorized(new { message = "用戶名或密碼錯誤"});
        //     }
        //
        //     // 返回用戶數據（移除敏感信息）
        //     var userDto = new
        //     {
        //         Username = user.username,
        //         Email = user.email
        //         // 其他需要的字段
        //     };
        //
        //     return Ok(userDto); // 返回成功響應
        // }
    }
}
