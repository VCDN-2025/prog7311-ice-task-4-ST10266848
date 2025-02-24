using HotelBookingSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using HotelBookingSystem.Models;

namespace HotelBookingSystem.Controllers
{
    public class BookingController : Controller
    {
        // Temporary in-memory list for demo purposes. In a real app use a database.
        private static List<Booking> _bookings = new List<Booking>();

        // GET: Booking
        public ActionResult Index()
        {
            return View(_bookings);
        }

        // GET: Booking/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Booking/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Booking booking)
        {
            if (ModelState.IsValid)
            {
                booking.Id = _bookings.Count > 0 ? _bookings.Max(b => b.Id) + 1 : 1;
                _bookings.Add(booking);
                return RedirectToAction("Index");
            }
            return View(booking);
        }

        // GET: Booking/Details/5
        public ActionResult Details(int id)
        {
            var booking = _bookings.FirstOrDefault(b => b.Id == id);
            if (booking == null)
            {
                return NotFound();
            }
            return View(booking);
        }

        // GET: Booking/Edit/5
        public ActionResult Edit(int id)
        {
            var booking = _bookings.FirstOrDefault(b => b.Id == id);
            if (booking == null)
            {
                return NotFound();
            }
            return View(booking);
        }

        // POST: Booking/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Booking booking)
        {
            if (ModelState.IsValid)
            {
                var existing = _bookings.FirstOrDefault(b => b.Id == booking.Id);
                if (existing == null)
                {
                    return NotFound();
                }
                existing.CustomerName = booking.CustomerName;
                existing.BookingDate = booking.BookingDate;
                existing.Duration = booking.Duration;
                existing.RoomType = booking.RoomType;
                existing.SpecialRequests = booking.SpecialRequests;
                return RedirectToAction("Index");
            }
            return View(booking);
        }

        // GET: Booking/Delete/5
        public ActionResult Delete(int id)
        {
            var booking = _bookings.FirstOrDefault(b => b.Id == id);
            if (booking == null)
            {
                return NotFound();
            }
            return View(booking);
        }

        // POST: Booking/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var booking = _bookings.FirstOrDefault(b => b.Id == id);
            if (booking != null)
            {
                _bookings.Remove(booking);
            }
            return RedirectToAction("Index");
        }

        //Author: Open AI
        //AI Chatbot: ChatGPT
        //Date: 24 February 2025
        //Availability: https://chatgpt.com/share/67bc3701-aa34-8002-9397-b34b73662272

    }
}

