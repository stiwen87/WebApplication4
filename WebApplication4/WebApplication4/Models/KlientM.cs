using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class KlientM : Klient
    {


        public enum SysOp
        {
            Android,
            iOS
        }

        public SysOp System { get; set; }
        public int Punkty { get; set; }


    }
}