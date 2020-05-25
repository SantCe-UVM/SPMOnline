﻿namespace School.Web.Helpers
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using School.Web.Data;
    using System.Collections.Generic;
    using System.Linq;

    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext dataContext;

        public CombosHelper(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public IEnumerable<SelectListItem> GetComboGenders()
        {
            var list = dataContext.Genders.Select(
                c => new SelectListItem
                {
                    Text = c.Name,
                    Value = $"{c.Id}"
                }).ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "[debe seleccionar un género...]",
                Value = "0"
            });
            return list;
        }
    }
}
