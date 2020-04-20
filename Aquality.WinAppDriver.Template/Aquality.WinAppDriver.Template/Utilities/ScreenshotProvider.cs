﻿using Aquality.WinAppDriver.Applications;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Aquality.WinAppDriver.Template.Utilities
{
    public class ScreenshotProvider
    {
        public string TakeScreenshot()
        {
            AqualityServices.Logger.Info("Taking screenshot");
            var image = GetImage();
            var directory = Path.Combine(Environment.CurrentDirectory, "screenshots");
            EnsureDirectoryExists(directory);
            var screenshotName = $"{GetType().Name}_{DateTime.Now:yyyyMMdd_HHmmss}_{Guid.NewGuid().ToString("n").Substring(0, 5)}.png";
            var path = Path.Combine(directory, screenshotName);
            image.Save(path, ImageFormat.Png);
            return path;
        }

        private Image GetImage()
        {
            using (var stream = new MemoryStream(AqualityServices.Application.RootSession.GetScreenshot().AsByteArray))
            {
                return Image.FromStream(stream);
            }
        }

        private static void EnsureDirectoryExists(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }
    }
}
