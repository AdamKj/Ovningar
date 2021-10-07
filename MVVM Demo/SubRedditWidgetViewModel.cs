using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Demo
{
    public sealed class SubRedditWidgetViewModel : ObservableRecipient
    {
        private readonly ISettingsService _settingsService;
        /// <summary>
        /// Creates a new <see cref="SubredditWidgetViewModel"/> instance.
        /// </summary>
        public SubRedditWidgetViewModel(ISettingsService settingsService)
        {
            _settingsService = settingsService;
            _selectedSubreddit = settingsService.GetValue<string>(nameof(SelectedSubreddit)) ?? Subreddits[0];
        }

        /// <summary>
        /// Gets the <see cref="IAsyncRelayCommand"/> instance responsible for loading posts.
        /// </summary>
        public IAsyncRelayCommand LoadPostsCommand { get; }

        /// <summary>
        /// Gets the <see cref="IAsyncRelayCommand"/> instance responsible for loading posts.
        /// </summary>
        public ObservableCollection<object> Posts { get; } = new ObservableCollection<object>();

        /// <summary>
        /// Gets the collection of available subreddits to pick from.
        /// </summary>
        public IReadOnlyList<string> Subreddits { get; } = new[]
        {
            "microsoft",
            "windows",
            "surface",
            "windowsphone",
            "dotnet",
            "csharp"
        };

        private string _selectedSubreddit;

        /// <summary>
        /// Gets or sets the currently selected subreddit.
        /// </summary>
        public string SelectedSubreddit
        {
            get => _selectedSubreddit;
            set
            {
                SetProperty(ref _selectedSubreddit, value);
                _settingsService.SetValue(nameof(SelectedSubreddit), value);
            }
        }

        private object _selectedPost;

        /// <summary>
        /// Gets or sets the currently selected subreddit.
        /// </summary>
        public object SelectedPost
        {
            get => _selectedPost;
            set => SetProperty(ref _selectedPost, value, true);
        }

        /// <summary>
        /// Loads the posts from a specified subreddit.
        /// </summary>
        private async Task LoadPostsAsync()
        {

        }

    }
}
