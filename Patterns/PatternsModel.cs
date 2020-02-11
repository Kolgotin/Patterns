using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows;

namespace Patterns
{
    class PatternsModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
        public string CodeExample
        {
            get => GetCodeExampleFromFile(CodeExampleFilePath);
        }
        public string CodeExampleFilePath;

        private string _ImageSource ="";
        public string ImageSource
        {
            get
            {
                return @"Images\" + _ImageSource;
            }
            set
            {
                _ImageSource = value;
            }
        }
        public Visibility ImageVisibility => (string.IsNullOrEmpty(_ImageSource)) ? Visibility.Collapsed : Visibility.Visible;

        private string GetCodeExampleFromFile(string codeExampleFilePath)
        {
            ResourceManager resource = new ResourceManager("Patterns.Properties.Resources", typeof(PatternsModel).Assembly);
            return resource.GetString(codeExampleFilePath);
        }
    }
}
