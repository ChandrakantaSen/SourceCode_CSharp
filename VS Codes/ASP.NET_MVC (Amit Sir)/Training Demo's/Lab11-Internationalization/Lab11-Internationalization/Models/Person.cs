using Lab11_Internationalization.LocalResource;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab11_Internationalization.Models
{
    public class Person
    {
        [Display(Name = "FirstName", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "ReqFName")]
        public string FirstName { get; set; }

        [Display(Name = "LastName", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "ReqLName")]
        public string LastName { get; set; }

        [Display(Name = "Age", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "ReqAge")]
        public int Age { get; set; }

        [Display(Name = "Email", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "ReqEmail")]
        [RegularExpression(".+@.+\\..+", ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "InvalidEmail")]
        public string Email { get; set; }
    }
}