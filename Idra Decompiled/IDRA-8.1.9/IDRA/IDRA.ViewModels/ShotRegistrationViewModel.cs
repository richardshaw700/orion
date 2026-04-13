using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GICTS.Core;
using GICTS.Data;
using GICTSCore.Data;
using GICTSCore.Services;
using GIToolkit.Services;
using GhU84wwqvI4UZ3pBfu;
using IDRA.Auxiliary.Helpers;
using IDRA.Auxiliary.Navigations;
using MahApps.Metro.Controls.Dialogs;
using sxB8TYTZ87aKuujytY;

namespace IDRA.ViewModels;

public class ShotRegistrationViewModel : ObservableRecipient, IViewModel, IDisposable
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public List<FileInfo> MxjIe5Qcw9;

		public _003C_003Ec__DisplayClass18_0()
		{
			RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
			base._002Ector();
		}

		internal void npBIDVBhQr(string x)
		{
			MxjIe5Qcw9.Add(new FileInfo(x));
		}
	}

	private CTSShotData FUPQc3wYAD;

	private ShotRegistrationModel rfkQr003Qj;

	private readonly INavigationService<VM> TgEQA0f6Ik;

	private readonly IDialogCoordinator L80QZtB1DP;

	private readonly ICircularLogService VoXQlLbF6L;

	private readonly IGICTSDirector rZ0Qklvaxg;

	private readonly IXmlHelper Os0Q2UGcQh;

	private readonly IIdraModeService SxIQyw9FSW;

	private readonly IdraMode VJsQgJysOe;

	private bool yQGQ4OMHJ8;

	public CTSShotData ShotReceived
	{
		get
		{
			return FUPQc3wYAD;
		}
		set
		{
			SetProperty(ref FUPQc3wYAD, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(6982));
		}
	}

	public ShotRegistrationModel ShotRegister
	{
		get
		{
			return rfkQr003Qj;
		}
		set
		{
			SetProperty(ref rfkQr003Qj, value, QQXBLjLprwI58ya4VR.y8v8TMFOCb(7010));
		}
	}

	public ICommand SaveCommand => new AsyncRelayCommand((Func<Task>)async delegate
	{
		while (yQGQ4OMHJ8)
		{
			await Task.Delay(100);
		}
		yQGQ4OMHJ8 = true;
		new DirectoryInfo(IDRAConstant.GICTSSamplesResultsFolder + QQXBLjLprwI58ya4VR.y8v8TMFOCb(18666) + ShotReceived.ShotName);
		new DirectoryInfo(IDRAConstant.GICTSSamplesShotsFolder + QQXBLjLprwI58ya4VR.y8v8TMFOCb(18666) + ShotReceived.ShotName);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 3);
		defaultInterpolatedStringHandler.AppendFormatted(IDRAConstant.GICTSSamplesResultsFolder);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(18666));
		defaultInterpolatedStringHandler.AppendFormatted(ShotReceived.ShotName);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(18666));
		defaultInterpolatedStringHandler.AppendFormatted(ShotReceived.ShotName);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(18672));
		string text = defaultInterpolatedStringHandler.ToStringAndClear();
		FileInfo fileInfo = new FileInfo(text);
		if (fileInfo == null || !fileInfo.Exists)
		{
			VoXQlLbF6L.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(18694) + text, LogLevel.Error);
			await L80QZtB1DP.ShowMessageAsync(this, QQXBLjLprwI58ya4VR.y8v8TMFOCb(12418), QQXBLjLprwI58ya4VR.y8v8TMFOCb(18694) + text);
		}
		else
		{
			await PmRQu7oN6D(fileInfo);
			await wLnQbMDekN();
			await YgaQ6inF9s();
			TgEQA0f6Ik.NavigateTo(VM.Main);
		}
	});

	public ICommand CancelCommand => new RelayCommand(delegate
	{
		VoXQlLbF6L.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(7156));
		TgEQA0f6Ik.NavigateTo(VM.Main);
	});

	public ShotRegistrationViewModel(INavigationService<VM> navigationService, IDialogCoordinator dialogCoordinator, ICircularLogService circularLogService, IGICTSDirector gICTSDirector, IXmlHelper xmlHelper, IIdraModeService idraModeService)
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		yQGQ4OMHJ8 = true;
		base._002Ector();
		TgEQA0f6Ik = navigationService;
		L80QZtB1DP = dialogCoordinator;
		VoXQlLbF6L = circularLogService;
		rZ0Qklvaxg = gICTSDirector;
		Os0Q2UGcQh = xmlHelper;
		SxIQyw9FSW = idraModeService;
		VJsQgJysOe = Task.Run((Func<Task<IdraMode>?>)SxIQyw9FSW.GetCurrentMode).Result;
		if (VJsQgJysOe == IdraMode.ShotRegistration)
		{
			IGICTSDirector iGICTSDirector = rZ0Qklvaxg;
			iGICTSDirector.OnNewShotSent = (Func<CTSShotData, Task>)Delegate.Combine(iGICTSDirector.OnNewShotSent, new Func<CTSShotData, Task>(fY1QRFAa2i));
			IGICTSDirector iGICTSDirector2 = rZ0Qklvaxg;
			iGICTSDirector2.OnVideoExported = (Func<Task>)Delegate.Combine(iGICTSDirector2.OnVideoExported, (Func<Task>)async delegate
			{
				yQGQ4OMHJ8 = false;
			});
			VoXQlLbF6L.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(7038));
		}
	}

	private async Task fY1QRFAa2i(CTSShotData P_0)
	{
		if (P_0 == null)
		{
			VoXQlLbF6L.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(20252), LogLevel.Error);
			return;
		}
		VoXQlLbF6L.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(20394) + P_0.ShotName);
		TgEQA0f6Ik.NavigateTo(VM.ShotRegistration);
		ShotReceived = P_0;
		if (P_0.PlayerHandedness == PlayerHandednessNatureEnum.Left)
		{
			ShotReceived.Club.ClubAnglePath *= -1.0;
			ShotReceived.Club.ClubAngleFace *= -1.0;
		}
		ShotRegister = new ShotRegistrationModel(ShotReceived.ClubNature, ShotReceived.PlayerHandedness);
		await FKEQFyBYnQ();
	}

	private async Task FKEQFyBYnQ()
	{
		_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass18_0();
		string path = IDRAConstant.GICTSSamplesResultsFolder ?? "";
		if (!Directory.Exists(path))
		{
			return;
		}
		string[] files = Directory.GetFiles(path, QQXBLjLprwI58ya4VR.y8v8TMFOCb(19132), SearchOption.AllDirectories);
		if (files.Length < 1)
		{
			return;
		}
		CS_0024_003C_003E8__locals6.MxjIe5Qcw9 = new List<FileInfo>();
		files.ToList().ForEach(delegate(string x)
		{
			CS_0024_003C_003E8__locals6.MxjIe5Qcw9.Add(new FileInfo(x));
		});
		CS_0024_003C_003E8__locals6.MxjIe5Qcw9 = (from x in CS_0024_003C_003E8__locals6.MxjIe5Qcw9
			orderby x.CreationTime descending
			where x.DirectoryName.Contains(QQXBLjLprwI58ya4VR.y8v8TMFOCb(18816))
			select x).ToList();
		ICircularLogService voXQlLbF6L = VoXQlLbF6L;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(51, 1);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(19156));
		defaultInterpolatedStringHandler.AppendFormatted(CS_0024_003C_003E8__locals6.MxjIe5Qcw9.Count);
		voXQlLbF6L.Log(defaultInterpolatedStringHandler.ToStringAndClear());
		try
		{
			foreach (FileInfo item in CS_0024_003C_003E8__locals6.MxjIe5Qcw9)
			{
				await Os0Q2UGcQh.LoadXmlDocument(item.FullName);
				XmlNode xmlNode = Os0Q2UGcQh.DocumentHandle?.DocumentElement?.SelectSingleNode(QQXBLjLprwI58ya4VR.y8v8TMFOCb(19262));
				if (xmlNode != null && !string.IsNullOrWhiteSpace(xmlNode.InnerText))
				{
					ShotRegister.TestCase = xmlNode.InnerText;
					OnPropertyChanged(QQXBLjLprwI58ya4VR.y8v8TMFOCb(7010));
					VoXQlLbF6L.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(19318) + xmlNode.InnerText);
					break;
				}
			}
			if (string.IsNullOrWhiteSpace(ShotRegister.TestCase))
			{
				ShotRegister.TestCase = string.Empty;
			}
		}
		catch (Exception ex)
		{
			VoXQlLbF6L.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(19418) + ex.Message, LogLevel.Error);
			await L80QZtB1DP.ShowMessageAsync(this, QQXBLjLprwI58ya4VR.y8v8TMFOCb(12418), QQXBLjLprwI58ya4VR.y8v8TMFOCb(19500));
		}
	}

	private async Task wLnQbMDekN()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 3);
		defaultInterpolatedStringHandler.AppendFormatted(IDRAConstant.GICTSSamplesResultsFolder);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(18666));
		defaultInterpolatedStringHandler.AppendFormatted(ShotReceived.ShotName);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(18666));
		defaultInterpolatedStringHandler.AppendFormatted(ShotReceived.ShotName);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(18672));
		FileInfo fileInfo = new FileInfo(defaultInterpolatedStringHandler.ToStringAndClear());
		DirectoryInfo destinationPathshotShotsDirectory = new DirectoryInfo(IDRAConstant.GICTSSamplesShotsFolder + QQXBLjLprwI58ya4VR.y8v8TMFOCb(18666) + ShotReceived.ShotName);
		if (!destinationPathshotShotsDirectory.Exists || !fileInfo.Exists)
		{
			VoXQlLbF6L.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(18836), LogLevel.Error);
			await L80QZtB1DP.ShowMessageAsync(this, QQXBLjLprwI58ya4VR.y8v8TMFOCb(12418), QQXBLjLprwI58ya4VR.y8v8TMFOCb(18836));
			return;
		}
		try
		{
			File.Copy(fileInfo.FullName, destinationPathshotShotsDirectory.FullName + QQXBLjLprwI58ya4VR.y8v8TMFOCb(18942), overwrite: true);
		}
		catch (Exception ex)
		{
			VoXQlLbF6L.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(18970) + ex.Message, LogLevel.Error);
			await L80QZtB1DP.ShowMessageAsync(this, QQXBLjLprwI58ya4VR.y8v8TMFOCb(12418), QQXBLjLprwI58ya4VR.y8v8TMFOCb(18836));
		}
		try
		{
			Helper.CopyDirectoryRecursively(IDRAConstant.IdraProgramDataPathConfig, destinationPathshotShotsDirectory.FullName + QQXBLjLprwI58ya4VR.y8v8TMFOCb(19114));
		}
		catch (Exception ex2)
		{
			VoXQlLbF6L.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(18970) + ex2.Message, LogLevel.Error);
			await L80QZtB1DP.ShowMessageAsync(this, QQXBLjLprwI58ya4VR.y8v8TMFOCb(12418), QQXBLjLprwI58ya4VR.y8v8TMFOCb(18836));
		}
	}

	private async Task YgaQ6inF9s()
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(IDRAConstant.GICTSSamplesResultsFolder + QQXBLjLprwI58ya4VR.y8v8TMFOCb(18666) + ShotReceived.ShotName);
		DirectoryInfo directoryInfo2 = new DirectoryInfo(IDRAConstant.GICTSSamplesShotsFolder + QQXBLjLprwI58ya4VR.y8v8TMFOCb(18666) + ShotReceived.ShotName);
		if (!directoryInfo.Exists || !directoryInfo2.Exists)
		{
			VoXQlLbF6L.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(20664), LogLevel.Error);
			await L80QZtB1DP.ShowMessageAsync(this, QQXBLjLprwI58ya4VR.y8v8TMFOCb(12418), QQXBLjLprwI58ya4VR.y8v8TMFOCb(20664));
			return;
		}
		string fullName = directoryInfo.FullName;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 4);
		defaultInterpolatedStringHandler.AppendFormatted(directoryInfo.FullName);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(20782));
		defaultInterpolatedStringHandler.AppendFormatted(ShotRegister.PlayerHanded);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(20782));
		defaultInterpolatedStringHandler.AppendFormatted(ShotRegister.ClubNature);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(20782));
		defaultInterpolatedStringHandler.AppendFormatted(ShotRegister.TestCase.Replace(QQXBLjLprwI58ya4VR.y8v8TMFOCb(4562), QQXBLjLprwI58ya4VR.y8v8TMFOCb(20782)).Substring(0, Math.Min(ShotRegister.TestCase.Length, ShotRegister.MaxTestCaseLenght)));
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(20788));
		string text = defaultInterpolatedStringHandler.ToStringAndClear();
		string renameDirectoryShotFrom = directoryInfo2.FullName;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(12, 4);
		defaultInterpolatedStringHandler2.AppendFormatted(directoryInfo2.FullName);
		defaultInterpolatedStringHandler2.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(20782));
		defaultInterpolatedStringHandler2.AppendFormatted(ShotRegister.PlayerHanded);
		defaultInterpolatedStringHandler2.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(20782));
		defaultInterpolatedStringHandler2.AppendFormatted(ShotRegister.ClubNature);
		defaultInterpolatedStringHandler2.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(20782));
		defaultInterpolatedStringHandler2.AppendFormatted(ShotRegister.TestCase.Replace(QQXBLjLprwI58ya4VR.y8v8TMFOCb(4562), QQXBLjLprwI58ya4VR.y8v8TMFOCb(20782)).Substring(0, Math.Min(ShotRegister.TestCase.Length, ShotRegister.MaxTestCaseLenght)));
		defaultInterpolatedStringHandler2.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(20788));
		string renameDirectroyShotTo = defaultInterpolatedStringHandler2.ToStringAndClear();
		await Ek4QmPYSRI(fullName, text);
		await Ek4QmPYSRI(renameDirectoryShotFrom, renameDirectroyShotTo);
	}

	private async Task Ek4QmPYSRI(string P_0, string P_1)
	{
		try
		{
			Directory.Move(P_0, P_1);
		}
		catch (Exception ex)
		{
			ICircularLogService voXQlLbF6L = VoXQlLbF6L;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(52, 3);
			defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(20482));
			defaultInterpolatedStringHandler.AppendFormatted(P_0);
			defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(20542));
			defaultInterpolatedStringHandler.AppendFormatted(P_1);
			defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(20554));
			defaultInterpolatedStringHandler.AppendFormatted(ex.Message);
			voXQlLbF6L.Log(defaultInterpolatedStringHandler.ToStringAndClear(), LogLevel.Error);
			await L80QZtB1DP.ShowMessageAsync(this, QQXBLjLprwI58ya4VR.y8v8TMFOCb(12418), QQXBLjLprwI58ya4VR.y8v8TMFOCb(20598));
		}
	}

	private async Task PmRQu7oN6D(FileInfo P_0)
	{
		try
		{
			await Os0Q2UGcQh.LoadXmlDocument(P_0.FullName);
			kdfQJ43gM3(Os0Q2UGcQh.DocumentHandle, QQXBLjLprwI58ya4VR.y8v8TMFOCb(19558), QQXBLjLprwI58ya4VR.y8v8TMFOCb(19582), ShotRegister.BallDirection);
			kdfQJ43gM3(Os0Q2UGcQh.DocumentHandle, QQXBLjLprwI58ya4VR.y8v8TMFOCb(19558), QQXBLjLprwI58ya4VR.y8v8TMFOCb(19622), ShotRegister.LaunchAngle);
			kdfQJ43gM3(Os0Q2UGcQh.DocumentHandle, QQXBLjLprwI58ya4VR.y8v8TMFOCb(19558), QQXBLjLprwI58ya4VR.y8v8TMFOCb(19666), ShotRegister.BallSpeed);
			kdfQJ43gM3(Os0Q2UGcQh.DocumentHandle, QQXBLjLprwI58ya4VR.y8v8TMFOCb(19558), QQXBLjLprwI58ya4VR.y8v8TMFOCb(19698), ShotRegister.SideSpin);
			kdfQJ43gM3(Os0Q2UGcQh.DocumentHandle, QQXBLjLprwI58ya4VR.y8v8TMFOCb(19558), QQXBLjLprwI58ya4VR.y8v8TMFOCb(19736), ShotRegister.BackSpin);
			kdfQJ43gM3(Os0Q2UGcQh.DocumentHandle, QQXBLjLprwI58ya4VR.y8v8TMFOCb(19558), QQXBLjLprwI58ya4VR.y8v8TMFOCb(19774), ShotReceived.Ball.SideSpin);
			kdfQJ43gM3(Os0Q2UGcQh.DocumentHandle, QQXBLjLprwI58ya4VR.y8v8TMFOCb(19558), QQXBLjLprwI58ya4VR.y8v8TMFOCb(19814), ShotReceived.Ball.BackSpin);
			kdfQJ43gM3(Os0Q2UGcQh.DocumentHandle, QQXBLjLprwI58ya4VR.y8v8TMFOCb(19854), QQXBLjLprwI58ya4VR.y8v8TMFOCb(19878), ShotRegister.ClubPath);
			kdfQJ43gM3(Os0Q2UGcQh.DocumentHandle, QQXBLjLprwI58ya4VR.y8v8TMFOCb(19854), QQXBLjLprwI58ya4VR.y8v8TMFOCb(19666), ShotRegister.ClubSpeed);
			kdfQJ43gM3(Os0Q2UGcQh.DocumentHandle, QQXBLjLprwI58ya4VR.y8v8TMFOCb(19854), QQXBLjLprwI58ya4VR.y8v8TMFOCb(19908), ShotRegister.ClubFace);
			kdfQJ43gM3(Os0Q2UGcQh.DocumentHandle, QQXBLjLprwI58ya4VR.y8v8TMFOCb(19854), QQXBLjLprwI58ya4VR.y8v8TMFOCb(19946), ShotRegister.ClubBallHitPositionPercentage);
			kdfQJ43gM3(Os0Q2UGcQh.DocumentHandle, QQXBLjLprwI58ya4VR.y8v8TMFOCb(20004), QQXBLjLprwI58ya4VR.y8v8TMFOCb(20018), ShotRegister.TestCase);
			Os0Q2UGcQh.DocumentHandle.Save(P_0.FullName);
		}
		catch (Exception ex)
		{
			VoXQlLbF6L.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(20060) + ex.Message, LogLevel.Error);
			await L80QZtB1DP.ShowMessageAsync(this, QQXBLjLprwI58ya4VR.y8v8TMFOCb(12418), QQXBLjLprwI58ya4VR.y8v8TMFOCb(20168));
		}
	}

	private void kdfQJ43gM3<uktUCHHK9FK94HsRQn>(XmlDocument P_0, string P_1, string P_2, uktUCHHK9FK94HsRQn T98uhWEvqVrQYCDMfI)
	{
		XmlNode? xmlNode = P_0.SelectSingleNode(P_1);
		if (xmlNode == null)
		{
			VoXQlLbF6L?.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(7106) + P_1 + QQXBLjLprwI58ya4VR.y8v8TMFOCb(7120), LogLevel.Error);
			throw new NullReferenceException(QQXBLjLprwI58ya4VR.y8v8TMFOCb(7106) + P_1 + QQXBLjLprwI58ya4VR.y8v8TMFOCb(7120));
		}
		XmlNode xmlNode2 = P_0.CreateElement(P_2);
		xmlNode2.InnerText = T98uhWEvqVrQYCDMfI.ToString() ?? string.Empty;
		xmlNode.AppendChild(xmlNode2);
	}

	public void Dispose()
	{
		if (rZ0Qklvaxg?.OnNewShotSent != null && VJsQgJysOe == IdraMode.ShotRegistration)
		{
			IGICTSDirector iGICTSDirector = rZ0Qklvaxg;
			iGICTSDirector.OnNewShotSent = (Func<CTSShotData, Task>)Delegate.Remove(iGICTSDirector.OnNewShotSent, new Func<CTSShotData, Task>(fY1QRFAa2i));
		}
	}

	[CompilerGenerated]
	private async Task OUjQOgeSSt()
	{
		yQGQ4OMHJ8 = false;
	}

	[CompilerGenerated]
	private async Task BEiQM0Yp8D()
	{
		while (yQGQ4OMHJ8)
		{
			await Task.Delay(100);
		}
		yQGQ4OMHJ8 = true;
		new DirectoryInfo(IDRAConstant.GICTSSamplesResultsFolder + QQXBLjLprwI58ya4VR.y8v8TMFOCb(18666) + ShotReceived.ShotName);
		new DirectoryInfo(IDRAConstant.GICTSSamplesShotsFolder + QQXBLjLprwI58ya4VR.y8v8TMFOCb(18666) + ShotReceived.ShotName);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 3);
		defaultInterpolatedStringHandler.AppendFormatted(IDRAConstant.GICTSSamplesResultsFolder);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(18666));
		defaultInterpolatedStringHandler.AppendFormatted(ShotReceived.ShotName);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(18666));
		defaultInterpolatedStringHandler.AppendFormatted(ShotReceived.ShotName);
		defaultInterpolatedStringHandler.AppendLiteral(QQXBLjLprwI58ya4VR.y8v8TMFOCb(18672));
		string text = defaultInterpolatedStringHandler.ToStringAndClear();
		FileInfo fileInfo = new FileInfo(text);
		if (fileInfo == null || !fileInfo.Exists)
		{
			VoXQlLbF6L.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(18694) + text, LogLevel.Error);
			await L80QZtB1DP.ShowMessageAsync(this, QQXBLjLprwI58ya4VR.y8v8TMFOCb(12418), QQXBLjLprwI58ya4VR.y8v8TMFOCb(18694) + text);
			return;
		}
		await PmRQu7oN6D(fileInfo);
		await wLnQbMDekN();
		await YgaQ6inF9s();
		TgEQA0f6Ik.NavigateTo(VM.Main);
	}

	[CompilerGenerated]
	private void gDAQPEPumf()
	{
		VoXQlLbF6L.Log(QQXBLjLprwI58ya4VR.y8v8TMFOCb(7156));
		TgEQA0f6Ik.NavigateTo(VM.Main);
	}
}
