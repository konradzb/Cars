using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Repo
{
    public class FakeModelDao : IModelDao
    {
        private List<Model.Model> models = new();
        private int i;
        public FakeModelDao()
        {
            // IdFuelType: 1-petrol, 2-diesel, 3-gas, 4-electric
            // IdCarDrive: 1-FWD, 2-RWD, 3-AWD
            models.Add(new Model.Model(1, 1, "SUV", "GLC", 170, 2, 3));
            models.Add(new Model.Model(2, 1, "Coupe", "AMG GT", 560, 1, 2));
            models.Add(new Model.Model(3, 2, "Sedan", "Panamera", 440, 1, 3));
            models.Add(new Model.Model(4, 3, "Coupe", "458 Italia", 605, 1, 2));
            models.Add(new Model.Model(5, 4, "Coupe", "DB11", 608, 1, 2));
            models.Add(new Model.Model(6, 4, "Coupe", "DB9", 477, 1, 2));
            models.Add(new Model.Model(7, 5, "Coupe", "GranTurismo", 440, 1, 2));
            models.Add(new Model.Model(8, 6, "Sedan", "Model S", 525, 4, 3));
            models.Add(new Model.Model(9, 6, "SUV", "Model X", 572, 4, 3));
            models.Add(new Model.Model(10, 6, "Sedan", "Model 3", 285, 4, 2));
            i = models.Count;

        }
        public Model.Model AddModel(Model.Model model)
        {
            models.Add(model);
            return model;
        }

        public bool DeleteModelById(int id)
        {
            var modelToDelete = this.GetModelById(id);
            return models.Remove(modelToDelete);
        }

        public Model.Model EditModelById(Model.Model model)
        {
            int index = models.FindIndex(modelToEdit => modelToEdit.Id == model.Id);
            models[index] = model;
            return model;
        }

        public List<Model.Model> GetAllModels()
        {
            return models;
        }

        public Model.Model GetModelById(int id)
        {
            return models.Find(model => model.Id == id);
        }
    }
}
