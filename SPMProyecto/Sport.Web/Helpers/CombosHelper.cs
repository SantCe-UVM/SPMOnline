using Microsoft.AspNetCore.Mvc.Rendering;
using Sport.Web.Data;
using System.Collections.Generic;
using System.Linq;

namespace Sport.Web.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext dataContext;

        public CombosHelper(DataContext dataContext) 
        {
            this.dataContext = dataContext;
        }

        public IEnumerable<SelectListItem> GetComboCategories()
        {
            var list = dataContext.Categories.Select(
                c=> new SelectListItem 
                {
                    Text = c.Name,
                    Value =  $"{c.Id}"
                }).ToList();
            list.Insert(0, new SelectListItem
            {
                Text="[debe seleccionar una categoria...]",
                Value="0"
            });
            return list;
        }
    }
}
