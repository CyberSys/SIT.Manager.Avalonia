﻿using System;
using System.Text.Json.Serialization;

namespace SIT.Manager.Models.Github;

public class Asset
{
    [JsonPropertyName("url")]
    public string? Url { get; set; }
    [JsonPropertyName("browser_download_url")]
    public required string BrowserDownloadUrl { get; set; }
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("node_id")]
    public string? NodeId { get; set; }
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    [JsonPropertyName("label")]
    public string? Label { get; set; }
    [JsonPropertyName("state")]
    public string? State { get; set; }
    [JsonPropertyName("content_type")]
    public string? ContentType { get; set; }
    [JsonPropertyName("size")]
    public int Size { get; set; }
    [JsonPropertyName("download_count")]
    public int DownloadCount { get; set; }
    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }
    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }
    [JsonPropertyName("uploader")]
    public Uploader? Uploader { get; set; }
}
