using FlyoutError.ViewModels;

namespace FlyoutError {
    public partial class AppShell : Shell {
        public AppShell(AppShellViewModel shellViewModel) {
            InitializeComponent();
            BindingContext = shellViewModel;
        }
    }
}
