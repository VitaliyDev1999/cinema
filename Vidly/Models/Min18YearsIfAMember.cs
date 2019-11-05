﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Vidly.Models
{
    //custom validation
    public class Min18YearsIfAMember: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.MembershipTypeId == MembershipType.Unknown ||customer.MembershipTypeId == MembershipType.PayAsYouGo)
               return ValidationResult.Success;

            if (customer.Birthdate == null)
                return new ValidationResult("Birthday is required");

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return (age > 18) 
                ? ValidationResult.Success 
                : new ValidationResult("You must be older than 18");
        }
    }
}