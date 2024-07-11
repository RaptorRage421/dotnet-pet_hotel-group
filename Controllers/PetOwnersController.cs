using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using pet_hotel.Models;
using Microsoft.EntityFrameworkCore;

namespace pet_hotel.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetOwnersController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public PetOwnersController(ApplicationContext context) {
            _context = context;
        }

        // This is just a stub for GET / to prevent any weird frontend errors that 
        // occur when the route is missing in this controller
        [HttpGet]
        public IEnumerable<PetOwner> GetAll() {
            return _context.PetOwners;
            
        }

        [HttpPost]

    public PetOwner Post(PetOwner petOwner)
{

    _context.Add(petOwner);
    _context.SaveChanges();

    return petOwner;
    
}

    [HttpDelete("{id}")]
    public void Delete(int id) 
    {
        PetOwner petOwner = _context.PetOwners.Find(id);
        _context.PetOwners.Remove(petOwner);
        _context.SaveChanges();

    }
        // public void Delete(int id);

        // var petOwner = PetOwnersController.Get(id);

        // if (PetOwners is null)

    }
}

// [HttpDelete("{id}")]
//     public void Delete(int id) 
//     {
//         // Find the bread, by ID
//         Bread bread = _context.Breads.Find(id);

//         // Tell the DB that we want to remove this bread
//         _context.Breads.Remove(bread);

//         // ...and save the changes to the database
//         _context.SaveChanges();;
//     }


