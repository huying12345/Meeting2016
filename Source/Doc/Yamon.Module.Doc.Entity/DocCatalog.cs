
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel;
using Yamon.Framework.Common.DataBase;

namespace Yamon.Module.Doc.Entity
{
    /// <summary>
    /// 公文类型实体类
    /// </summary>
    [Serializable]
    [Table("Doc_Catalog")]
    public partial class DocCatalog
    {
        public DocCatalog()
        { }

        #region Model

        
        /// <summary>
        /// 编号
        /// </summary>
       [Column(isPrimaryKey: true, isIdentity: false)]
       [DisplayName("编号")]
       public int? CatalogID
        {
            set;
            get;
        }

        /// <summary>
        /// 上级类型
        /// </summary>
       [DisplayName("上级类型")]
       public int? ParentID
        {
            set;
            get;
        }
       [Column(notMap:true)]
       [DisplayName("上级类型")]
       public string ParentID_ShowValue
        {
            set;
            get;
        }

        /// <summary>
        /// 栏目名称
        /// </summary>
       [DisplayName("栏目名称")]
       public string CatalogName
        {
            set;
            get;
        }

        /// <summary>
        /// 排序号
        /// </summary>
       [DisplayName("排序号")]
       public int? OrderID
        {
            set;
            get;
        }

        /// <summary>
        /// 备注
        /// </summary>
       [DisplayName("备注")]
       public string Remark
        {
            set;
            get;
        }


        #endregion Model

        //(TableTree)
            [Column(notMap:true)]
            [JsonProperty("children")]
            public List<DocCatalog> Children
            {
             get;
             set;
            }
            [Column(notMap: true)]
            public int ChildCount
            {
                get;
                set;
            }
            
            
            [Column(notMap: true)]
            [JsonProperty("state")]
            public string State
            {
                get
                {
                    return ChildCount > 0 ? "closed" : "open";
                }
            }
    }
}
