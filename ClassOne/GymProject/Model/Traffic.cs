using System;

namespace GymProject.Model
{
    /// <summary>
    /// تراکنش های ورود و خروج اعضائ باشگاه
    /// </summary>
    public class Traffic
    {
        public Traffic(DateTime dateTime, TrafficType trafficType)
        {
            TrafficId = Guid.NewGuid();
            DateTime = dateTime;
            TrafficType = trafficType;
        }

        /// <summary>
        /// شناسه تردد
        /// </summary>
        public Guid TrafficId { get; set; }

        /// <summary>
        /// تاریخ و ساعت تردد
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// نوع تردد
        /// ورود یا خروج
        /// </summary>
        public TrafficType TrafficType { get; set; }

    }
}