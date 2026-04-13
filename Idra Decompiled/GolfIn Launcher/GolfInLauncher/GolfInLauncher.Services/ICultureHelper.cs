using GIToolkit.Services;
using Golfin.Dtos;

namespace GolfInLauncher.Services;

public interface ICultureHelper : IService
{
	void AssignCultureLanguage();

	void ChangeCultureLanguage(string culture);

	Language GetCurrentLanguage();
}
