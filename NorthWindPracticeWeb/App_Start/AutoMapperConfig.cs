using AutoMapper;
using NorthWindPracticeWeb.Mappings;
using NorthWindPracticeWeb.Service.Mappings;

namespace NorthWindPracticeWeb
{
    /// <summary>
    /// Class AutoMapperConfig.
    /// </summary>
    public static class AutoMapperConfig
    {
        /// <summary>
        /// Registers the profile.
        /// </summary>
        public static void RegisterProfile()
        {
            Mapper.Initialize(config =>
            {
                config.AddProfile<WebMapProfile>();
                config.AddProfile<ServiceMapProfile>();
            });
        }
    }
}