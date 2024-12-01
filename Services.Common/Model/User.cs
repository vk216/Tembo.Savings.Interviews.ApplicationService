namespace Services.Common.Abstractions.Model;

public class User
{
    public Guid Id { get; init; }
    public bool? IsVerified { get; set; }
    public string ForeName { get; init; }
    public string SurName { get; init; }
    public DateOnly DateOfBirth { get; init; }
    public string Nino { get; init; }
    public Address[] Addresses { get; init; }
    public BankAccount[] BankAccounts { get; init; }
}