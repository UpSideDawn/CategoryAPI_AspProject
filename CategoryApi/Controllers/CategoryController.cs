using Microsoft.AspNetCore.Mvc;
using Business.Implementation;
using Business.Interface;
using DataTransfertObject.DTO;

namespace CategoryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private IServiceManager _serviceManager;

        public CategoryController(IServiceManager serviceManager)     //Ligne liant l'implémentation et l'interface
        {
            _serviceManager = serviceManager;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var retour = await _serviceManager.CategorieService.RecupererListeCategorie();

            return Ok(retour);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            
            try
            {
                var retour = await _serviceManager.CategorieService.RecupererCategorieParId(id);

                return Ok(retour);

                
            }
            catch(Exception ex)
            {
                return BadRequest(500);
            }
            //Appeler service Vin avec methode RecupererListeVin()
          
        }

        [HttpPut]
        public async Task<IActionResult> Modify(CategorieDTO categorieDTO)
        {

            var retour =  await _serviceManager.CategorieService.ModifierCategorie(categorieDTO);

           /* if (retour == (int)EnumErreurs.EtagereNonTrouvee)
            {
                return StatusCode(500);

            }
            if (retour == (int)EnumErreurs.ErreurSauvegardeEnBDD)
            {
                return StatusCode(500);
            }
           */
            return Ok(retour + " lignes modifiées.");

        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CategorieDTO categorieDTO)             //IActionResult est une reponse Http de notre WebApi (ActionResult a sa place uniquement ici)
        {

            var retour = await _serviceManager.CategorieService.CreerCategorie(categorieDTO);

            return CreatedAtAction("Get", new { id = categorieDTO.Id }, categorieDTO);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var retour = await _serviceManager.CategorieService.SupprimerCategorie(id);

            return Ok(retour);
        }
    }
}
