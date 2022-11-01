using System.Text.Json.Serialization;

namespace SessionMatch.SessionData
{
    internal class Root
    {
        [JsonPropertyName("plannedsessions")]
        public required IEnumerable<Session> Sessions { get; set; }
    }

    internal class Session
    {
        [JsonPropertyName("sessionSpeakerName")]
        public required string Speaker { get; set; }

        [JsonPropertyName("sessionDescription")]
        public required string Description { get; set; }

        [JsonPropertyName("sessionKeyTakeAway1")]
        public string? TakeAway1 { get; set; }

        [JsonPropertyName("sessionKeyTakeAway2")]
        public string? TakeAway2 { get; set; }

        [JsonPropertyName("sessionKeyTakeAway3")]
        public string? TakeAway3 { get; set; }

        [JsonPropertyName("sessionTagMain")]
        public string? MainTag { get; set; }

        [JsonPropertyName("sessionTags")]
        public required IEnumerable<string?> OtherTags{ get; set; }

        [JsonPropertyName("sessionTitle")]
        public required string Title { get; set; }

        [JsonPropertyName("sessionTitleShort")]
        public string? ShortTitle { get; set; }

        [JsonPropertyName("sessionScheduleDay"), JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public required short DayOfConference { get; set; }

        [JsonPropertyName("sessionScheduleTime")]
        public required TimeOnly TimeOfDay { get; set; }

        [JsonPropertyName("sessionScheduleRoom")]
        public required string Room { get; set; }
    }
}
