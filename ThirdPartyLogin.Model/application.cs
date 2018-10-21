using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ThirdPartyLogin.Model
{
    public class Application : BaseEntity
    {
        public string AppId { get; set; }
        public string Secret { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// 审核通过
        /// </summary>
        [DefaultValue(false)]
        public bool? IsPassed { get; set; }

        public string NoPassReason { get; set; }
        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime? AuditStamp { get; set; }
        /// <summary>
        /// 禁用
        /// </summary>
        [DefaultValue(false)]
        public bool? IsDisabled { get; set; }
    }
}
