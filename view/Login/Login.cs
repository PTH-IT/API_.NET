using API_.NET.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.Json.Nodes;

namespace API_.NET.view.Login
{
    public class Login
    {
        public static model.account.Login  LoginUser(HttpResponse context , API_.NET.model.account.Login  user) 
        {
        DoantotnghiepContext DB = new DoantotnghiepContext();
            context.StatusCode = Convert.ToInt32(HttpStatusCode.OK);
            context.Headers.Add("Accept", "application/json");
            context.Headers.Add("Content-Type", "application/json");
          var s =  DB.TaiKhoans.Where(x=>x.TenDangNhap == user.UserName && x.MatKhau == user.Password ).ToList();
            if (s.Count > 0)
            {
                return user;
            }
            else
                return null;
           
            
        }
    }
}
