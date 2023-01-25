using FluentValidation;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json.Serialization;

namespace OCPI.Validation;

public abstract class JsonValidator<T> : AbstractValidator<T>
{
    public IRuleBuilderOptions<T, TProperty> JsonRuleFor<TProperty>(Expression<Func<T, TProperty>> expression)
    {
        if (expression.Body is not MemberExpression memberExpression)
            throw new ExpressionIsNotMemberException();

        var attribute = memberExpression.Member.GetAttribute<JsonPropertyNameAttribute>();

        return RuleFor(expression).Must(x => true).WithName(attribute.Name);
    }

    public class ExpressionIsNotMemberException : InvalidOperationException
    {
        public ExpressionIsNotMemberException()
            : base("Expression must be a member expression")
        { }
    }
}

internal static class MemberInfoExtensions
{
    public static TAttribute GetAttribute<TAttribute>(this MemberInfo member)
        where TAttribute : Attribute
    {
        var attribute = Attribute.GetCustomAttribute(member, typeof(JsonPropertyNameAttribute));
        if (attribute is null) throw new AttributeNotFoundException<TAttribute>(member.Name);
        return (attribute as TAttribute)!;
    }

    public class AttributeNotFoundException<TAttribute> : InvalidOperationException
    where TAttribute : Attribute
    {
        public AttributeNotFoundException(string propertyName)
            : base($"{nameof(TAttribute)} not found for property '{propertyName}'")
        { }
    }
}
