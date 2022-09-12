using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesDemo.Pages
{
    [BindProperties]
    public class ContactModel : PageModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string Feedback { get; set; }

        public void OnGet()
        {
        }
        public void OnPost()
        {
            Feedback = $"Bedankt {Name} voor je bericht. We sturen zo snel mogelijk een bericht naar {Email}";
        }

    }
}
