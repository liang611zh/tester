using helperLab.Models.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace helperLab.Models.Northwind
{
    [MetadataType(typeof(ProductMetaData))]
    public partial class Product { }

    public class ProductMetaData
    {
        [HiddenInput(DisplayValue = false)]
        public object ProductID { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        [Display(Name = "Product Name")]
        [ExcludeLength(3, ErrorMessage = "Name should be less than 3 chars!")]
        public object ProductName { get; set; }

        [Required(ErrorMessage = "Unit price is required.")]
        [DataType(DataType.Currency)]
        [Display(Name = "Unit Price")]
        public object UnitPrice { get; set; }

        [ScaffoldColumn(false)]
        public object ReorderLevel { get; set; }

        [UIHint("CategoryDropDown")]
        [Display(Name = "Category")]
        public object CategoryID { get; set; }

        [UIHint("SupplierDropDown")]
        [Display(Name = "Supplier")]
        public object SupplierID { get; set; }

        [ScaffoldColumn(false)]
        public object UnitsInStock { get; set; }

        [ScaffoldColumn(false)]
        public string QuantityPerUnit { get; set; }

        [ScaffoldColumn(false)]
        public object UnitsOnOrder { get; set; }

        [ScaffoldColumn(false)]
        public bool Discontinued { get; set; }
    }
}