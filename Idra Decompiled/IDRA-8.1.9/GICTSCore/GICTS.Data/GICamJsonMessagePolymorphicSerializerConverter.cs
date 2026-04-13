using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using JdN3qlxpK1fXeWoSKd;
using lKEAGvFqWp7B16kDoY;

namespace GICTS.Data;

public class GICamJsonMessagePolymorphicSerializerConverter : JsonConverter<JsonMessage>
{
	public override JsonMessage Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 1);
		defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7072));
		defaultInterpolatedStringHandler.AppendFormatted(typeToConvert);
		defaultInterpolatedStringHandler.AppendLiteral(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(7144));
		throw new NotSupportedException(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	public override void Write(Utf8JsonWriter writer, JsonMessage value, JsonSerializerOptions options)
	{
		JsonSerializer.Serialize(writer, value, value.GetType(), options);
	}

	public GICamJsonMessagePolymorphicSerializerConverter()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		base._002Ector();
	}
}
