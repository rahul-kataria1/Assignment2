using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class j1sushiController : ControllerBase
    {
        [HttpPost(template:"Sushi")]
        public int sushiCost([FromForm] int red, [FromForm] int green, [FromForm] int blue)
        {
            /// <summary>
        /// Counts the total billing amount considering Red, Green, and Blue Plates with their equivalent cost.
        /// </summary>
        /// <param name="red">red has default cost of $3.</param>
        /// <param name="green">green has default cost of $4.</param>
        /// <param name="blue">blue has default cost of $5.</param>
        /// <returns>
        /// This will returns the total amount of billing after calculating the number of plates used.
        /// </returns>
        /// <example>
        /// "POST" -H "Content-Type: application/x-www-form-urlencoded" -d "red=2&green=3&blue=4" ".../api/J1/Delivedroid"
        /// Answer -> 38
        /// </example>
        /// <example>
        /// "POST" -H "Content-Type: application/x-www-form-urlencoded" -d "red=2&green=6&blue=1" ".../api/J1/Delivedroid"
        /// Answer -> 35
        /// </example>
        /// <example>
        /// "POST" -H "Content-Type: application/x-www-form-urlencoded" -d "red=10&green=2&blue=7" ".../api/J1/Delivedroid"
        /// Answer -> 73
        /// </example>
            int redCost = 3;
            int greenCost = 4;
            int blueCost = 5;

            int totalCost = (red * redCost) + (green * greenCost) + (blue * blueCost);
            return totalCost;
        }
    }
}
