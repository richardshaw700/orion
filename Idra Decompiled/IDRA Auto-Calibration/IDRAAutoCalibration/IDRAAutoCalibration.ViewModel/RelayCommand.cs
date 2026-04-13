using System;
using System.Windows.Input;
using IodKeMsDBY9RwTYmwo;
using mMWtJPWctee66WM7q3;

namespace IDRAAutoCalibration.ViewModel;

public class RelayCommand : ICommand
{
	private readonly Action<object> WARMttjFro;

	private readonly Func<object, bool> eqrM0fPvNk;

	public event EventHandler CanExecuteChanged
	{
		add
		{
			CommandManager.RequerySuggested += value;
		}
		remove
		{
			CommandManager.RequerySuggested -= value;
		}
	}

	public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
	{
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		base._002Ector();
		WARMttjFro = execute ?? throw new ArgumentNullException(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(3564));
		eqrM0fPvNk = canExecute;
	}

	public bool CanExecute(object parameter)
	{
		if (eqrM0fPvNk != null)
		{
			return eqrM0fPvNk(parameter);
		}
		return true;
	}

	public void Execute(object parameter)
	{
		WARMttjFro(parameter);
	}
}
