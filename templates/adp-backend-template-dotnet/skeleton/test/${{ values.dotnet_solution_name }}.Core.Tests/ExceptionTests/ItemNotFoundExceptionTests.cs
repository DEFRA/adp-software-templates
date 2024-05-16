using ${{ values.dotnet_solution_name }}.Core.Exceptions;
using FluentAssertions;

namespace ${{ values.dotnet_solution_name }}.Core.Tests.ExceptionTests;

[TestFixture]
public class ItemNotFoundExceptionTests
{
    [Test]
    public void ItemNotFoundExceptionTests_Creates_Exceptions()
    {
        var exception = new ItemNotFoundException("Error");
        exception.Should().BeAssignableTo<Exception>();
        exception.Message.Should().Be("Error");
    }

    [Test]
    public void ItemNotFoundExceptionTests_Creates_Exception_With_ParentException()
    {
        var exception = new ItemNotFoundException("Error", new Exception("Parent error"));
        exception.Should().BeAssignableTo<Exception>();
        exception.Message.Should().Be("Error");
    }
}