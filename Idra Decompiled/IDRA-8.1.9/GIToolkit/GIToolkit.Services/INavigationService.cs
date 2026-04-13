using CommunityToolkit.Mvvm.ComponentModel;

namespace GIToolkit.Services;

public interface INavigationService<T>
{
	ObservableRecipient Current { get; set; }

	void NavigateTo(T name);

	void GoBack();

	void ClearHistory();

	void AddPage(ObservableRecipient page, T name);

	void RemovePage(T name);

	T CurrentPage();

	T GetBackInfo();
}
