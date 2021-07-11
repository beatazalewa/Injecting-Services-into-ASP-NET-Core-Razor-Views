using DIIntoRazorViewsExample.Models;

namespace DIIntoRazorViewsExample.Services
{
    public class CatService : ICatService
    {
        public Cat GetName()
        {
            return new Cat { Name = "Simon" };
        }
    }
}
