using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Privafo.DataAccess;
using Privafo.DataAccess.Repository.IRepository;
using Privafo.Models;
using Privafo.Models.ViewModels;
using System.IO;
using Microsoft.AspNetCore.Http;
using MailKit.Net.Smtp;
using MimeKit;

namespace PrivafoWeb.Controllers
{
    public class DPIAController : Controller
    {

        private readonly IUnitOfWork _uow;
        private Microsoft.AspNetCore.Hosting.IHostingEnvironment Environment;

        public DPIAController(IUnitOfWork uow,Microsoft.AspNetCore.Hosting.IHostingEnvironment _environment)
        {
            _uow = uow;
            Environment = _environment;
        }
        //GET
        public IActionResult Index()
        {
            return View();
        }

        //GET
        public IActionResult Views()
        {
            return View();
        }


        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(DPIAVM obj)
        {
            //if (ModelState.IsValid) //validation form server side
            //{

                if (obj.DPIATemplate.ID == 0)
                {
                    _uow.DPIATemplate.Add(obj.DPIATemplate);
                    TempData["success"] = ",DPIA Template inserted successfully";
                }
                else
                {
                    _uow.DPIATemplate.Update(obj.DPIATemplate);
                    TempData["success"] = "DPIA Template updated successfully";
                }
                _uow.Save();
                return RedirectToAction("Index");
            //}
            //return View(obj);
        }

        //GET
        public IActionResult Upsert(int? ID)
        {
            DPIAVM DPIAVM = new()
            {
                DPIATemplate = new(),
                //ModuleCtgSelectList = _uow.ModuleCtg.GetAll().Select(i => new SelectListItem
                //{
                //    Text = i.ModuleCtgName,
                //    Value = i.ID.ToString()
                //})
            };


            if (ID == null || ID == 0)
            {
                //Create Product

                ////ViewBag Mode
                //ViewBag.ModuleCtgList = ModuleCtgList;
                //ViewData["ModuleCtgList"] = ModuleCtgList;
                //return View(module);

                //ViewModel Mode
                return View(DPIAVM);
            }
            else
            {
                DPIAVM.DPIATemplate = _uow.DPIATemplate.GetFirstOrDefault(u => u.ID == ID);

                return View(DPIAVM);
            }
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(DPIAVM obj)
        {
            //if (ModelState.IsValid) //validation form server side
            //{

                if (obj.DPIATemplate.ID == 0)
                {
                    _uow.DPIATemplate.Add(obj.DPIATemplate);
                    TempData["success"] = ",DPIA Template inserted successfully";
                }
                else
                {
                    _uow.DPIATemplate.Update(obj.DPIATemplate);
                    TempData["success"] = "DPIA Template updated successfully";
                }
                _uow.Save();
                return RedirectToAction("Index");
            //}
            //return View(obj);
        }

        //POST
        [HttpDelete]
        public IActionResult Delete(int? ID)
        {
            var obj = _uow.DPIATemplate.GetFirstOrDefault(u => u.ID == ID);

            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _uow.DPIATemplate.Remove(obj);
            _uow.Save();
            return Json(new { success = true, message = "DPIA Template deleted successfully" });
        }


        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            //var productList = _uow.Module.GetAll();
            var productList = _uow.DPIATemplate.GetAll();
            return Json(new { data = productList });
        }
        [HttpGet]
        public IActionResult GetCustom(int? ID)
        {
            //var productList = _uow.Module.GetAll();
            var productList = _uow.DPIATemplate.GetFirstOrDefault(u => u.ID == ID);
            return Json(new { data = productList });
        }
        public IActionResult GetAllCustom()
        {
            //var productList = _uow.Module.GetAll();
            var productList = _uow.DPIATemplate.GetAll().Select(i => new { name = i.TemplateName, desc = i.Description } );
            return Json(new { data = productList });
        }

        
        //POST
        [HttpPost]
        public IActionResult Upload(string data,string myfile)
        {
            //create pdf
            var pdfBinary = Convert.FromBase64String(data);
            var dir = this.Environment.WebRootPath;
            var path = Path.Combine(dir, "tmp"); //folder name

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            //var fileName = path + "\\PDF-Dog-" + DateTime.Now.ToString("yyyyMMdd-HHMMss") + ".pdf";
            var fileName = path + "/dpia/" + myfile;
            //add time to avoid the duplicate
            using (var fs = new FileStream(fileName, FileMode.Create))
            using (var writer = new BinaryWriter(fs))
            {
                writer.Write(pdfBinary, 0, pdfBinary.Length);
                writer.Close();
            }
            return null;
        }

        [HttpPost]
        public IActionResult Email(string data, string myfile, string recipient)
        {
            //create pdf
            var pdfBinary = Convert.FromBase64String(data);
            var dir = this.Environment.WebRootPath;
            var path = Path.Combine(dir, "tmp"); //folder name

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            var fileName = path + "/dpia/" + myfile;
            using (var fs = new FileStream(fileName, FileMode.Create))
            using (var writer = new BinaryWriter(fs))
            {
                writer.Write(pdfBinary, 0, pdfBinary.Length);
                writer.Close();
            }
            //email
            MimeMessage message = new MimeMessage();
            MailboxAddress from = new MailboxAddress("privafo","admin@privafo.com");
            message.From.Add(from);
            MailboxAddress to = new MailboxAddress(recipient, recipient);
            message.To.Add(to);
            message.Subject = "Privafo Template Test";
            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = "<h1>Email from Privafo</h1>";
            bodyBuilder.TextBody = "email with attchment : " + myfile;
            bodyBuilder.Attachments.Add(fileName);
            message.Body = bodyBuilder.ToMessageBody();
            SmtpClient client = new SmtpClient();
            client.Connect("mx.mailspace.id", 465, true);
            client.Authenticate("admin@privafo.com", "sysAdmin22!");
            client.Send(message);
            client.Disconnect(true);
            client.Dispose();
            //-----
            return null;
        }
        #endregion

    }
}
