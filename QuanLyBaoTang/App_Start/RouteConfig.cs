using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace QuanLyBaoTang
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
            name: "",
            url: "Bai-Tap",
            defaults: new { controller = "Baitap", action = "Baitap", id = UrlParameter.Optional }
        );

            routes.MapRoute(
              name: "",
              url: "Bai-Tap-Thuc-Hanh",
              defaults: new { controller = "BaitapThucHanh", action = "BaitapThucHanh", id = UrlParameter.Optional }
          );
            routes.MapRoute(
               name: "",
               url: "Danh-Muc-He-Thong",
               defaults: new { controller = "DanhMucHeThong", action = "DanhMucHeThong", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "",
               url: "Hoc-Jquery",
               defaults: new { controller = "HocJquery", action = "HocJquery", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "",
               url: "DashBoard",
               defaults: new { controller = "DashBoard", action = "DashBoard", id = UrlParameter.Optional }
           );
          
            routes.MapRoute(
              name: "",
              url: "QuanLyHienVat",
              defaults: new { controller = "QuanLyHienVat", action = "QuanLyHienVat", id = UrlParameter.Optional }
          );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "QuanLyHienVat", action = "QuanLyHienVat", id = UrlParameter.Optional }
            );
        }
    }
}
