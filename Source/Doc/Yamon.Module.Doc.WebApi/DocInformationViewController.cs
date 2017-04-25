
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;
using System.Linq.Expressions;
using System.Web.Mvc;
using Yamon.Framework.DAL;
using Yamon.Module.Doc.Entity;
using Yamon.Module.Doc.DAL;
using Newtonsoft.Json;
using Yamon.Framework.Common;
using Yamon.Framework.MVC;
using Yamon.Module.SiteManage.DAL;



namespace Yamon.Module.Doc.WebApi
{
    /// <summary>
    /// 公文视图
    /// </summary>
    public partial class DocInformationViewController : _DocInformationViewController
    {

        [NoCheckLogin]
        public ActionResult GetInfoList(int id)
        {
            hash["data"] = dal.GetEntityList("CatalogID=?", new object[] { id }, "InfoID desc");
            return Content(JsonConvert.SerializeObject(hash));
        }

        [NoCheckLogin]
        public ActionResult GetInfo(int id)
        {
            hash["data"] = dal.GetInfoByID(id);
            return Content(JsonConvert.SerializeObject(hash));
        }
    }
}
