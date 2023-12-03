using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Raythos_Aerospace.Areas.Identity.Data;

// Add profile data for application users by adding properties to the Raythos_AerospaceUser class
public class Raythos_AerospaceUser : IdentityUser
{

    public string FirstName { get; set; }
    public string LastName { get; set; }
}

