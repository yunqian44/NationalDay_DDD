using NationalDay_DDD.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Domain.Models
{
    /// <summary>
    /// 行程笔记
    /// </summary>
    public class ItineraryNote : ValueObject<ItineraryNote>
    {
        protected override bool EqualsCore(ItineraryNote other)
        {
            throw new NotImplementedException();
        }

        protected override int GetHashCodeCore()
        {
            throw new NotImplementedException();
        }
    }
}
