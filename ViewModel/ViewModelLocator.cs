/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:仓库管理系统"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;


namespace 仓库管理系统.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<LoginViewModel>();
            SimpleIoc.Default.Register<CargoViewModel>();
            SimpleIoc.Default.Register<CargoTypeViewModel>();
            SimpleIoc.Default.Register<MemberViewModel>();
            SimpleIoc.Default.Register<IndexViewModel>();
            SimpleIoc.Default.Register<RecordViewModel>();
            SimpleIoc.Default.Register<AddCargoTypeViewModel>();
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public LoginViewModel Login
        {
            get
            {
                return ServiceLocator.Current.GetInstance<LoginViewModel>();
            }
        }

        public CargoViewModel Cargo
        {
            get
            {
                return ServiceLocator.Current.GetInstance<CargoViewModel>();
            }
        }

        public CargoTypeViewModel CargoType
        {
            get
            {
                return ServiceLocator.Current.GetInstance<CargoTypeViewModel>();
            }
        }

        public IndexViewModel Index
        {
            get
            {
                return ServiceLocator.Current.GetInstance<IndexViewModel>();
            }
        }

        public MemberViewModel Member
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MemberViewModel>();
            }
        }

        public RecordViewModel Record
        {
            get
            {
                return ServiceLocator.Current.GetInstance<RecordViewModel>();
            }
        }

        public AddCargoTypeViewModel AddCargoType
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AddCargoTypeViewModel>();
            }
        }
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}