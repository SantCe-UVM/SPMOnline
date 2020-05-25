namespace School.Web.Controllers
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using School.Web.Data;
    using School.Web.Data.Entities;
    using School.Web.Helpers;
    using School.Web.Models;
    using System.Linq;
    using System.Threading.Tasks;
    
    public class AccountController : Controller
    {
        private readonly DataContext dataContext;
        private readonly IUserHelper userHelper;
        private readonly ICombosHelper combosHelper;

        public AccountController(DataContext dataContext,
            IUserHelper userHelper,
            ICombosHelper combosHelper)
        {
            this.dataContext = dataContext;
            this.userHelper = userHelper;
            this.combosHelper = combosHelper;
        }
        
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult >Login(LoginViewModel model)
        {
            if(this.ModelState.IsValid)
            {
                var result = await this.userHelper.LoginAsync(
                    model.UserName,
                    model.Password,
                    model.RememberMe);
                if(result.Succeeded)
                {
                    if(this.Request.Query.Keys.Contains("ReturnUrl"))
                    {
                        return this.Redirect(this.Request.Query["ReturnUrl"].First());
                    }
                    return this.RedirectToAction("Index", "Home");
                }
            }
            this.ModelState.AddModelError(string.Empty, "Failed to login");
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await this.userHelper.LogoutAsync();
            return this.RedirectToAction("Index","Home");
        }

        public IActionResult Register()
        {
            var model = new RegisterNewUserViewModel
            {
                Genders = this.combosHelper.GetComboGenders()
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterNewUserViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                var user = await this.userHelper.GetUserByEmailAsync(model.UserName);
                if(user==null)
                {
                    var gender = await this.dataContext.Genders.FindAsync(model.GenderId);
                    user = new User
                    {
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        Email = model.UserName,
                        UserName = model.UserName,
                        PhoneNumber = model.PhoneNumber,
                        Gender = gender
                    };
                    var result = await this.userHelper.AddUserAsync(user, model.Password);
                    if(result != IdentityResult.Success)
                    {
                        this.ModelState.AddModelError(string.Empty,"The user couldn't registered");
                        return View(model);
                    }
                    //await this.userHelper.AddUserToRoleAsync(user, "Admin");
                    await this.userHelper.AddUserToRoleAsync(user, "Teacher");
                    //await this.userHelper.AddUserToRoleAsync(user, "Student");
                    //await this.userHelper.AddUserToRoleAsync(user, "Coordinator");
                    var result2 = await this.userHelper.LoginAsync(
                        model.UserName,
                        model.Password,
                        true);
                    if(result2.Succeeded)
                    {
                        return this.RedirectToAction("Index","Home");
                    }
                    this.ModelState.AddModelError(string.Empty, "The user couldn't be login");
                    return View(model);

                }
                this.ModelState.AddModelError(string.Empty,"The username is already registered");
            }
            return View(model);
        }
    }
}
