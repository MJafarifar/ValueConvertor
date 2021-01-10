using System;
using System.Linq.Expressions;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.EntityFrameworkCore.ValueGeneration;


namespace ValueConvertor
{
    public class TitleConvertor<TModel, TProvider> : ValueConverter<TModel, TProvider>
    {
        
        public TitleConvertor(
            [NotNull] Expression<Func<TModel, TProvider>> convertToProviderExpression,
            [NotNull] Expression<Func<TProvider, TModel>> convertFromProviderExpression,
            [CanBeNull] ConverterMappingHints mappingHints = null): base(convertToProviderExpression, convertFromProviderExpression, mappingHints)

        {

        }

        protected static new Expression<Func<Title, TitleValue>> TitleVal()
            => v => new TitleValue (){Title=v };

        
        protected static Expression<Func<TitleValue, Title>> Str()
            => v => v.Title;
    }
}
