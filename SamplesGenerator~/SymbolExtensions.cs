using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;

namespace Roots.Samples
{
    public static class SymbolExtensions
    {
        public static bool IsElement(this ITypeSymbol typeSymbol)
        {
            if(typeSymbol is not INamedTypeSymbol { IsValueType: true } namedTypeSymbol)
            {
                return false;
            }
            
            if (namedTypeSymbol.IsGenericType || namedTypeSymbol.Interfaces.Length > 0)
            {
                return false;
            }
            
            var fullName = typeSymbol.GetFullName(false);
            return fullName is "RishUI.Element";
        }
        
        public static bool IsRishElement(this ITypeSymbol typeSymbol)
        {
            if(typeSymbol is not INamedTypeSymbol { IsReferenceType: true })
            {
                return false;
            }
            
            var baseTypeSymbol = typeSymbol.BaseType;
            if (baseTypeSymbol == null)
            {
                return false;
            }
            
            var baseTypeFullName = baseTypeSymbol.GetFullName(false);
            return baseTypeFullName == "RishUI.RishElement";
        }
        
        public static bool IsVisualElement(this ITypeSymbol typeSymbol)
        {
            if(typeSymbol is not INamedTypeSymbol { IsReferenceType: true })
            {
                return false;
            }

            foreach (var interfaceTypeSymbol in typeSymbol.Interfaces)
            {
                var interfaceTypeFullName = interfaceTypeSymbol.GetFullName(false);
                if (interfaceTypeFullName == "RishUI.IVisualElement")
                {
                    return true;
                }
            }
            
            return false;
        }
        
        public static bool IsInternallyAccessible(this ITypeSymbol typeSymbol)
        {
            var containingType = typeSymbol.ContainingType;
            while (containingType != null)
            {
                if (!containingType.IsInternallyAccessible())
                {
                    return false;
                }

                containingType = containingType.ContainingType;
            }
            
            if (typeSymbol is ITypeParameterSymbol)
            {
                return true;
            }
            
            return typeSymbol.DeclaredAccessibility is Accessibility.Public or Accessibility.ProtectedOrInternal or Accessibility.Internal;
        }
        
        public static bool IsPubliclyAccessible(this ITypeSymbol typeSymbol)
        {
            var containingType = typeSymbol.ContainingType;
            while (containingType != null)
            {
                if (!containingType.IsPubliclyAccessible())
                {
                    return false;
                }

                containingType = containingType.ContainingType;
            }
            
            if (typeSymbol is ITypeParameterSymbol)
            {
                return true;
            }
            
            return typeSymbol.DeclaredAccessibility is Accessibility.Public;
        }
        
        public static string GetDefault(this ITypeSymbol typeSymbol) => $"default({typeSymbol.GetFullName(true)})";

        public static string GetFullName(this ITypeSymbol typeSymbol, bool includeGenerics)
        {
            if (typeSymbol == null)
            {
                return string.Empty;
            }
            
            var name = typeSymbol.Name;
            if (typeSymbol is ITypeParameterSymbol)
            {
                return name;
            }

            if (includeGenerics)
            {
                var genericName = typeSymbol.GetGenericsName(false);
                if (!string.IsNullOrWhiteSpace(genericName))
                {
                    name = $"{name}{genericName}";
                }
            }

            var containingType = typeSymbol.ContainingType;
            if (containingType != null)
            {
                return $"{containingType.GetFullName(includeGenerics)}.{name}";
            }

            var containingNamespace = typeSymbol.ContainingNamespace;
            if (containingNamespace == null || containingNamespace.IsGlobalNamespace)
            {
                return name;
            }

            return $"{typeSymbol.ContainingNamespace}.{name}";
        }
        
        public static bool IsGenericDefinition(this ITypeSymbol typeSymbol)
        {
            var containingType = typeSymbol.ContainingType;
            while(containingType != null)
            {
                if (containingType.Arity <= 0)
                {
                    continue;
                }

                var containingTypeArguments = containingType.TypeArguments;
                for(int i = 0, n = containingTypeArguments.Length; i < n; i++)
                {
                    var typeArgument = containingTypeArguments[i];
                    if (typeArgument is not ITypeParameterSymbol)
                    {
                        return false;
                    }
                }
                containingType = containingType.ContainingType;
            }
            
            if (typeSymbol is not INamedTypeSymbol { Arity: > 0 } namedTypeSymbol) return false;

            var typeArguments = namedTypeSymbol.TypeArguments;
            for(int i = 0, n = typeArguments.Length; i < n; i++)
            {
                var typeArgument = typeArguments[i];
                if (typeArgument is not ITypeParameterSymbol)
                {
                    return false;
                }
            }
                
            return true;
        }
        public static bool HasGenericParameters(this ITypeSymbol typeSymbol)
        {
            if (typeSymbol is not INamedTypeSymbol { Arity: > 0 } namedTypeSymbol) return false;
            
            var typeArguments = namedTypeSymbol.TypeArguments;
            for(int i = 0, n = typeArguments.Length; i < n; i++)
            {
                var typeArgument = typeArguments[i];
                if (typeArgument is ITypeParameterSymbol)
                {
                    return true;
                }
            }
                
            return false;
        }
        
        public static string GetGenericsName(this ITypeSymbol typeSymbol, bool containingTypes)
        {
            var genericTypes = typeSymbol.GetGenericsTypes(containingTypes);
            if (!string.IsNullOrWhiteSpace(genericTypes))
            {
                genericTypes = $"<{genericTypes}>";
            }

            return genericTypes;
        }

        public static bool IsGeneric(this ITypeSymbol typeSymbol) => typeSymbol.GetGenericsTypes(true).Length > 0;
        
        private static string GetGenericsTypes(this ITypeSymbol typeSymbol, bool containingTypes)
        {
            string genericTypes = null;

            if (containingTypes)
            {
                var containingType = typeSymbol.ContainingType;
                if (containingType != null)
                {
                    genericTypes = containingType.GetGenericsTypes(true);
                }
            }

            var hasGenericTypes = !string.IsNullOrWhiteSpace(genericTypes);
            
            if (typeSymbol is INamedTypeSymbol { Arity: > 0 } namedTypeSymbol)
            {
                var typeArguments = namedTypeSymbol.TypeArguments;
                for (int i = 0, n = typeArguments.Length; i < n; i++)
                {
                    var typeArgument = typeArguments[i];
                    var typeArgumentFullName = typeArgument.GetFullName(true);
                    genericTypes = $"{genericTypes}{(hasGenericTypes ? ", " : string.Empty)}{typeArgumentFullName}";

                    hasGenericTypes = true;
                }
            }

            return genericTypes;
        }
        
        public static string GetGenericsParametersName(this ITypeSymbol typeSymbol, bool containingTypes)
        {
            var genericTypes = typeSymbol.GetGenericsParameters(containingTypes);
            if (!string.IsNullOrWhiteSpace(genericTypes))
            {
                genericTypes = $"<{genericTypes}>";
            }

            return genericTypes;
        }
        
        private static string GetGenericsParameters(this ITypeSymbol typeSymbol, bool containingTypes)
        {
            string genericTypes = null;

            if (containingTypes)
            {
                var containingType = typeSymbol.ContainingType;
                if (containingType != null)
                {
                    genericTypes = containingType.GetGenericsTypes(true);
                }
            }

            var hasGenericTypes = !string.IsNullOrWhiteSpace(genericTypes);
            
            if (typeSymbol is INamedTypeSymbol { Arity: > 0 } namedTypeSymbol)
            {
                var typeArguments = namedTypeSymbol.TypeArguments;
                for (int i = 0, n = typeArguments.Length; i < n; i++)
                {
                    var typeArgument = typeArguments[i];
                    if (typeArgument is not ITypeParameterSymbol typeParameter)
                    {
                        continue;
                    }
                    var typeArgumentFullName = typeParameter.GetFullName(true);
                    genericTypes = $"{genericTypes}{(hasGenericTypes ? ", " : string.Empty)}{typeArgumentFullName}";

                    hasGenericTypes = true;
                }
            }

            return genericTypes;
        }
        
        public static string GetGenericsConstraints(this ITypeSymbol typeSymbol, bool containingTypes)
        {
            string constraintsString = null;

            if (containingTypes)
            {
                var containingType = typeSymbol.ContainingType;
                if (containingType != null)
                {
                    constraintsString = containingType.GetGenericsConstraints(true);
                }
            }

            if (typeSymbol is INamedTypeSymbol { Arity: > 0 } namedTypeSymbol)
            {
                var typeArguments = namedTypeSymbol.TypeArguments;
                for(int i = 0, n = typeArguments.Length; i < n; i++)
                {
                    var typeArgument = typeArguments[i];
                    var hasConstraints = false;
                    if (typeArgument is not ITypeParameterSymbol typeParameter)
                    {
                        continue;
                    }

                    var parameterConstraints = $" where {typeParameter.Name} : ";

                    if (typeParameter.HasNotNullConstraint)
                    {
                        parameterConstraints = $"{parameterConstraints}notnull";
                        hasConstraints = true;
                    }

                    if (typeParameter.HasReferenceTypeConstraint)
                    {
                        parameterConstraints = $"{parameterConstraints}{(hasConstraints ? ", " : string.Empty)}class";
                        hasConstraints = true;
                    } else if (typeParameter.HasUnmanagedTypeConstraint)
                    {
                        parameterConstraints = $"{parameterConstraints}{(hasConstraints ? ", " : string.Empty)}unmanaged";
                        hasConstraints = true;
                    } else if (typeParameter.HasValueTypeConstraint)
                    {
                        parameterConstraints = $"{parameterConstraints}{(hasConstraints ? ", " : string.Empty)}struct";
                        hasConstraints = true;
                    }

                    var constraintTypes = typeParameter.ConstraintTypes;
                    foreach (var constraintType in constraintTypes)
                    {
                        var constraintFullName = constraintType.GetFullName(true);
                        parameterConstraints = $"{parameterConstraints}{(hasConstraints ? ", " : string.Empty)}{constraintFullName}";
                        hasConstraints = true;
                    }

                    if (typeParameter.HasConstructorConstraint)
                    {
                        parameterConstraints = $"{parameterConstraints}{(hasConstraints ? ", " : string.Empty)}new()";
                        hasConstraints = true;
                    }

                    if (hasConstraints)
                    {
                        constraintsString = $"{constraintsString}{parameterConstraints}";
                    }
                }
            }

            return constraintsString;
        }
        
        public static bool HasAttribute(this ISymbol typeSymbol, string fullName)
        {
            foreach (var attributeData in typeSymbol.GetAttributes())
            {
                var attributeClass = attributeData.AttributeClass;
                while (attributeClass != null)
                {
                    var attributeFullName = attributeClass.GetFullName(false);
                    if (attributeFullName == fullName)
                    {
                        return true;
                    }
            
                    attributeClass = attributeClass.BaseType;
                }
            }

            return false;
        }
        
        public static ImmutableArray<TypedConstant> GetAttributeArguments(this ISymbol typeSymbol, string fullName)
        {
            foreach (var attributeData in typeSymbol.GetAttributes())
            {
                var attributeClass = attributeData.AttributeClass;
                while (attributeClass != null)
                {
                    var attributeFullName = attributeClass.GetFullName(false);
                    if (attributeFullName == fullName)
                    {
                        return attributeData.ConstructorArguments;
                    }
            
                    attributeClass = attributeClass.BaseType;
                }
            }

            return default;
        }

        public static bool IsFlaggedAsRishValueType(this ITypeSymbol typeSymbol) => typeSymbol.HasAttribute("RishUI.RishValueTypeAttribute");
        
        public static bool IsFlaggedForAutoComparer(this ITypeSymbol typeSymbol)
        {
            if (typeSymbol.HasAttribute("RishUI.AutoComparerAttribute"))
            {
                return true;
            }

            if (typeSymbol.IsTupleType || typeSymbol.NullableAnnotation == NullableAnnotation.Annotated)
            {
                foreach (var member in typeSymbol.GetMembers())
                {
                    if (member is not IFieldSymbol { DeclaredAccessibility: Accessibility.Public } fieldSymbol)
                    {
                        continue;
                    }

                    var fieldType = fieldSymbol.Type;

                    if (IsFlaggedForAutoComparer(fieldType))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        
        public static bool IsFlaggedForCustomComparer(this ITypeSymbol typeSymbol)
        {
            if (typeSymbol.HasAttribute("RishUI.CustomComparerAttribute"))
            {
                return true;
            }

            if (typeSymbol.IsTupleType || typeSymbol.NullableAnnotation == NullableAnnotation.Annotated)
            {
                foreach (var member in typeSymbol.GetMembers())
                {
                    if (member is not IFieldSymbol { DeclaredAccessibility: Accessibility.Public } fieldSymbol)
                    {
                        continue;
                    }

                    var fieldType = fieldSymbol.Type;

                    if (IsFlaggedForCustomComparer(fieldType))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        
        public static string ToModifiers(this Accessibility accessibility) => accessibility switch
        {
            Accessibility.Private => "private",
            Accessibility.ProtectedAndInternal => "private protected",
            Accessibility.Protected => "protected",
            Accessibility.Internal => "internal",
            Accessibility.ProtectedOrInternal => "protected internal",
            Accessibility.Public => "public",
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}