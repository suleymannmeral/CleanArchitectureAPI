namespace CleanArhcitecture.Shared.GenericEmailService;

public sealed record EmailConfigurations(
 string Smtp,
 string Password,
 int Port,
 bool SSL = true,
 bool Html = true);
