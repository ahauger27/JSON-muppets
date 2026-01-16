using System;

namespace JSON_muppets;

public class Muppet
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Species { get; set; }
    public string? Performer { get; set; }
    public string[]? Appearances { get; set; }
}
