using System.Collections.Generic;


namespace SalesWebMvc.Models.View_Models
{
    public class SellerFormViewModel
    {
        public Sellers Sellers { get; set; }
        public ICollection<Department> Departments { get; set; }


    }
}
