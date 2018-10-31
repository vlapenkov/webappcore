﻿using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCore.Services.NopCommerce
{
    

    public abstract class NopRazorPage<TModel> : Microsoft.AspNetCore.Mvc.Razor.RazorPage<TModel>
    {
             
        public string T1(string s)
        {
            return s;
        }


        

        public LocalizedString T(string resource)  {

            var service = ServiceLocator.Current.GetInstance<JsonLocalizationService>();
            return service[resource];
        
        }

                      
            }
    /// <summary>
    /// Web view page
    /// </summary>
    public abstract class NopRazorPage : NopRazorPage<dynamic>
    {
       
    }
}
