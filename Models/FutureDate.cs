using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace CSharp_Exam_Black.Models
{
public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if ((DateTime)value < DateTime.Now)
            return new ValidationResult("Activity Date must be in future");
        return ValidationResult.Success;
    }
}



}