/*
 * FreeClimb API
 *
 * FreeClimb is a cloud-based application programming interface (API) that puts the power of the Vail platform in your hands. FreeClimb simplifies the process of creating applications that can use a full range of telephony features without requiring specialized or on-site telephony equipment. Using the FreeClimb REST API to write applications is easy! You have the option to use the language of your choice or hit the API directly. Your application can execute a command by issuing a RESTful request to the FreeClimb API. The base URL to send HTTP requests to the FreeClimb REST API is: /apiserver. FreeClimb authenticates and processes your request.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@freeclimb.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = freeclimb.Client.OpenAPIDateConverter;
using freeclimb.Enums;

namespace freeclimb.Model
{
    /// <summary>
    /// The &#x60;Enqueue&#x60; command adds the current Call to a call Queue. If the specified Queue does not exist, it is created and then the Call is added to it. The default maximum length of the queue is 100. This can be modified using the REST API.
    /// </summary>
    [DataContract(Name = "Enqueue")]
    [JsonConverter(typeof(JsonSubtypes), "Command")]
    [JsonSubtypes.KnownSubType(typeof(AddToConference), "AddToConference")]
    [JsonSubtypes.KnownSubType(typeof(CreateConference), "CreateConference")]
    [JsonSubtypes.KnownSubType(typeof(Dequeue), "Dequeue")]
    [JsonSubtypes.KnownSubType(typeof(Enqueue), "Enqueue")]
    [JsonSubtypes.KnownSubType(typeof(GetDigits), "GetDigits")]
    [JsonSubtypes.KnownSubType(typeof(GetSpeech), "GetSpeech")]
    [JsonSubtypes.KnownSubType(typeof(Hangup), "Hangup")]
    [JsonSubtypes.KnownSubType(typeof(OutDial), "OutDial")]
    [JsonSubtypes.KnownSubType(typeof(Park), "Park")]
    [JsonSubtypes.KnownSubType(typeof(Pause), "Pause")]
    [JsonSubtypes.KnownSubType(typeof(Play), "Play")]
    [JsonSubtypes.KnownSubType(typeof(PlayEarlyMedia), "PlayEarlyMedia")]
    [JsonSubtypes.KnownSubType(typeof(RecordUtterance), "RecordUtterance")]
    [JsonSubtypes.KnownSubType(typeof(Redirect), "Redirect")]
    [JsonSubtypes.KnownSubType(typeof(Reject), "Reject")]
    [JsonSubtypes.KnownSubType(typeof(RemoveFromConference), "RemoveFromConference")]
    [JsonSubtypes.KnownSubType(typeof(Say), "Say")]
    [JsonSubtypes.KnownSubType(typeof(SendDigits), "SendDigits")]
    [JsonSubtypes.KnownSubType(typeof(SetListen), "SetListen")]
    [JsonSubtypes.KnownSubType(typeof(SetTalk), "SetTalk")]
    [JsonSubtypes.KnownSubType(typeof(Sms), "Sms")]
    [JsonSubtypes.KnownSubType(typeof(StartRecordCall), "StartRecordCall")]
    [JsonSubtypes.KnownSubType(typeof(TerminateConference), "TerminateConference")]
    [JsonSubtypes.KnownSubType(typeof(Unpark), "Unpark")]
    public partial class Enqueue : PerclCommand, IEquatable<Enqueue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Enqueue" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Enqueue() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Enqueue" /> class.
        /// </summary>
        /// <param name="actionUrl">A request is made to this URL when the Call leaves the Queue, which can occur if enqueue of the Call fails or when the call is dequeued via the &#x60;Dequeue&#x60; command, the REST API (POST to Queue Member resource), or the caller hangs up. (required).</param>
        /// <param name="notificationUrl">URL to be invoked when the call enters the queue. The request to the URL contains the standard request parameters.This is a notification only; any PerCL returned will be ignored..</param>
        /// <param name="queueId">ID of the Queue to which to add the Call. If the Queue does not exist, it will be created. The ID must start with QU followed by 40 hex characters. (required).</param>
        /// <param name="waitUrl">A request is made to this URL when the Call leaves the Queue, which can occur if enqueue of the Call fails or when the call is dequeued via the &#x60;Dequeue&#x60; command, the REST API (POST to Queue Member resource), or the caller hangs up. (required).</param>
        /// <param name="command">Name of PerCL Command (this is automatically derived from mapping configuration and should not be manually supplied in any arguments) (default to &quot;Enqueue&quot;).</param>
        public Enqueue(string actionUrl = default(string), string notificationUrl = default(string), string queueId = default(string), string waitUrl = default(string), string command = "Enqueue") : base(command)
        {
            // to ensure "actionUrl" is required (not null)
            if (actionUrl == null) {
                throw new ArgumentNullException("actionUrl is a required property for Enqueue and cannot be null");
            }
            this.ActionUrl = actionUrl;
            // to ensure "queueId" is required (not null)
            if (queueId == null) {
                throw new ArgumentNullException("queueId is a required property for Enqueue and cannot be null");
            }
            this.QueueId = queueId;
            // to ensure "waitUrl" is required (not null)
            if (waitUrl == null) {
                throw new ArgumentNullException("waitUrl is a required property for Enqueue and cannot be null");
            }
            this.WaitUrl = waitUrl;
            this.NotificationUrl = notificationUrl;
        }

        /// <summary>
        /// A request is made to this URL when the Call leaves the Queue, which can occur if enqueue of the Call fails or when the call is dequeued via the &#x60;Dequeue&#x60; command, the REST API (POST to Queue Member resource), or the caller hangs up.
        /// </summary>
        /// <value>A request is made to this URL when the Call leaves the Queue, which can occur if enqueue of the Call fails or when the call is dequeued via the &#x60;Dequeue&#x60; command, the REST API (POST to Queue Member resource), or the caller hangs up.</value>
        [DataMember(Name = "actionUrl", IsRequired = true, EmitDefaultValue = false)]
        public string ActionUrl { get; set; }

        /// <summary>
        /// URL to be invoked when the call enters the queue. The request to the URL contains the standard request parameters.This is a notification only; any PerCL returned will be ignored.
        /// </summary>
        /// <value>URL to be invoked when the call enters the queue. The request to the URL contains the standard request parameters.This is a notification only; any PerCL returned will be ignored.</value>
        [DataMember(Name = "notificationUrl", EmitDefaultValue = false)]
        public string NotificationUrl { get; set; }

        /// <summary>
        /// ID of the Queue to which to add the Call. If the Queue does not exist, it will be created. The ID must start with QU followed by 40 hex characters.
        /// </summary>
        /// <value>ID of the Queue to which to add the Call. If the Queue does not exist, it will be created. The ID must start with QU followed by 40 hex characters.</value>
        [DataMember(Name = "queueId", IsRequired = true, EmitDefaultValue = false)]
        public string QueueId { get; set; }

        /// <summary>
        /// A request is made to this URL when the Call leaves the Queue, which can occur if enqueue of the Call fails or when the call is dequeued via the &#x60;Dequeue&#x60; command, the REST API (POST to Queue Member resource), or the caller hangs up.
        /// </summary>
        /// <value>A request is made to this URL when the Call leaves the Queue, which can occur if enqueue of the Call fails or when the call is dequeued via the &#x60;Dequeue&#x60; command, the REST API (POST to Queue Member resource), or the caller hangs up.</value>
        [DataMember(Name = "waitUrl", IsRequired = true, EmitDefaultValue = false)]
        public string WaitUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Enqueue {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ActionUrl: ").Append(ActionUrl).Append("\n");
            sb.Append("  NotificationUrl: ").Append(NotificationUrl).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  WaitUrl: ").Append(WaitUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            JsonSerializer jsonSerializer = JsonSerializer.Create();
            jsonSerializer.NullValueHandling = NullValueHandling.Ignore;

            StringBuilder strb = new StringBuilder();
            jsonSerializer.Serialize(new StringWriter(strb), ToKvp());

            return strb.ToString();
        }

        /// <summary>
        /// Retrieve the KVP Dictionary for the Enqueue instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public override IDictionary<string, object> ToKvp()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("actionUrl", ActionUrl);          
            props.Add("notificationUrl", NotificationUrl);          
            props.Add("queueId", QueueId);          
            props.Add("waitUrl", WaitUrl);          
            IDictionary<string, object> command = new Dictionary<string, object>();
            command.Add("Enqueue",props);
            return command;
        }
        
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Enqueue);
        }

        /// <summary>
        /// Returns true if Enqueue instances are equal
        /// </summary>
        /// <param name="input">Instance of Enqueue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Enqueue input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.ActionUrl == input.ActionUrl ||
                    (this.ActionUrl != null &&
                    this.ActionUrl.Equals(input.ActionUrl))
                ) && base.Equals(input) && 
                (
                    this.NotificationUrl == input.NotificationUrl ||
                    (this.NotificationUrl != null &&
                    this.NotificationUrl.Equals(input.NotificationUrl))
                ) && base.Equals(input) && 
                (
                    this.QueueId == input.QueueId ||
                    (this.QueueId != null &&
                    this.QueueId.Equals(input.QueueId))
                ) && base.Equals(input) && 
                (
                    this.WaitUrl == input.WaitUrl ||
                    (this.WaitUrl != null &&
                    this.WaitUrl.Equals(input.WaitUrl))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.ActionUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ActionUrl.GetHashCode();
                }
                if (this.NotificationUrl != null)
                {
                    hashCode = (hashCode * 59) + this.NotificationUrl.GetHashCode();
                }
                if (this.QueueId != null)
                {
                    hashCode = (hashCode * 59) + this.QueueId.GetHashCode();
                }
                if (this.WaitUrl != null)
                {
                    hashCode = (hashCode * 59) + this.WaitUrl.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public override IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected override IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach (var x in BaseValidate(validationContext))
            {
                yield return x;
            }
            yield break;
        }
    }

}
