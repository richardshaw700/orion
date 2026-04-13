using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using GhU84wwqvI4UZ3pBfu;
using sxB8TYTZ87aKuujytY;

namespace IDRA.GIControls;

public class CircleIndicator : Shape
{
	public static readonly DependencyProperty IsValidProperty;

	public bool IsValid
	{
		get
		{
			return (bool)((DependencyObject)this).GetValue(IsValidProperty);
		}
		set
		{
			((DependencyObject)this).SetValue(IsValidProperty, (object)value);
		}
	}

	protected override Geometry DefiningGeometry => (Geometry)new EllipseGeometry(new Point(((FrameworkElement)this).Width / 2.0, ((FrameworkElement)this).Height / 2.0), ((FrameworkElement)this).Width / 2.0, ((FrameworkElement)this).Height / 2.0);

	private static void Vo4Cy7Im1r(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		((Shape)(CircleIndicator)(object)P_0).Fill = (Brush)(((bool)((DependencyPropertyChangedEventArgs)(ref P_1)).NewValue) ? new SolidColorBrush(Colors.Green) : new SolidColorBrush(Colors.Red));
	}

	public CircleIndicator()
	{
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		((Shape)this)._002Ector();
	}

	static CircleIndicator()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		RggQeDNtlTAVQmKw9V.WCYsuJthg9fuX();
		IsValidProperty = DependencyProperty.Register(QQXBLjLprwI58ya4VR.y8v8TMFOCb(11502), typeof(bool), typeof(CircleIndicator), new PropertyMetadata((object)false, new PropertyChangedCallback(Vo4Cy7Im1r)));
	}
}
