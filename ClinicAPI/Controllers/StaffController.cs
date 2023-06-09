﻿using ClinicBusiness.Services;
using ClinicEntity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        //creating a constructor for accessing StaffService class to access Business Layer
        //Private member
        StaffServices _staffService;

        //Constructor
        public StaffController(StaffServices staffService)
        {
            _staffService = staffService;
        }

        [HttpGet("GetAllStaffs")]
        public IEnumerable<OtherStaff> GetAllStaffs()
        {
            #region Listing all staffs
            return _staffService.GetAllStaffs();
            #endregion
        }

        [HttpPost("AddStaff")]
        public IActionResult AddStaff(OtherStaff otherStaff)
        {
            try
            {
                #region Staff adding action
                _staffService.AddStaff(otherStaff);
                return Ok("Staff added successfully");
                #endregion
            }
            catch
            {
                return BadRequest(400);
            }
        }

        [HttpPut("UpdateStaff")]
        public IActionResult UpdateStaff(OtherStaff otherStaff)
        {
            try
            {
                #region Staff updation action
                _staffService.UpdateStaff(otherStaff);
                return Ok("Staff updated Successfully");
                #endregion
            }
            catch
            {
                return BadRequest(400);
            }
        }

        [HttpDelete("DeleteStaff")]
        public IActionResult DeleteStaff(int staffId)
        {
            try
            {
                #region Staff deletion action
                _staffService.DeleteStaff(staffId);
                return Ok("Staff deleted successfully");
                #endregion
            }
            catch
            {
                return BadRequest(400);
            }
        }

        [HttpGet("GetStaffById")]
        public OtherStaff GetStaffById(int staffId)
        {
            #region Search staff by staff ID
            return _staffService.GetStaffById(staffId);
            #endregion
        }
    }
}
