using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 仓库管理系统.Models;
using 仓库管理系统.Windows;

namespace 仓库管理系统.ViewModel
{
    public class CargoTypeViewModel:ViewModelBase
    {
        private List<CargoType> cargoTypes=new List<CargoType>();   

        public List<CargoType> CargoTypes
        {
            get
            {
                return cargoTypes;
            }
            set
            {
                cargoTypes = value;
                RaisePropertyChanged();
            }
        }

        public CargoTypeViewModel()
        {
            cargoTypes=new CargoTypeProvider().Select();
        }

        public RelayCommand OpenAddCargoTypeWindowCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    AddCargoTypeWindow window = new AddCargoTypeWindow();
                    window.ShowDialog();
                    //刷新数据库
                    CargoTypes = new CargoTypeProvider().Select();
                });
            }
        }
    }
}
