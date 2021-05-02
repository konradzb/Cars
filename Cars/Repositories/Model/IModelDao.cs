using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Dtos;
/// <summary>
/// Dao - Data access object
/// </summary>
namespace Cars.Repo
{
    public interface IModelDao
    {
        List<Model.Model> GetAllModels();
        Model.Model GetModelById(int id);
        Model.Model AddModel(Model.Model model);
        Model.Model EditModelById(Model.Model model);
        bool DeleteModelById(int id);
    }
}
