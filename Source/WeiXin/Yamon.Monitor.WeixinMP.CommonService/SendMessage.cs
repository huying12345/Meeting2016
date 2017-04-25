using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using Senparc.Weixin.QY.AdvancedAPIs;
using Senparc.Weixin.QY.AdvancedAPIs.Mass;
using Yamon.Framework.Common;
using Yamon.Framework.Common.DataBase;
using Yamon.Framework.Common.Mail;
using Yamon.Framework.Common.Mail.Plugin;
using Yamon.Framework.DBUtility;
using Yamon.Framework.Log4Net;


namespace Yamon.Monitor.WeixinMP.CommonService
{
    public class SendMessage
    {
        public static readonly string CorpId = ConfigHelper.GetConfigString("QY_CorpId");//与微信企业账号后台的CorpId设置保持一致，区分大小写。
        public static readonly string CorpSecrets = ConfigHelper.GetConfigString("QY_CorpSecrets");

        

    }
}
