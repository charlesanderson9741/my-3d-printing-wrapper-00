using System;
using System.Collections.Generic;
using System.Text;

namespace Anno.EngineData.Filters
{
    public interface IExceptionFilter:IFilterMetadata
    {
        void OnException(Exception ex,BaseModule context);
    }
}

// fb7835

// 8fae64
