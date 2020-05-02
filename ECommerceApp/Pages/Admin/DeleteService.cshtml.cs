﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceApp.Models;
using ECommerceApp.Models.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerceApp.Pages.Admin
{
    public class DeleteServiceModel : PageModel
    {
        private IInventory _inventory;

        public DeleteServiceModel(IInventory inventory)
        {
            _inventory = inventory;
        }

        [BindProperty]
        public Inventory Inventory { get; set; }
        /// <summary>
        /// No OnGet needed for delete page
        /// </summary>
        public async Task<IActionResult> OnGet(int ID)
        {
            Inventory = await _inventory.GetChiropracticServiceByID(ID);
            return Page();
        }

        //DELETE
        /// <summary>
        /// Remove a single chiropractic service based on ID and returns the object
        /// </summary>
        /// <param name="chiropracticServiceID">int</param>
        /// <returns>inventory object</returns>
        public async Task<IActionResult> OnPost()
        {
            await _inventory.RemoveChiropracticService(Inventory.ID);
            if (Inventory == null)
            {
                return RedirectToPage("/NotFound");
            }
            return RedirectToPage("/Admin/ManageServices");
        }

    }
}