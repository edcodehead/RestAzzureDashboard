using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WellnessApp.DAL;

namespace WellnessApp.Web.Pages
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        //private readonly ILogger<RegisterModel> _logger;
        //private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        //WellnessAppDbContext WellnessAppDbContext = new WellnessAppDbContext();
        //RegisterService registerService;

        //AppUser AppUser;

        public void OnGet()
        {
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            //[Required]
            //[Display(Name = "First Name")]
            //public string FirstName { get; set; }

            //[Required]
            //[Display(Name = "Last Name")]
            //public string LastName { get; set; }

            [Required]
            [Display(Name = "User Name")]
            public string UserName { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (this.ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = Input.UserName,
                    Email = Input.Email,
                    PasswordHash = Input.Password
                };
                //var result = await _userManager.CreateAsync(user, Input.Password);
                //registerService.AddNewUser(Input);
                //await _userManager.CreateAsync(Input);
                IdentityResult ir = await _userManager.CreateAsync(user, Input.Password);
                return RedirectToPage("Login");
            }
            else
            {
                return BadRequest();
            }
        }

        //public IActionResult OnPost()
        //{
        //    if (this.ModelState.IsValid)
        //    {
        //        registerService.AddNewUser(AppUser);
        //        return RedirectToPage("Login");
        //    }
        //    else
        //    {
        //        return BadRequest();
        //    }
        //}
    }
}
