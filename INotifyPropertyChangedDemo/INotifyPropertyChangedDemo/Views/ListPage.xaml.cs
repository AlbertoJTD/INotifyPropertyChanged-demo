﻿using INotifyPropertyChangedDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace INotifyPropertyChangedDemo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListPage : ContentPage
	{
		public ListPage()
		{
			InitializeComponent();
			this.BindingContext = new ListPageViewModel();
		}
	}
}