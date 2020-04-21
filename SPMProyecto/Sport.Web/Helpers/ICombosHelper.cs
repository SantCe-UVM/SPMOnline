namespace Sport.Web.Helpers
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Collections.Generic;

    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboCategories();
    }
}
