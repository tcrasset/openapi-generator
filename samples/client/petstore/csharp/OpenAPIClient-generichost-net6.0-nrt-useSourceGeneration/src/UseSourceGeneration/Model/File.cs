// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = UseSourceGeneration.Client.ClientUtils;
using System.Text.Json.Serialization.Metadata;
using UseSourceGeneration.Client;

namespace UseSourceGeneration.Model
{
    /// <summary>
    /// Must be named &#x60;File&#x60; for test.
    /// </summary>
    public partial class File : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        /// <param name="sourceURI">Test capitalization</param>
        [JsonConstructor]
        public File(string sourceURI)
        {
            SourceURI = sourceURI;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Test capitalization
        /// </summary>
        /// <value>Test capitalization</value>
        [JsonPropertyName("sourceURI")]
        public string SourceURI { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class File {\n");
            sb.Append("  SourceURI: ").Append(SourceURI).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="File" />
    /// </summary>
    public class FileJsonConverter : JsonConverter<File>
    {
        /// <summary>
        /// Deserializes json to <see cref="File" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override File Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            string? sourceURI = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "sourceURI":
                            sourceURI = utf8JsonReader.GetString();
                            break;
                        default:
                            break;
                    }
                }
            }

            if (sourceURI == null)
                throw new ArgumentNullException(nameof(sourceURI), "Property is required for class File.");

            return new File(sourceURI);
        }

        /// <summary>
        /// Serializes a <see cref="File" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="file"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, File file, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, file, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="File" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="file"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, File file, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteString("sourceURI", file.SourceURI);
        }
    }

    /// <summary>
    /// The FileSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(File))]
    public partial class FileSerializationContext : JsonSerializerContext
    {
        /// <summary>
        /// The FileSerializationContext
        /// </summary>
        /// <param name="optionsProvider"></param>
        public FileSerializationContext(JsonSerializerOptionsProvider optionsProvider): base(new(optionsProvider.Options))
        {
        }
    }

    /// <summary>
    /// FileDeserializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata)]
    [JsonSerializable(typeof(File))]
    public partial class FileDeserializationContext : JsonSerializerContext
    {
        /// <summary>
        /// FileDeserializationContext
        /// </summary>
        /// <param name="optionsProvider"></param>
        public FileDeserializationContext(JsonSerializerOptionsProvider optionsProvider): base(new(optionsProvider.Options))
        {
        }
    }
}
