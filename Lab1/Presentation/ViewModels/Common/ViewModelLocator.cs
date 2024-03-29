﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.ServiceLocation;

namespace Lab1.Presentation.ViewModels.Common
{
    public class ViewModelLocator
    {
        public LoginViewModel Login => GetViewModel<LoginViewModel>();

        public RegistrationViewModel Registration => GetViewModel<RegistrationViewModel>();

        public PatientMenuViewModel PatientMenu => GetViewModel<PatientMenuViewModel>();

        public AppointmentViewModel Appointment => GetViewModel<AppointmentViewModel>();

        public MainViewModel Main => GetViewModel<MainViewModel>();

        public DoctorsScheduleViewModel DoctorsSchedule => GetViewModel<DoctorsScheduleViewModel>();

        private T GetViewModel<T>()
        {
            return ServiceLocator.Current.GetInstance<T>();
        }
    }
}
