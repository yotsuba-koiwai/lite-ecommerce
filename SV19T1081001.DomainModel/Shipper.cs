﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV19T1081001.DomainModel
{
    /// <summary>
    /// Người giao hàng
    /// </summary>
    public class Shipper
    {
        /// <summary>
        /// Mã người giao hàng
        /// </summary>
        public int ShipperID { get; set; }
        /// <summary>
        /// Tên người giao hàng
        /// </summary>
        public string ShipperName { get; set; }
        /// <summary>
        /// Số điện thoại người giao hàng
        /// </summary>
        public string Phone { get; set; }
    }
}
