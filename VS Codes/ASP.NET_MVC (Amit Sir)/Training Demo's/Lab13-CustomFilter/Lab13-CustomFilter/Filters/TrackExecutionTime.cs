﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab13_CustomFilter.FilterContext
{
    public class TrackExecutionTime : ActionFilterAttribute, IExceptionFilter
    {

        private void LogExecutionTime(string data)
        {
            File.AppendAllText(HttpContext.Current.Server.MapPath("~/DataFiles/DataLog.txt"), data);
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string message = "\n" + filterContext.ActionDescriptor.ControllerDescriptor.ControllerName +
                "->" + filterContext.ActionDescriptor.ActionName + "-> OnActionExecuting \t-" +
                DateTime.Now.ToString() + "\n";
            LogExecutionTime(message);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            string message = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName +
                "->" + filterContext.ActionDescriptor.ActionName + "-> OnActionExecuted \t-" +
                DateTime.Now.ToString() + "\n";
            LogExecutionTime(message);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            string message = filterContext.RouteData.Values["controller"].ToString() +
                "->" + filterContext.RouteData.Values["action"].ToString() + "-> OnResultExecuting \t-" +
                DateTime.Now.ToString() + "\n";
            LogExecutionTime(message);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            string message = filterContext.RouteData.Values["controller"].ToString() +
                "->" + filterContext.RouteData.Values["action"].ToString() + "-> OnResultExecuted \t-" +
                DateTime.Now.ToString() + "\n";
            LogExecutionTime(message);
            LogExecutionTime("---------------------------------------------------");
        }

        public void OnException(ExceptionContext filterContext)
        {
            string message = filterContext.RouteData.Values["controller"].ToString() +
                "->" + filterContext.RouteData.Values["action"].ToString() + "-> "+
                filterContext.Exception.Message + " \t-" +
                DateTime.Now.ToString() + "\n";
            LogExecutionTime(message);
            LogExecutionTime("---------------------------------------------------");
        }

        
    }
}