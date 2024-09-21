using FlyoutError.View;
using FlyoutError.ViewModels;

namespace FlyoutError {

    public partial class AppShell : Shell {

        public AppShell(AppShellViewModel shellViewModel) {

            InitializeComponent();
            BindingContext = shellViewModel;

            Routing.RegisterRoute(nameof(A), typeof(A));
            Routing.RegisterRoute(nameof(B), typeof(B));
        }
    }
}
