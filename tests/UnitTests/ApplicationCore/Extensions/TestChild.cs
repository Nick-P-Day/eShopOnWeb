using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.eShopWeb.UnitTests.ApplicationCore.Extensions;

[DebuggerDisplay("Id={Id}, Date={Date}")]
public class TestChild : IEquatable<TestChild>
{
    public DateTime Date { get; set; } = DateTime.UtcNow;
    public Guid Id { get; set; } = Guid.NewGuid();

    public bool Equals([AllowNull] TestChild other) =>
        other?.Date == Date && other?.Id == Id;
}
