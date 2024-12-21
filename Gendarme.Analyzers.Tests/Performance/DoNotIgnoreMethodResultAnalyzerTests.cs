using Gendarme.Analyzers.Performance;
using Microsoft.CodeAnalysis.CSharp.Testing;
using Microsoft.CodeAnalysis.Testing;

namespace Gendarme.Analyzers.Tests.Performance;

[TestOf(typeof(DoNotIgnoreMethodResultAnalyzer))]
public sealed class DoNotIgnoreMethodResultAnalyzerTests
{
    [Fact(Skip = "not implemented")]
    public async Task Foo()
    {
        throw new NotImplementedException();
    }
}