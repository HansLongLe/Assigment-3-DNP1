using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Server.Data.DataAccess;
using Server.Data.DataAccess.DatabaseAccess;
using Server.Data.Models;
using Server.Logic;

namespace Server.Controllers
{
    [Route("[controller]s")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IVerifier _verifier;
        private readonly IUserDatabaseRepository _userDatabaseRepository;

        public UserController(IVerifier verifier, DataFactory dataFactory)
        {
            _verifier = verifier;
            _userDatabaseRepository = dataFactory.UserDatabaseRepository;
        }
        
        
        [HttpPost]
        public ActionResult UserLogin(User user)
        {
            try
            {
                if (user == null)
                {
                    return BadRequest();
                }

                return Ok(_verifier.Authorize(user.Username, user.Password));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpGet]
        public ActionResult GetUsers()
        {
            try
            {
                return Ok(_userDatabaseRepository.GetUsers());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
    }
}