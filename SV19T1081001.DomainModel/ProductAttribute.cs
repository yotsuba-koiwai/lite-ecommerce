﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV19T1081001.DomainModel
{
    /// <summary>
    /// Thuộc tính mặt hàng
    /// </summary>
    public class ProductAttribute
    {
        /// <summary>
        /// Mã thuộc tính
        /// </summary>
        public int AttributeID { get; set; }
        /// <summary>
        /// Mã mặt hàng
        /// </summary>
        public int ProductID { get; set; }
        /// <summary>
        /// Tên thuộc tính
        /// </summary>
        public string AttributeName { get; set; }
        /// <summary>
        /// Giá trị thuộc tính
        /// </summary>
        public string AttributeValue { get; set; }
        /// <summary>
        /// Thứ tự hiển thị
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}
