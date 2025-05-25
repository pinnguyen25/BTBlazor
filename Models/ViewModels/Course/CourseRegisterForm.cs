using System.ComponentModel.DataAnnotations;

namespace dotnet03_web_blazor.Models.ViewModels;

public class CourseRegisterForm
{
    // họ và tên
    [Required(ErrorMessage ="Full Name must be at least 3 character long.")]
    [MinLength(3, ErrorMessage = "Full Name must be at least 3 character long.")]
    public string FullName { get; set; }

    // email
    [Required(ErrorMessage ="Please enter a valid email")]
    [EmailAddress(ErrorMessage = "Please enter a valid email")]
    public string Email { get; set; }

    // sdt
    [Required(ErrorMessage ="Phone Number must be 10–12 digits and contain only numbers")]
    [RegularExpression(@"^\d{10,12}$", ErrorMessage = "Phone Number must be 10–12 digits and contain only numbers")]
    public string PhoneNumber { get; set; }

    // khoá học
    [Required(ErrorMessage = "Please select a learning mode")]
    public string SelectCourse { get; set; }

    // hình thức học
    [Required(ErrorMessage = "Please select a study mode")]
    public string StudyMode { get; set; }

    // ngày bắt đầu học
    [Required(ErrorMessage = "Please select a start date")]
    [DataType(DataType.Date)]
    public DateTime StartDay { get; set; }

    // comment
    public string Comment { get; set; }

    // điều khoản và điều kiện
    [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree to the terms and conditions")]
    public bool TermsAndConditions { get; set; }
    
    
}