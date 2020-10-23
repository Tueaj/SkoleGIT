﻿using System;
using Prism.Mvvm;

namespace AgentAssigment
{
    public class Clock : BindableBase
    {

        string date;
        string time;

        public Clock()
        {
            Update();
        }

        public void Update()
        {
            Date = DateTime.Now.ToLongDateString();
            Time = DateTime.Now.ToLongTimeString();
        }

        public string Date
        {
            get { return date; }
            private set
            {
                SetProperty(ref date, value);
            }
        }

        public string Time
        {
            get { return time; }
            private set
            {
                SetProperty(ref time, value);
            }
        }
    }
}