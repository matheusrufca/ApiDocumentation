using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiDocumentation.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SampleController : ControllerBase
	{
		/// <summary>
		/// List all items.
		/// </summary>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		/// <summary>
		/// Get a specific item.
		/// </summary>
		[HttpGet("{id}", Name = "Get")]
		public string Get(int id)
		{
			return "value";
		}

		/// <summary>
		/// Add a specific item.
		/// </summary>
		/// /// <remarks>
		/// Sample request:
		///
		///     POST /Todo
		///     {
		///        "id": 1,
		///        "name": "Item1",
		///        "isComplete": true
		///     }
		///
		/// </remarks>
		/// <param name="item"></param>
		/// <returns>A newly created TodoItem</returns>
		/// <response code="201">Returns the newly created item</response>
		/// <response code="400">If the item is null</response>       
		[HttpPost]
		[ProducesResponseType(201)]
		[ProducesResponseType(400)]
		public void Post([FromBody] string value)
		{
		}

		// PUT: api/Sample/5
		/// <summary>
		/// Edit a specific item.
		/// </summary>
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE: api/ApiWithActions/5
		/// <summary>
		/// Deletes a specific TodoItem.
		/// </summary>
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
