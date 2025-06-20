using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class j2donutController : ControllerBase
    {
        /// <summary>
        /// Displays the total donuts remaining at the end of day when closing the store.
        /// </summary>
        /// <param name="start">Show the number donuts from yesterday stock.</param>
        /// <param name="events">Total events happened all over the day</param>
        /// <param name="signs">If-else statement used on the basis of signs, if + sign then add the donuts and if - sign then subtract the donuts which has been sold.</param>
        /// <param name="numbers">number of donuts sold all over the day.</param>
        /// <returns>
        /// This will returns the total level of spiciness of chili in the SHU value
        /// </returns>
        [HttpPost(template: "Donut")]
        public int donutLeft([FromForm] int start, [FromForm] int events, [FromForm] string[] signs, [FromForm] int[] numbers)
        {
            int donuts = start;

            for (int i = 0; i < events; i++)
            {
                if (signs[i] == "+")
                {
                    donuts = donuts + numbers[i];
                }
                else if (signs[i] == "-")
                {
                    donuts = donuts - numbers[i];
                }
            }

            return donuts;
        }
    }
}
