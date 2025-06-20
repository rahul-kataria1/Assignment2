using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class j2Controller : ControllerBase
    {

        /// <summary>
        /// Displays the chili's overall level of spice in the 'Scolville Heat Units'.
        /// </summary>
        /// <param name="ChiliPeppers">The names of all the chili peppers used separated by a comma.</param>
        /// <returns>
        /// This will returns the total level of spiciness of chili in the SHU value
        /// </returns>
        /// <example>
        /// "GET" api/J2/ChiliPeppers?Ingredients=Habanero%2CPoblano%2CThai -> 201500
        /// </example>
        /// <example>
        /// "GET" api/J2/ChiliPeppers?Ingredients=Thai%2CCayenne%2CSerrano -> 130500
        /// </example>
        /// <example>
        /// "GET" api/J2/ChiliPeppers?Ingredients=Thai%2CMirasol%2CHabanero -> 206000
        /// </example>

        [HttpGet(template: "ChiliPeppers")]

        public int ChiliPeppers(String Ingredients)
        {
            int spiceLevel = 0;
            string[] spiceArray = Ingredients.Split(",");

            for (int i = 0; i < spiceArray.Length; i++)
            {
                if (spiceArray[i] == "Poblano")
                {
                    spiceLevel = spiceLevel + 1500;
                }
                if (spiceArray[i] == "Mirasol")
                {
                    spiceLevel = spiceLevel + 6000;
                }
                if (spiceArray[i] == "Serrano")
                {
                    spiceLevel = spiceLevel + 15500;
                }
                if (spiceArray[i] == "Cayenne")
                {
                    spiceLevel = spiceLevel + 40000;
                }
                if (spiceArray[i] == "Thai")
                {
                    spiceLevel = spiceLevel + 75000;
                }
                if (spiceArray[i] == "Habanero")
                {
                    spiceLevel = spiceLevel + 125000;
                }

            }
                return spiceLevel;
        }
    }
}