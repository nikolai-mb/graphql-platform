namespace HotChocolate.Types;

[ExtendObjectType<Person>]
public class PersonLastName
{
    public string LastName { get; } = default!;
}