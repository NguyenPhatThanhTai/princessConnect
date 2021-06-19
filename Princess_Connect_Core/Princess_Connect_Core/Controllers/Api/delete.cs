using Microsoft.AspNetCore.Mvc;
using Princess_Connect_Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Princess_Connect_Core.Api
{
    public class delete : Controller
    {
        [HttpPost]
        [Route("api/day")]
        public ActionResult day([FromBody] modeltest test)
        {
            if (test != null)
            {
                return Json(test.name + test.name1 + test.name2);
            }
            else
            {
                return Json(new
                {
                    message = "Không có dữ liệu đầu vào"
                });
            }
        }

        [HttpGet]
        [Route("api/day")]
        public ActionResult day()
        {
            return Json(new
            {
                message = "ok"
            });
        }
    }
}
