using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ABP.Test.Web.Host.DomainEntities
{
    [Table("Goods")]
    public class Goods:AuditedEntity<long>
    {
        /// <summary>
        /// 商品名
        /// </summary>
        [Column(TypeName = "text")]
        public string Name { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public int Price { get; set; }
    }
}
