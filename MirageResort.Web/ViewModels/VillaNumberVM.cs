using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using MirageResort.Domain.Entities;

namespace MirageResort.Web.ViewModels
{
    public class VillaNumberVM
    {
       public VillaNumber VillaNumber { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem>? VillaList { get;set;}
    }
}
