using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP_01_Module_05.Models;

namespace TP_01_Module_05.Controllers
{
    public class ChatController : Controller
    {
        // GET: Chat
        public ActionResult Index()
        {
            return View(Chat.GetMeuteDeChats());
        }

        // GET: Chat/Details/5
        public ActionResult Details(int id)
        {
            return View(Chat.GetMeuteDeChats()[id]);
        }

        // GET: Chat/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Chat.GetMeuteDeChats()[id]);
        }

        // POST: Chat/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // Chat.GetMeuteDeChats().Remove(Chat.GetMeuteDeChats()[id]);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
