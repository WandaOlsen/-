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
    public class LoginViewModel:ViewModelBase
    {

        public AppData AppData { get; private set; }=AppData.Instance;
        public Member Member { get; set; } = AppData.Instance.CurrentUser;

        //private  RelayCommand loginCommand;

        //public RelayCommand LoginCommand
        //{
        //    get { return loginCommand; }
        //    set { loginCommand = value; }
        //}

        public LoginViewModel()
        {
            //loginCommand = new RelayCommand(() =>
            //{
            //    MessageBox.Show("登录成功");
            //});

            this.AppData.CurrentUser.Name = "admin";
            this.AppData.CurrentUser.Password = "67";
        }

        //登录命令
        public RelayCommand LoginCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    MemberProvider memberProvider = new MemberProvider();
                    var list = memberProvider.Select();

                    var user=list.
                    FirstOrDefault(item=>item.Name==AppData.CurrentUser.Name && item.Password==AppData.CurrentUser.Password);

                    if (user == null)
                    {
                        MessageBox.Show("用户名或密码错误");
                    }
                    else
                    {
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                    }
                });
            }
        }

        public RelayCommand<Window> LoginCommand2
        {
            get
            {
                return new RelayCommand<Window>((arg) =>
                {
                    MemberProvider memberProvider = new MemberProvider();
                    var list = memberProvider.Select();

                    var user = list.
                    FirstOrDefault(item => item.Name == AppData.CurrentUser.Name && item.Password == AppData.CurrentUser.Password);

                    if (user == null)
                    {
                        MessageBox.Show("用户名或密码错误");
                    }
                    else
                    {
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                        arg.Close();
                    }
                });
            }
        }


        //关闭命令
        public RelayCommand CloseCommand
        {
            get
            {
                return new RelayCommand(() =>
                {
                    App.Current.Shutdown();
                });
            }
        }


    }
}
