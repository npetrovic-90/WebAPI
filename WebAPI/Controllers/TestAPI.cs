using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
	public class TestAPI : ControllerBase
	{
		public TestAPI()
		{

		}

		[HttpGet("api/user")]
		public IActionResult Get()
		{

			return Ok( new { name = "Nemanja" });
		}
	}
}
