using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AcademicLeaveManagement.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty] public string StudentName { get; set; } = "Raihan";
        [BindProperty] public string StudentId { get; set; } = "92510103071";
        [BindProperty] public string Department { get; set; } = "Computer Engineering";
        [BindProperty] public DateTime SelectedDate { get; set; } = new DateTime(2026, 9, 25);
        [BindProperty] public string LeaveType { get; set; } = "Emergency Leave";
        [BindProperty] public string Reason { get; set; } = "Personal Work";
        public string Message { get; set; } = "";

        public void OnGet()
        {
            StudentName = Request.Cookies["StudentName"] ?? StudentName;
            StudentId = HttpContext.Session.GetString("StudentId") ?? StudentId;
        }

        public void OnPost()
        {
            HttpContext.Session.SetString("StudentId", StudentId ?? "");
            Response.Cookies.Append("StudentName", StudentName ?? "",
                new CookieOptions { Expires = DateTime.Now.AddDays(7), HttpOnly = true });
            Message = "Leave Application Submitted Successfully!";
        }
    }
}
