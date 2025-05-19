// using System.ComponentModel.DataAnnotations;

// namespace dotnet03_web_blazor.Models.ViewModels;

// public class CourseRegister
// {
//     // Họ và tên (Full Name) (Bắt buộc)
//     [Required(ErrorMessage = "Full Name must be at least 3 characters long")]
//     [MinLength(3, ErrorMessage = "Full Name must be at least 3 character long.")]
//     public string FullName { get; set; }

//     // Email (Bắt buộc)
//     [Required(ErrorMessage = "Email is required")]
//     [EmailAddress(ErrorMessage = "Please enter a valid email")]
//     public string Email { get; set; }

//     // Số điện thoại (Phone Number) (Bắt buộc)
//     [Required(ErrorMessage = "Phone Number is required")]
//     [RegularExpression(@"^\d{10,12}$", ErrorMessage = "Phone Number must be 10–12 digits and contain only numbers")]
//     public string PhoneNumber { get; set; }

//     // Chọn khóa học (Dropdown) (Bắt buộc)
//     [Required(ErrorMessage = "Please select a learning mode")]
//     public string SelectCourse { get; set; }


//     // Hình thức học (Radio Button: Online/Offline) (Bắt buộc)
//     [Required(ErrorMessage = "Please select a study mode")]
//     public string StudyMode { get; set; }


//     // Ngày bắt đầu mong muốn (Date Picker) (Bắt buộc)
//     [Required(ErrorMessage = "Please select a start date")]
//     [DataType(DataType.Date)]
//     public DateTime StartDay { get; set; }

//     // Bình luận hoặc ghi chú (Textarea) (Tùy chọn)

//     public string Comment { get; set; }

//     // Đồng ý với điều khoản và chính sách (Checkbox) (Bắt buộc)
//     [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree to the terms and conditions")]
//     public bool TermsAndConditions { get; set; }






// }