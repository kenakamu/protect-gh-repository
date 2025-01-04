# Class
When creating class, follow the rules below.

- Add summary for class
- Do NOT nest namespace.
- Add ILogger<T> as Dependency Injection.
- For model class, do not use any dependency injection nor constructor.
- Do NOT use underscore (_) for private fields.
- Use primary constructor
- Use appropriate folders such as Models, Services, etc and use hiererchy namespace.

# Usings
Always use global using in Usings.cs

# JSON to Class
When a developer asks to generate a class based on the actual JSON, follow the rules below.

- Use [JsonPropertyName("<original-name>")] attribute for each property.
- Use C# syntax for the property names.
- Set default value based on C# 12 syntax.
- Use List<T> rather than array type.
- Follow class rules above for other things.