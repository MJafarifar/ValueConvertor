using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Text;

namespace ValueConvertor
{
    public class TitleConvertorConvertor: TitleConvertor<Title,TitleValue>
    {
      
        public TitleConvertorConvertor([CanBeNull] ConverterMappingHints mappingHints = null)
            : base(TitleVal(),Str() )
        {

        }
    }
}
