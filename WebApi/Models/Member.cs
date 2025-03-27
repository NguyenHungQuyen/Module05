namespace WebApi.Models;
public class Member
{
    public string MemberId { get; set; } = null!;
    public string GivenName { get; set; } = null!;
    public string? Surname { get; set; }
    public string Email { get; set; } = null!;
    public byte[] Password { get; set; } = null!;
    public DateTime LoginDate { get; set; }
    public DateTime RegisterDate { get; set; }
}
