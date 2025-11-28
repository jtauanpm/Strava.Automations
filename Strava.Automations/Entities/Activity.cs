using System.Text.Json.Serialization;

namespace Strava.Automations.Entities;

public class Activity
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Start_Date { get; set; }
    [JsonPropertyName("gear_id")]
    public string IdTenis { get; set; }
}