using Gendarme.Analyzers.Interoperability;
using Microsoft.CodeAnalysis.CSharp.Testing;
using Microsoft.CodeAnalysis.Testing;

namespace Gendarme.Analyzers.Tests.Interoperability;

[TestOf(typeof(GetLastErrorMustBeCalledRightAfterPInvokeAnalyzer))]
public sealed class GetLastErrorMustBeCalledRightAfterPInvokeAnalyzerTests
{
    [Fact(Skip = "not implemented")]
    public async Task Foo()
    {
        throw new NotImplementedException();
    }
}
