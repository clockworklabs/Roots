using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Roots.Samples
{
    [Generator]
    public class SamplesGenerator : IIncrementalGenerator
    {
        private const string SampleAttribute = "Roots.Samples.SampleAttribute";
        
        void IIncrementalGenerator.Initialize(IncrementalGeneratorInitializationContext context)
        {
            var flaggedForAutoComparer = context.SyntaxProvider
                .CreateSyntaxProvider(
                    predicate: static (s, _) => IsSyntaxTargetForGeneration(s), 
                    transform: static (ctx, _) => GetSemanticTargetForGeneration(ctx))
                .Where(static m => m is not null);
            
            var compilationAndFlaggedTypes = context.CompilationProvider.Combine(flaggedForAutoComparer.Collect());

            context.RegisterSourceOutput(compilationAndFlaggedTypes, static (spc, source) => Execute(source.Item1, source.Item2, spc));
        }
        
        private static bool IsSyntaxTargetForGeneration(SyntaxNode node) => node is ClassDeclarationSyntax
        {
            AttributeLists: { Count: > 0 },
            BaseList: { Types: { Count: > 0 } }
        };

        private static ClassDeclarationSyntax GetSemanticTargetForGeneration(GeneratorSyntaxContext context)
        {
            var node = (ClassDeclarationSyntax)context.Node;
            
            var semanticModel = context.SemanticModel;
            var symbol = semanticModel.GetDeclaredSymbol(node);

            if (symbol is INamedTypeSymbol { IsAbstract: false, IsStatic: false } typeSymbol &&
                typeSymbol.IsRishElement() &&
                typeSymbol.HasAttribute(SampleAttribute) &&
                !typeSymbol.IsGeneric())
            {
                return node;
            }

            return null;
        }
        
        private static void Execute(Compilation compilation, ImmutableArray<ClassDeclarationSyntax> flaggedTypes, SourceProductionContext context)
        {
            if (flaggedTypes.IsDefaultOrEmpty)
            {
                // nothing to do yet
                return;
            }
            
            var samplesNames = flaggedTypes.Select(node =>
            {
                var semanticModel = compilation.GetSemanticModel(node.SyntaxTree);
                var symbol = semanticModel.GetDeclaredSymbol(node) as INamedTypeSymbol;

                return symbol.GetFullName(false);
            }).Distinct().ToList().AsReadOnly();
            
            var emitter = new Emitter();
            var result = emitter.Emit(samplesNames, context.CancellationToken);

            var fileName = $"{compilation.Assembly.Name}.AutoSamplesViewer.g.cs";
            var sourceCode = SourceText.From(result, Encoding.UTF8);

            context.AddSource(fileName, sourceCode);
        }
        
        private class Emitter
        {
            public string Emit(IReadOnlyCollection<string> sampleTypes, CancellationToken contextCancellationToken)
            {
                if (sampleTypes.Count <= 0)
                {
                    return string.Empty;
                }

                var stringBuilder = new StringBuilder();

                stringBuilder.AppendLine(@"namespace Roots.Samples 
{
    [ComparersProvider]
    public partial class AutoSamplesViewer
    {");
        //         foreach (var autoComparer in sampleTypes)
        //         {
        //             contextCancellationToken.ThrowIfCancellationRequested();
        //             
        //             stringBuilder.Append($@"        [Comparer]
        // public static bool Equals{autoComparer.Generics}({autoComparer.FullName} a, {autoComparer.FullName} b){autoComparer.GenericsConstraints}
        // {{
        //     return ");
        //
        //             var fieldsCount = 0;
        //             foreach (var field in autoComparer.Fields)
        //             {
        //                 var sourceCode = GetFieldComparisonSourceCode(null, field);
        //                 if (string.IsNullOrWhiteSpace(sourceCode))
        //                 {
        //                     continue;
        //                 }
        //             
        //                 stringBuilder.Append($"{(fieldsCount > 0 ? " &&\n                " : string.Empty)}{sourceCode}");
        //                 fieldsCount++;
        //             }
        //
        //             stringBuilder.AppendLine($@"{(fieldsCount == 0 ? "true;" : ";")}
        // }}");
        //         }

                stringBuilder.AppendLine(@"    }
}");

                return stringBuilder.ToString();
            }
        }
    }
}