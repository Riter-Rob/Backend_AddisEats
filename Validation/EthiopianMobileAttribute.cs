using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace AddisEats.Api.Validation;

public class EthiopianMobileAttribute : ValidationAttribute
{
    private static readonly Regex Pattern =
        new(@"^(?:\+251|0)(?:9|7)\d{8}$",
            RegexOptions.Compiled);

    public EthiopianMobileAttribute()
    {
        ErrorMessage = "Enter a valid Ethiopian mobile number.";
    }

    protected override ValidationResult? IsValid(
        object? value,
        ValidationContext validationContext)
    {
        if (value is null || string.IsNullOrWhiteSpace(value.ToString()))
        {
            return ValidationResult.Success;
        }

        var phoneNumber = value.ToString()!.Trim();

        if (Pattern.IsMatch(phoneNumber))
        {
            return ValidationResult.Success;
        }

        return new ValidationResult(ErrorMessage ?? "Enter a valid Ethiopian mobile number.");
    }
}