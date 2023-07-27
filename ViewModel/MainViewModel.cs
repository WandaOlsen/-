using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.ComponentModel;
using 仓库管理系统.View;
using System.Windows.Controls;

namespace 仓库管理系统.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        /// 
        public AppData AppData { get; private set; } = AppData.Instance;
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }

        public RelayCommand<RadioButton> SelectViewCommand
        {
            get
            {
                return new RelayCommand<RadioButton>((arg) =>
                {
                    if (!(arg is RadioButton button)) return;
                    if (string.IsNullOrEmpty(button.Content.ToString())) return;

                    switch (button.Content.ToString())
                    {
                        case "首页":AppData.Instance.MainWindow.container.Content = new IndexView(); break;
                        case "出入库":AppData.Instance.MainWindow.container.Content = new RecordView(); break;
                        case "类型设置":AppData.Instance.MainWindow.container.Content = new CargoTypeView(); break;
                        case "用户管理": AppData.Instance.MainWindow.container.Content = new MemberView(); break;
                        case "物资管理": AppData.Instance.MainWindow.container.Content = new CargoView(); break;
                        default: break;
                    }
                });
            }
        }
    }
}