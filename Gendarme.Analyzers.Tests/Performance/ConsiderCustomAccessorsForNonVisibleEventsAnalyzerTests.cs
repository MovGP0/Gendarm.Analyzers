using Gendarme.Analyzers.Performance;
using Microsoft.CodeAnalysis.CSharp.Testing;
using Microsoft.CodeAnalysis.Testing;

namespace Gendarme.Analyzers.Tests.Performance;

[TestOf(typeof(ConsiderCustomAccessorsForNonVisibleEventsAnalyzer))]
public sealed class ConsiderCustomAccessorsForNonVisibleEventsAnalyzerTests
{
    [Fact(Skip = "not implemented")]
    public async Task Foo()
    {
        throw new NotImplementedException();
    }
}
