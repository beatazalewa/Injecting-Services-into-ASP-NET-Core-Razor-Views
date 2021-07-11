using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIIntoRazorViewsExample.Models;

namespace DIIntoRazorViewsExample.Services
{
    public interface ICatService
    {
        Cat GetName();
    }
}
