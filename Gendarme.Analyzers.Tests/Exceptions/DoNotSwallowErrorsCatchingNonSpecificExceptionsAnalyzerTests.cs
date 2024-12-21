using Gendarme.Analyzers.Exceptions;
using Microsoft.CodeAnalysis.CSharp.Testing;
using Microsoft.CodeAnalysis.Testing;

namespace Gendarme.Analyzers.Tests.Exceptions;

[TestOf(typeof(DoNotSwallowErrorsCatchingNonSpecificExceptionsAnalyzer))]
public sealed class DoNotSwallowErrorsCatchingNonSpecificExceptionsAnalyzerTests
{
    [Fact(Skip = "not implemented")]
    public async Task Foo()
    {
        throw new NotImplementedException();
    }
}
