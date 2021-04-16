using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopDevmo2.Common.Constants;
using ShopDevmo2.Models;

namespace ShopDevmo2.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        // TODO: include ID and name of item in message
        protected void SetSuccessNotification()
        {
            //string controller = RouteData.GetRequiredString("controller");
            string action = RouteData.GetRequiredString("action");
            if ("edit" == action?.ToLower())
            {
                TempData.Add("Message", "Item is saved.");
            }
            else if ("deleteconfirmed" == action?.ToLower())
            {
                TempData.Add("Message", "Item is deleted.");
            }
            else
            {
                TempData.Add("Message", "Action is succeed.");
            }

        }

        protected Account CurrentAccount
        {
            get
            {
                if (Session["shop:user"] is Account account)
                {
                    return account;
                }
                throw new InvalidOperationException("Invalid user state");
            }
        }
    }
}