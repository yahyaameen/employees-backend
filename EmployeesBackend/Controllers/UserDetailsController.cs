using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeesBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailsController : ControllerBase
    {
        private readonly EmployeesContext _context;

        public UserDetailsController(EmployeesContext context)
        {
            _context = context;
        }

        // POST: api/UserDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserDetail>> PostUserDetails(UserDetail userDetails)
        {
          if (_context.UserDetails == null)
          {
              return Problem("Entity set 'EmployeesContext.UserDetails'  is null.");
          }
            _context.UserDetails.Add(userDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserDetails", new { id = userDetails.Id }, userDetails);
        }
    }
}
