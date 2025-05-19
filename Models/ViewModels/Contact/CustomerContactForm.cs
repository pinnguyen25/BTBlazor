using System.ComponentModel.DataAnnotations;

namespace dotnet03_web_blazor.Models.ViewModels;

public class CustomerContactForm
{
    // Bắt buộc, kiểm tra độ dài tối thiểu 3 ký tự)
    [Required(ErrorMessage = "Full Name is required")]
    [MinLength(3, ErrorMessage = "Full Name must be at least 3 character long.")]
    public string FullName { get; set; }

    // (Bắt buộc, kiểm tra đúng định dạng email)
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address")]
    public string Email { get; set; }

    // Bắt buộc, chỉ chấp nhận số điện thoại từ 10-12 chữ số
    [Required(ErrorMessage = "Phone Number is required")]
    [StringLength(12, MinimumLength = 10, ErrorMessage = "Phone Number must be between 10 and 12 digits")]
    [RegularExpression(@"^\d{10,12}$", ErrorMessage = "Phone Number must contain only digits")]
    public string PhoneNumber { get; set; }

    // Tùy chọn, kiểm tra độ dài tối thiểu 5 ký tự)
    [MinLength(5, ErrorMessage = "Address must be at least 5 characters")]
    public string Address { get; set; }

    // Bắt buộc, kiểm tra độ dài tối thiểu 10 ký tự
    [Required(ErrorMessage = "Message is required")]
    [MinLength(10, ErrorMessage = "Message must be at least 10 characters")]
    public string Message { get; set; }

    // Bắt buộc, yêu cầu chọn một mục không phải "Choose...")
    [Required(ErrorMessage = "Please select a Service")]
    public string SelectService { get; set; } = null;


    // Bắt buộc, kiểm tra checkbox phải được chọn
    [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree before submitting")]
    public bool TermsAndConditions { get; set; }

}