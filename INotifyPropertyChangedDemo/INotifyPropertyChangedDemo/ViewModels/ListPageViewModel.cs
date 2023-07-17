using Bogus;
using INotifyPropertyChangedDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace INotifyPropertyChangedDemo.ViewModels
{
	public class ListPageViewModel: BaseViewModel
	{
		public ObservableCollection<Models.Person> People { get; set; }

		public ListPageViewModel()
        {
            var data = new Faker<Models.Person>()
                .RuleFor(x => x.Name, f => f.Person.FullName)
                .RuleFor(x => x.Phone, f => f.Person.Phone)
                .Generate(20);

            People = new ObservableCollection<Models.Person>(data);
        }
	}
}
