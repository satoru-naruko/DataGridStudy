using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Interactivity.InteractionRequest;

namespace DataGridStudy
{
    public class MainWindowViewModel : BindableBase
    {
        static public ObservableCollection<Tweet> Tweets { get; set; } = new ObservableCollection<Tweet>();
        public MainWindowViewModel()
        {
            Tweets.Add(new Tweet("naruko1", "test1", "https://etstesa/"));
            Tweets.Add(new Tweet("naruko2", "test2", "https://etstesa/"));
            Tweets.Add(new Tweet("naruko3","test3", "https://etstesa/"));
        }

        // Interfaices
        public DelegateCommand AddCommand { get; } = new DelegateCommand(
            () => { Tweets.Add(new Tweet()); },
            () => Tweets.Count <= 10
        );
    }

}
