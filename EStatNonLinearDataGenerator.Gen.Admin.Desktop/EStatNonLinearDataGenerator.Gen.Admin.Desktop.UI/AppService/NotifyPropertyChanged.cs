﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EStatNonLinearDataGenerator.Gen.Admin.Desktop.UI.AppService
{
    public class NotifyPropertyChanged : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public virtual void CheckChanges([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}