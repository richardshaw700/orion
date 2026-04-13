How to add a new View:
	Create NewView in View Folder
	Create NewViewModel in ViewModel Folder
	Add DataTemplate to Resorces/ViewDataTemplates.xaml
	Add View name name to Navigation.VM enum
	Add NewViewModel property to Tools.ViewModelLocator
	Resolve NewViewModel in Tools.ViewModelLocator using Autofac
	Add NewViewModel to Navigation.NavigationService

How to add a new Service:
	Create interface in Services folder
	Create interface implementation in Services folder
