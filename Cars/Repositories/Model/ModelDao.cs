using Cars.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Repo
{
    public class ModelDao : IModelDao
    {
        private readonly ApplicationDbContext _dbContext;
        public ModelDao(ApplicationDbContext db)
        {
            _dbContext = db;
        }
        public Model.Model AddModel(Model.Model model)
        {
            _dbContext.Models.Add(model);
            _dbContext.SaveChanges();
            return model;
        }

        public bool DeleteModelById(int id)
        {
            throw new NotImplementedException();
        }

        public Model.Model EditModelById(Model.Model model)
        {
            _dbContext.Models.Update(model);
            _dbContext.SaveChanges();
            return model;
        }

        public List<Model.Model> GetAllModels()
        {
            return _dbContext.Models.OrderBy(m => m.Id).ToList();
        }

        public Model.Model GetModelById(int id)
        {
            return _dbContext.Models.OrderBy(m => m.Id==id).FirstOrDefault();
        }
    }
}
