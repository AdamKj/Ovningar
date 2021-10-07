using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Demo
{
    public sealed class PostWidgetViewModel : ObservableRecipient, IRecipient<PropertyChangedMessage<object>>
    {
        private object _post;

        /// <summary>
        /// Gets the currently selected post, if any.
        /// </summary>
        public object Post
        {
            get => _post;
            private set => SetProperty(ref _post, value);
        }

        /// <inheritdoc/>
        public void Receive(PropertyChangedMessage<object> message)
        {
            if (message.Sender.GetType() == typeof(SubRedditWidgetViewModel) && message.PropertyName == nameof(SubRedditWidgetViewModel.SelectedPost))
            {
                Post = message.NewValue;
            }
        }
    }
}
