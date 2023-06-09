﻿using ClinicEntity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicData.Repository
{
    public interface IAppointmentRepository
    {
        void AddAppointment(Appointment Appointment);
        void DeleteAppointment(int AppointID);
        IEnumerable<Appointment> GetAppointment();
        Appointment GetAppointmentById(int AppointID);
        void UpdateAppointment(Appointment Appointment);
    }
}
