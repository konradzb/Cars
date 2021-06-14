using Cars.Dtos;
using Cars.Model;
using Cars.Repo;
using Cars.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Service
{
    public class ModelService : IModelService
    {
        private readonly IModelDao modelsDao;
        public ModelService(IModelDao modelsDao)
        {
            this.modelsDao = modelsDao;
        }
        public ModelDto AddModel(ModelInputDto modelInput)
        {
            int id = 0;
            Model.Model model = new Model.Model(
                id,
                modelInput.BrandId,
                modelInput.Type,
                modelInput.Name,
                modelInput.Power,
                modelInput.IdFuelType,
                modelInput.IdCarDrive
            );
            return modelsDao.AddModel(model).AsDto(); ;
        }

        public ActionResult<bool> DeleteModelById(int id)
        {
            var modelToDelete = modelsDao.GetModelById(id);
            if (modelToDelete is null)
            {
                return null;
            }
            return modelsDao.DeleteModelById(id);
        }

        public ActionResult<ModelDto> EditModelById(int id, ModelEditDto modelEditDto)
        {
            var modelToEdit = modelsDao.GetModelById(id);
            if (modelToEdit is null)
            {
                return null;
            }

            Model.Model editModel = modelToEdit with
            {
                BrandId = modelEditDto.BrandId,
                Type = modelEditDto.Type,
                Name = modelEditDto.Name,
                Power = modelEditDto.Power,
                FuelTypeId = modelEditDto.IdFuelType,
                CarDriveId = modelEditDto.IdCarDrive
            };
            return modelsDao.EditModelById(editModel).AsDto();
        }

        public IEnumerable<ModelDto> GetAllModels()
        {
            var models = modelsDao.GetAllModels().ConvertAll(model => model.AsDto());
            return models;
        }

        public ActionResult<ModelDto> GetModelById(int id)
        {
            var model = modelsDao.GetModelById(id);
            if (model is null)
            {
                return null;
            }
            return model.AsDto();
        }
    }
}
