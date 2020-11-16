using System.Windows;
using System.Windows.Input;
using Program.Infrastracture.Commands;
using Program.ViewModels.Base;

namespace Program.ViewModels
{
    class MainViewModel : ViewModel
    {
        #region Заголовок Окна

        /// <summary>
        /// Заголовок окна
        /// </summary>
        private string _Title = "Program";

        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }

        #endregion

        #region Комманды

        #region CloseApplicationCommand

        public ICommand CloseApplicationCommand { get;}
        private bool CanCloseApplicationCommandExecute(object p) => true;

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }

        #endregion
        #endregion

        public MainViewModel()
        {
            #region Команды
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            

            #endregion
        }

    }
}
