using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Markup;
using CommunityToolkit.Mvvm.Messaging;
using GICTSCore.Data;
using GhU84wwqvI4UZ3pBfu;
using IDRA.Auxiliary.Messages;
using MahApps.Metro.Controls;
using Unosquare.FFME;
using sxB8TYTZ87aKuujytY;

namespace IDRA.Views;

public class ContainerView : MetroWindow, IComponentConnector
{
	private bool bfJm9Ly8P;

	private bool oqYuFAVjW;

	public ContainerView()
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		base._002Ector();
		Library.FFmpegDirectory = Path.Combine(IDRAConstant.ExecutingAssembyDirectoryPath, QQXBLjLprwI58ya4VR.y8v8TMFOCb(996));
		InitializeComponent();
		WeakReferenceMessenger.Default.Register<CloseApplicationMessage>(this, eB56pwqu4);
	}

	private void eB56pwqu4(object P_0, CloseApplicationMessage P_1)
	{
		if (P_1.ExitCode == 100 && !bfJm9Ly8P)
		{
			bfJm9Ly8P = true;
			((Window)this).Close();
		}
	}

	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!oqYuFAVjW)
		{
			oqYuFAVjW = true;
			Uri uri = new Uri(QQXBLjLprwI58ya4VR.y8v8TMFOCb(1012), UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "10.0.5.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		oqYuFAVjW = true;
	}
}
