// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   ServiceLocator.tt
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using IIoc=WPAppStudio.Ioc.Interfaces;
using Ioc=WPAppStudio.Ioc;
using IViewModels=WPAppStudio.ViewModel.Interfaces;

namespace WPAppStudio.Services
{
    /// <summary>
    /// Implementation of the ViewModel locator service based on IoC.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public class ViewModelLocatorService
    {
        // IoC container
        private readonly IIoc.IContainer _container;

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModelLocatorService" /> class.
        /// </summary>
        public ViewModelLocatorService()
        {
            _container = new Ioc.Container();
        }
		
		/// <summary>
        /// Resolve a service of type T
        /// </summary>
        /// <typeparam name="T">Type of the service.</typeparam>
        /// <returns></returns>
        public T ResolveService<T>()
        {
            return _container.Resolve<T>();
        }

        /// <summary>
        /// Gets the reference to a start_MenuViewModel.
        /// </summary>
		public IViewModels.Istart_MenuViewModel start_MenuViewModel
        {
            get { return _container.Resolve<IViewModels.Istart_MenuViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a TheStory_InfoViewModel.
        /// </summary>
		public IViewModels.ITheStory_InfoViewModel TheStory_InfoViewModel
        {
            get { return _container.Resolve<IViewModels.ITheStory_InfoViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a pictures_NewsViewModel.
        /// </summary>
		public IViewModels.Ipictures_NewsViewModel pictures_NewsViewModel
        {
            get { return _container.Resolve<IViewModels.Ipictures_NewsViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a characters_ListViewModel.
        /// </summary>
		public IViewModels.Icharacters_ListViewModel characters_ListViewModel
        {
            get { return _container.Resolve<IViewModels.Icharacters_ListViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a characters_DetailViewModel.
        /// </summary>
		public IViewModels.Icharacters_DetailViewModel characters_DetailViewModel
        {
            get { return _container.Resolve<IViewModels.Icharacters_DetailViewModel>(); }
        }
		/// <summary>
        /// Gets the reference to a AboutViewModel.
        /// </summary>
		public IViewModels.IAboutViewModel AboutViewModel
        {
            get { return _container.Resolve<IViewModels.IAboutViewModel>(); }
        }
		
		/// <summary>
        /// Gets the reference to a LicenseViewModel.
        /// </summary>
		public IViewModels.ILicenseViewModel LicenseViewModel
        {
            get { return _container.Resolve<IViewModels.ILicenseViewModel>(); }
        }
    }
}
