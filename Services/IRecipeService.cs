using CIS174_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_Project.Services
{
    public interface IRecipeService
    {
        int CreateRecipe(RecipeViewModel cmd);
        ICollection<RecipeSummaryViewModel> GetRecipes();
        RecipeDetailViewModel GetRecipeDetail(int id);
        UpdateRecipeCommand UpdateRecipe(UpdateRecipeCommand cmd);
        bool DeleteRecipe(int id);

    }
}

