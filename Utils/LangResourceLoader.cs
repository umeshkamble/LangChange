using System;
using System.ComponentModel;
using System.Globalization;
using System.Resources;

namespace LangChange.Utils
{
	public class LangResourceLoader: INotifyPropertyChanged
    {
		private readonly ResourceManager manager = Resources.Strings.AppResource.ResourceManager;

        private LangResourceLoader()
        {
        }

        static LangResourceLoader instance;
        public static LangResourceLoader Instance
        {
            get
            {
                if (instance == null)
                    instance = new LangResourceLoader();
                return instance;
            }
        }

        public string GetString(string resourceName)
        {
            return manager.GetString(resourceName);
        }

        public string this[string key] => this.GetString(key);


        public void SetCultureInfo(CultureInfo cultureInfo)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

