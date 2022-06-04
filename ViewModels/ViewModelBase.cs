using System;
using LangChange.Utils;

namespace LangChange.ViewModels
{
	public class ViewModelBase: BindableObject
	{
		public ViewModelBase()
		{
		}

		public LangResourceLoader Language
		{
			get
			{
				return LangResourceLoader.Instance;
			}
		}
    }
}

