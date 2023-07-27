using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using 仓库管理系统.Models;

namespace 仓库管理系统.ViewModel
{
    public class AddCargoTypeViewModel:ViewModelBase
    {
        public AppData AppData { get; set; }=AppData.Instance;

        private CargoType cargoType=new CargoType();
        public  CargoType CargoType
        {
            get { return cargoType; }
            set { cargoType = value; RaisePropertyChanged(); } 
        }


        //关闭命令
        public RelayCommand<Window> CloseCommand1
        {
            get
            {
                return new RelayCommand<Window>((arg1) =>
                {
                    arg1.Close();
                });
            }
        }

        //添加命令
        public RelayCommand<Window> InsertCargoTypeCommand
        {
            get
            {
                return new RelayCommand<Window>((arg) =>
                {
                    if (string.IsNullOrEmpty(CargoType.Name)) return;

                    cargoType.InsertDate=DateTime.Now;
                    cargoType.MemberId=AppData.CurrentUser.Id;
                    cargoType.MemberName=AppData.CurrentUser.Name;

                    var count = new CargoTypeProvider().Insert(cargoType);
                    if (count == 0)
                    {
                        MessageBox.Show("添加失败");
                    }
                    else
                    {
                        
                        
                        arg.Close();
                    }

                });
            }
        }
    }
}
