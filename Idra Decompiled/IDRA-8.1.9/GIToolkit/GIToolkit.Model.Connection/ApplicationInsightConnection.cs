namespace GIToolkit.Model.Connection;

public static class ApplicationInsightConnection
{
	public static class Maui
	{
		public const string DEV = "InstrumentationKey=2e7f40ec-e5ef-46ff-a0cd-1b6347c9c300;IngestionEndpoint=https://canadaeast-0.in.applicationinsights.azure.com/";

		public const string QA = "InstrumentationKey=faa1c762-ff17-48b5-b7a7-1f4302404887;IngestionEndpoint=https://canadaeast-0.in.applicationinsights.azure.com/";

		public const string PROD = "InstrumentationKey=21c2ee9b-9fa5-44fe-9399-6e073c3b1415;IngestionEndpoint=https://canadaeast-0.in.applicationinsights.azure.com/";
	}
}
