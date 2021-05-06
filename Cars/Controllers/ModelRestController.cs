using Cars.Dtos;
using Cars.Model;
using Cars.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
/// Controller for Model Object
/// Controller operates on DTO's, it never returns obejct model itself
/// </summary>
namespace Cars.Controllers
{
    [ApiController]
    [Route("models")]
    public class ModelRestController : ControllerBase
    {
        private readonly IModelService modelService;
        public ModelRestController(IModelService modelService)
        {
            this.modelService = modelService;
        }
        [HttpGet]
        public IEnumerable<ModelDto> GetAllModels()
        {
            return modelService.GetAllModels();
        }

        [HttpGet("{id}")]
        public ActionResult<ModelDto> GetModelById(int id)
        {
            var model = modelService.GetModelById(id);
            if (model is null)
            {
                return NotFound();
            }
            return model;
        }
        [HttpPost]
        public ActionResult<ModelDto> AddModel(ModelInputDto modelInput)
        {
            ModelDto model = modelService.AddModel(modelInput);
            return CreatedAtAction(nameof(GetModelById), new { id = model.Id }, model);
        }
        [HttpPut("{id}")]
        public ActionResult<ModelDto> EditModelById(int id, ModelEditDto modelEditDto)
        {
            var model = modelService.EditModelById(id, modelEditDto);
            if (model is null)
            {
                return NotFound();
            }
            return CreatedAtAction(nameof(GetModelById), new { id = id }, model);
        }
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteBrandById(int id)
        {
            var model = modelService.DeleteModelById(id);
            if (model is null)
            {
                return NotFound();
            }
            return model;

        }
    }
}
