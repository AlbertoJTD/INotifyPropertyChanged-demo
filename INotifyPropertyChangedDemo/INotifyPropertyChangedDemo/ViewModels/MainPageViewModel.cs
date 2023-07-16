using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace INotifyPropertyChangedDemo.ViewModels
{
	public class MainPageViewModel
	{
		public int Number1 { get; set; }
		public int Number2 { get; set; }
		public int Number3 { get; set; }
		public int Number4 { get; set; }
		public int Number5 { get; set; }
		public int Number6 { get; set; }
		public int Number7 { get; set; }
		public int Number8 { get; set; }
		public int Number9 { get; set; }
		public int Number10 { get; set; }
        public int Result { get; set; }
        public ICommand SumCommand { get; set; }

        public MainPageViewModel()
        {
			Number1 = 1;
			Number2 = 2;
			Number3 = 3;
			Number4 = 4;
			Number5 = 5;
			Number6 = 6;
			Number7 = 7;
			Number8 = 8;
			Number9 = 9;
			Number10 = 10;

			SumCommand = new Command(() =>
			{
				Result = Number1 + Number2 + Number3 + Number4 + Number5 + Number6 + Number7 + Number8 + Number9 + Number10;
			});
        }
    }
}
