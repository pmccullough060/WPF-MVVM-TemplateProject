﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WPF_MVVM_TemplateProject.BaseClasses
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
