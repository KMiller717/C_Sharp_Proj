using System.ComponentModel.DataAnnotations;
using System;
using System.Globalization;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;


namespace CSharp_Exam_Black.Models
{
public class CustomerPasswordAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
    bool validPassword = false;
    string reason = String.Empty;
    string Password = value == null ? String.Empty : value.ToString();
    if (String.IsNullOrEmpty(Password) || Password.Length < 8) 
    {
        reason = "Your new password must be at least 8 characters long. ";
    } 
    else
    {
        Regex reSymbol = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
        if (!reSymbol.IsMatch(Password)) 
        {
            reason += "Your new password must contain at least 1 number, character & special character .";
        } 
        else
        {
            validPassword = true;
        }
    }
    if (validPassword) 
    {
        return ValidationResult.Success;
    } 
    else
    {
        return new ValidationResult(reason);
    }
    }
}



}