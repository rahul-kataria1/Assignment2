using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class j1controller : ControllerBase
    {
        
        /// <summary>
        /// calculating the score of robot on the basis of number of deliveries and collisions.
        /// </summary>
        /// <param name="Collisions">number of collisions of robot</param>
        /// <param name="Deliveries">number of packages delivered</param>
        /// <returns>
        /// Returns the total score after calculating the number of collisions and deliveries.
        /// </returns>
        /// HEADER: Content-Type: application/x-www-form-urlencoded
        /// <example>
        /// "POST" -H "Content-Type: application/x-www-form-urlencoded" -d "Collisions=2&Deliveries=5" ".../api/J1/Delivedroid"
        /// Answer -> 730
        /// </example>
        /// <example>
        /// "POST" -H "Content-Type: application/x-www-form-urlencoded" -d "Collisions=5&Deliveries=4" ".../api/J1/Delivedroid"
        /// Answer -> 150
        /// </example>
        /// <example>
        /// "POST" -H "Content-Type: application/x-www-form-urlencoded" -d "Collisions=10&Deliveries=15" ".../api/J1/Delivedroid"
        /// Answer -> 1150
        /// </example>


        [HttpPost(template: "Delivedroid")]
        public int Delivedroid([FromForm] int Collisions, [FromForm] int Deliveries)
        {
            int totalDeliveries = 50 * Deliveries;
            int totalCollisions = 10 * Collisions;

            int total = totalDeliveries - totalCollisions;

            if (Deliveries > Collisions)
            {
                total = total + 500;
            }
            return total;
        }
    }
}