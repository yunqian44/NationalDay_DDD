using NationalDay_DDD.Core.Models;
using NationalDay_DDD.Domain.Model;
using NationalDay_DDD.Domain.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NationalDay_DDD.Domain.Models
{
    /// <summary>
    /// 行程
    /// </summary>
    public class Itinerary : AggregateRoot<Itinerary>
    {
        public Itinerary()
        {

        }

        //参加本次旅行的人员
        public List<User> Participants { get; private set; }

        //旅行的地点
        public List<Address> Places { get; private set; }

        //关于该行程的备注笔记信息
        public ItineraryNote Note { get; private set; }

        //旅行时间
        public ItineraryTime StartTime { get; private set; }

        //旅行的状态
        public ItineraryStatus Status { get; private set; }

        //将记账薄放置在了旅行中
        public AccountBook AccountBook { get; private set; }

        // 行程的行为
        // ....


        /// <summary>
        /// 收钱
        /// </summary>
        /// <param name="id"></param>
        /// <param name="itemName"></param>
        /// <param name="costMoney"></param>
        public void RecordAnAccountInItinerary(int id, string itemName, double costMoney)
        {
            bool hasThisUser = Participants.Any(u => u.Id == id);

            if (!hasThisUser)
                throw new Exception();

            //AccountBook.RecordAnAccount(itemName, costMoney);
        }
    }
}
