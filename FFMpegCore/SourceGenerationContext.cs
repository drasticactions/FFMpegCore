using System.Text.Json.Serialization;
using FFMpegCore;

[JsonSourceGenerationOptions(
    WriteIndented = true,
    PropertyNameCaseInsensitive = true,
    NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull | JsonIgnoreCondition.WhenWritingDefault)]
[JsonSerializable(typeof(FFOptions))]
[JsonSerializable(typeof(FFProbeAnalysis))]
[JsonSerializable(typeof(FFProbeFrames))]
[JsonSerializable(typeof(FFProbePackets))]
internal partial class SourceGenerationContext : JsonSerializerContext
{
}