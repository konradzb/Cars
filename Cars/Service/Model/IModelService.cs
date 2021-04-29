using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Cars.Service
{
    public interface IModelService
    {
        ModelDto AddModel(ModelInputDto modelInput);
        ActionResult<bool> DeleteModelById(int id);
        ActionResult<ModelDto> EditModelById(int id, ModelEditDto modelEditDto);
        IEnumerable<ModelDto> GetAllModels();
        ActionResult<ModelDto> GetModelById(int id);
    }
}
