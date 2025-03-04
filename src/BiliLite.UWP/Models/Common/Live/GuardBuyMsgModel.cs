﻿namespace BiliLite.Models.Common.Live
{
    public class GuardBuyMsgModel
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserID { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 大航海等级1: 总督 2: 提督 3:舰长
        /// </summary>
        public int GuardLevel { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Num { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// 礼物ID
        /// </summary>
        public int GiftId { get; set; }

        /// <summary>
        /// 礼物名称
        /// </summary>
        public string GiftName { get; set; }
    }
}