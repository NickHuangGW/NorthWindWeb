using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NorthWindPracticeWeb.Service.Mappings;

namespace NorthWindPracticeWeb.Service.Test
{
    /// <summary>
    /// TestHook
    /// </summary>
    [TestClass]
    public class TestHook
    {
        /// <summary>
        /// Assemblies the initialize.
        /// </summary>
        /// <param name="context">The context.</param>
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            Mapper.Reset();

            Mapper.Initialize(config =>
            {
                config.AddProfile<ServiceMapProfile>();
            });
        }
        /// <summary>
        /// Assemblies the cleanup.
        /// </summary>
        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {

        }
    }
}