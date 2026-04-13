using System;

namespace GIToolkit.Services;

public interface IExceptionHelper
{
	string GetLastFrameMessage(Exception ex);
}
