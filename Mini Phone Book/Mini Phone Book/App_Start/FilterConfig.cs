﻿using System.Web;
using System.Web.Mvc;

namespace Mini_Phone_Book
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}