﻿using System.Web;
using System.Web.Mvc;

namespace HTTP5111_Assignment1_MichelleParlevliet
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
