using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeopleHub.Domain.Entities;
using PeopleHub.Domain.Enums;
using PeopleHub.Domain.ValueObjects;
using PeopleHub.Infra.Data;

namespace PeopleHub.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly PeopleHubContext _context;

        public UsersController(PeopleHubContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById(Guid id)
        {
            var user = _context.Users.Include(u => u.Name)
                            .FirstOrDefault(u => u.Id.Equals(id));

            if(user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post()
        {
            var user = new User(Guid.NewGuid(), 
                                new Name("userName", "lastName"),
                                "user@mail.com", 
                                new DateTime(1991,1,1),
                                Gender.Male,
                                "http://photo.url/user.png");
            
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                
                return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
