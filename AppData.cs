﻿using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 仓库管理系统.Models;

namespace 仓库管理系统
{
    public class AppData:ObservableObject
    {

        public static AppData Instance = new Lazy<AppData>(() => new AppData()).Value;

        public string systemName = "仓库物资管理系统";

        public string SystemName
        {
            get { return systemName; }
            set { systemName = value; RaisePropertyChanged(); }
        }

        private Member member = new Member();
        
        public Member CurrentUser
        {
            get { return member; }
            set { member = value; RaisePropertyChanged("CurrentUser"); }
        }

        public MainWindow MainWindow { get; set; } = null;
    }
}
