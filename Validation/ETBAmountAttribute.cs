using System.ComponentModel.DataAnnotations;

namespace AddisEats.Api.Validation;

public class ETBAmountAttribute : ValidationAttribute
{
    public ETBAmountAttribute()
    {
        ErrorMessage = "Total amount must be a positive ETB value.";
    }

    protected override ValidationResult? IsValid(
        object? value,
        ValidationContext validationContext)
    {
        if (value is null)
        {
            return ValidationResult.Success;
        }

        if (value is decimal amount)
        {
            if (amount <= 0)
            {
                return new ValidationResult("Amount must be greater than 0 ETB.");
            }

            return ValidationResult.Success;
        }

        if (decimal.TryParse(value.ToString(), out var parsedAmount))
        {
            if (parsedAmount <= 0)
            {
                return new ValidationResult("Amount must be greater than 0 ETB.");
            }

            return ValidationResult.Success;
        }

        return new ValidationResult(ErrorMessage ?? "Total amount must be a valid ETB value.");
    }
}
