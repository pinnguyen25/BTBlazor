using System.ComponentModel.DataAnnotations;

namespace dotnet03_web_blazor.Models.ViewModels;

public class UserRegister
{
    [Required]
    public string UserName { get; set; }
    //Password từ 6 -> 32 ký tự phải có tối thiểu 1 chữ in hoa 1 ký tự đặt biệt và tối thiếu 1 số 
    [Required(ErrorMessage ="Mật khẩu là bắt buộc")]
    // [StringLength(32, MinimumLength = 6, ErrorMessage = "Password từ 6->32 kí tự")]
    [MinLength(6, ErrorMessage ="text lenght 6->32 character")]
    [MaxLength(32, ErrorMessage ="text lenght 6->32 character")]
    [RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+\-=\[\]{};':""\\|,.<>\/?]).+$", ErrorMessage = "Password có tối thiểu 1 chữ in hoa, 1 ký tự đặt biệt và tối thiếu 1 số ")]
    public string Password { get; set; }

    [Required]
    public string FullName { get; set; }
    public bool Gender { get; set; } = true; //true name false nữ

    public string Country { get; set; } = "VietNam";
}