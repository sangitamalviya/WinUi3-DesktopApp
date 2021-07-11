﻿using CommunityToolkit.WinUI.Helpers;
using CommunityToolkit.WinUI.UI.Controls;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Winui3Camera
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private async void myButton_Click(object sender, RoutedEventArgs e)
        {
            CPTest.PreviewFailed += CPTest_PreviewFailed;
            await CPTest.StartAsync();
            CPTest.CameraHelper.FrameArrived += CPTest_FrameArrived;
        }

        private void CPTest_FrameArrived(object sender, FrameEventArgs e)
        {
            var videoFrame = e.VideoFrame;
            var softwareBitmap = videoFrame.SoftwareBitmap;
        }
        private void CPTest_PreviewFailed(object sender, PreviewFailedEventArgs e)
        {
            var errorMessage = e.Error;
        }
    }
}
