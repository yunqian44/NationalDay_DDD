using NationalDay_DDD.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalDay_DDD.Domain.Models
{
    /// <summary>
    /// 旅行时间
    /// </summary>
    public class ItineraryTime : ValueObject<ItineraryTime>
    {

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime { get; private set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime { get; private set; }


        protected override bool EqualsCore(ItineraryTime other)
        {
            throw new NotImplementedException();
        }

        protected override int GetHashCodeCore()
        {
            throw new NotImplementedException();
        }
    }
}
