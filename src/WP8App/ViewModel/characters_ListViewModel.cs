// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   ViewModel.tt
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Controls=WPAppStudio.Controls;
using Entities=WPAppStudio.Entities;
using EntitiesBase=WPAppStudio.Entities.Base;
using IServices=WPAppStudio.Services.Interfaces;
using IViewModels=WPAppStudio.ViewModel.Interfaces;
using Localization=WPAppStudio.Localization;
using Repositories=WPAppStudio.Repositories;
using Services=WPAppStudio.Services;
using ViewModelsBase=WPAppStudio.ViewModel.Base;
using WPAppStudio;
using WPAppStudio.Shared;

namespace WPAppStudio.ViewModel
{
    /// <summary>
    /// Implementation of characters_List ViewModel.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class characters_ListViewModel : ViewModelsBase.VMBase, IViewModels.Icharacters_ListViewModel
    {       

		private readonly IServices.IDialogService _dialogService;
		private readonly IServices.INavigationService _navigationService;
		private readonly Repositories.Icharacters_charactersCollection _characters_charactersCollection;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="characters_ListViewModel" /> class.
        /// </summary>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="characters_charactersCollection">The Characters_characters Collection.</param>
        public characters_ListViewModel(IServices.IDialogService dialogService, IServices.INavigationService navigationService, Repositories.Icharacters_charactersCollection characters_charactersCollection)
        {
			_dialogService = dialogService;
			_navigationService = navigationService;
			_characters_charactersCollection = characters_charactersCollection;
        }
		
	
		private ObservableCollection<Entities.charactersSchema> _characters_ListListControlCollection;

        /// <summary>
        /// Characters_ListListControlCollection property.
        /// </summary>		
        public ObservableCollection<Entities.charactersSchema> Characters_ListListControlCollection
        {
            get
            {
				
                if(_characters_ListListControlCollection == null)
					_characters_ListListControlCollection = _characters_charactersCollection.GetData();
				return _characters_ListListControlCollection;     
            }
            set
            {
                SetProperty(ref _characters_ListListControlCollection, value);
            }
        }
	
		private int _characters_ListListControlCollectionPageNumber;

        /// <summary>
        /// Characters_ListListControlCollectionPageNumber property.
        /// </summary>		
        public int Characters_ListListControlCollectionPageNumber
        {
            get
            {
				return _characters_ListListControlCollectionPageNumber;
            }
            set
            {
                SetProperty(ref _characters_ListListControlCollectionPageNumber, value);
            }
        }
	
		private Entities.charactersSchema _selectedcharacters_ListListControlCollection;

        /// <summary>
        /// Selectedcharacters_ListListControlCollection property.
        /// </summary>		
        public Entities.charactersSchema Selectedcharacters_ListListControlCollection
        {
            get
            {
				return _selectedcharacters_ListListControlCollection;
            }
            set
            {
                _selectedcharacters_ListListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<IViewModels.Icharacters_DetailViewModel>(_selectedcharacters_ListListControlCollection);
            }
        }

        /// <summary>
        /// Delegate method for the Getcharacters_ListListControlCollectionCommand command.
        /// </summary>
        public  void Getcharacters_ListListControlCollectionCommandDelegate(int pageNumber= 0) 
        {
				Getcharacters_ListListControlCollectionData(pageNumber);
        }
		

        private ICommand _getcharacters_ListListControlCollectionCommand;

        /// <summary>
        /// Gets the Getcharacters_ListListControlCollectionCommand command.
        /// </summary>
        public ICommand Getcharacters_ListListControlCollectionCommand
        {
            get { return _getcharacters_ListListControlCollectionCommand = _getcharacters_ListListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand<int>(Getcharacters_ListListControlCollectionCommandDelegate); }
        }

        private void Getcharacters_ListListControlCollectionData(int pageNumber = 0)
        {
				Characters_ListListControlCollectionPageNumber = pageNumber;

                if (pageNumber == 0)
				{
					var items = _characters_charactersCollection.GetData(pageNumber);
                    Characters_ListListControlCollection = items;
				}
                else   
				{
					var items = _characters_charactersCollection.GetData(pageNumber);
                    foreach (var item in items)                    
                        Characters_ListListControlCollection.Add(item);
				}
		}
    }
}
