using System;
using System.Web.Services.Description;
using Windows.Foundation.Collections;
using Windows.Storage;

namespace MVVM_Demo
{
    public sealed class SettingsService : ISettingsService
    {
        /// <summary>
        /// The <see cref="IPropertySet"/> with the settings targeted by the current instance.
        /// </summary>
        private readonly IPropertySet SettingsStorage = ApplicationData.Current.LocalSettings.Values;

        public void SetValue<T>(string key, T value)
        {
            if (!SettingsStorage.ContainsKey(key))
            {
                SettingsStorage.Add(key, value);
            }
            else
            {
                SettingsStorage[key] = value;
            }
        }

        public T GetValue<T>(string key)
        {
            if (SettingsStorage.TryGetValue(key, out object value))
            {
                return (T)value;
            }
            return default;
        }

        public IServiceProvider Services { get; }

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<ISettingsService, SettingsService>();
            services.AddTransient<PostWidgetViewModel>();

            return services.BuildServiceProvider();
        }
    }
}
