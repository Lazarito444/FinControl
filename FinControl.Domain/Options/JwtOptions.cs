namespace FinControl.Domain.Options;

public class JwtOptions
{
    public const string SectionName = "Jwt";
    public string[] Issuers { get; set; } = [];
    public string[] Audiences { get; set; } = [];
    public int ExpiryMinutes { get; set; }
    public string SecretKey { get; set; } = string.Empty;
}
