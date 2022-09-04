using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApiClassText.MockData;


namespace WebApiClassText
{
    public class WineCollectionsController : ControllerBase
    {

        [HttpGet("winecollections")]
        public IActionResult GetWineCollection(string Name)
        {
            var winecollections = WineCollectionMockData.WineCollections();
            return Ok("winecollections");
        }

        [HttpGet("{Name}")]
        public IActionResult GetSingleWine(string Name)
        {
            var winecollections = WineCollectionMockData.WineCollections().Where(n => n.Name == Name).FirstOrDefault();
            return Ok("winecollections");
        }

        

    }
            
   
}
