#if WINDOWS
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Windows.Graphics;
#endif

using ViewModels;
using Views;

namespace Kalkulaator
{
    public partial class App : Application
    {
        const int WindowWidth = 540;
        const int WindowHeight = 1000;
        public App()
        {
            InitializeComponent();

            #if WINDOWS
                        Microsoft.Maui.Handlers.WindowHandler.Mapper.AppendToMapping(nameof(IWindow), (handler, view) =>
                        {
                            var mauiWindow = handler.VirtualView;
                            var nativeWindow = handler.PlatformView;
                            nativeWindow.Activate();
                            IntPtr WindowHandle = WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow);
                            WindowId windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(WindowHandle);
                            AppWindow appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
                            appWindow.Resize(new SizeInt32(WindowWidth, WindowHeight));
                        });
            #endif

            MainPage = new KalkulaatoriLeht();
        }
    }
}
