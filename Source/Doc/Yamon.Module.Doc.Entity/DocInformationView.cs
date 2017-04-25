
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel;
using Yamon.Framework.Common.DataBase;

namespace Yamon.Module.Doc.Entity
{
    /// <summary>
    /// 公文视图实体类
    /// </summary>
    [Serializable]
    [Table("Doc_Information")]
    public partial class DocInformationView
    {
        public DocInformationView()
        { }

        #region Model

        
        /// <summary>
        /// 类型
        /// </summary>
       [DisplayName("类型")]
       public int? CatalogID
        {
            set;
            get;
        }
       [Column(notMap:true)]
       [DisplayName("类型")]
       public string CatalogID_ShowValue
        {
            set;
            get;
        }

        /// <summary>
        /// 文档编号
        /// </summary>
       [Column(isPrimaryKey: true, isIdentity: false)]
       [DisplayName("文档编号")]
       public int? InfoID
        {
            set;
            get;
        }

        /// <summary>
        /// 标题
        /// </summary>
       [DisplayName("标题")]
       public string Title
        {
            set;
            get;
        }

        /// <summary>
        /// 文档编号
        /// </summary>
       [DisplayName("文档编号")]
       public string InfoNo
        {
            set;
            get;
        }

        /// <summary>
        /// 创建时间
        /// </summary>
       [DisplayName("创建时间")]
       public DateTime? CreateTime
        {
            set;
            get;
        }

        /// <summary>
        /// 创建人
        /// </summary>
       [DisplayName("创建人")]
       public int? CreateUserID
        {
            set;
            get;
        }
       [Column(notMap:true)]
       [DisplayName("创建人")]
       public string CreateUserID_ShowValue
        {
            set;
            get;
        }

        /// <summary>
        /// 更新人
        /// </summary>
       [DisplayName("更新人")]
       public int? UpdateUserID
        {
            set;
            get;
        }
       [Column(notMap:true)]
       [DisplayName("更新人")]
       public string UpdateUserID_ShowValue
        {
            set;
            get;
        }

        /// <summary>
        /// 更新时间
        /// </summary>
       [DisplayName("更新时间")]
       public DateTime? UpdateTime
        {
            set;
            get;
        }

        /// <summary>
        /// 状态
        /// </summary>
       [DisplayName("状态")]
       public int? Status
        {
            set;
            get;
        }

        /// <summary>
        /// 信息类型
        /// </summary>
       [DisplayName("信息类型")]
       public string InfoType
        {
            set;
            get;
        }
       [Column(notMap:true)]
       [DisplayName("信息类型")]
       public string InfoType_ShowValue
        {
            set;
            get;
        }

        /// <summary>
        /// 主文
        /// </summary>
       [DisplayName("主文")]
       public string FilePath
        {
            set;
            get;
        }

        /// <summary>
        /// 链接地址
        /// </summary>
       [DisplayName("链接地址")]
       public string LinkUrl
        {
            set;
            get;
        }

        /// <summary>
        /// 内容
        /// </summary>
       [DisplayName("内容")]
       public string Content
        {
            set;
            get;
        }

        /// <summary>
        /// 是否最热
        /// </summary>
       [DisplayName("是否最热")]
       public int? IsHot
        {
            set;
            get;
        }

        /// <summary>
        /// 是否最新
        /// </summary>
       [DisplayName("是否最新")]
       public int? IsRecommend
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
        /// 内容
        /// </summary>
       [DisplayName("内容")]
       public string HtmlContent
        {
            set;
            get;
        }

        /// <summary>
        /// 附件
        /// </summary>
       [DisplayName("附件")]
       public string FileList
        {
            set;
            get;
        }
       [Column(notMap:true)]
       [DisplayName("附件")]
       public string FileList_ShowValue
        {
            set;
            get;
        }

        /// <summary>
        /// 文本内容
        /// </summary>
       [DisplayName("文本内容")]
       public string TextContent
        {
            set;
            get;
        }


        #endregion Model

        //(Table)
    }
}
