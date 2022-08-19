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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = freeclimb.Client.OpenAPIDateConverter;

namespace freeclimb.Model
{
    /// <summary>
    /// MessageResultAllOf
    /// </summary>
    [DataContract(Name = "MessageResult_allOf")]
    public partial class MessageResultAllOf : IEquatable<MessageResultAllOf>, IValidatableObject
    {
        /// <summary>
        /// Indicates the state of the message through the message lifecycle including: new, queued, rejected, sending, sent, failed, received, undelivered, expired, deleted, and unknown
        /// </summary>
        /// <value>Indicates the state of the message through the message lifecycle including: new, queued, rejected, sending, sent, failed, received, undelivered, expired, deleted, and unknown</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum New for value: new
            /// </summary>
            [EnumMember(Value = "new")]
            New = 1,

            /// <summary>
            /// Enum Queued for value: queued
            /// </summary>
            [EnumMember(Value = "queued")]
            Queued = 2,

            /// <summary>
            /// Enum Rejected for value: rejected
            /// </summary>
            [EnumMember(Value = "rejected")]
            Rejected = 3,

            /// <summary>
            /// Enum Sending for value: sending
            /// </summary>
            [EnumMember(Value = "sending")]
            Sending = 4,

            /// <summary>
            /// Enum Sent for value: sent
            /// </summary>
            [EnumMember(Value = "sent")]
            Sent = 5,

            /// <summary>
            /// Enum Failed for value: failed
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed = 6,

            /// <summary>
            /// Enum Received for value: received
            /// </summary>
            [EnumMember(Value = "received")]
            Received = 7,

            /// <summary>
            /// Enum Undelivered for value: undelivered
            /// </summary>
            [EnumMember(Value = "undelivered")]
            Undelivered = 8,

            /// <summary>
            /// Enum Expired for value: expired
            /// </summary>
            [EnumMember(Value = "expired")]
            Expired = 9,

            /// <summary>
            /// Enum Deleted for value: deleted
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted = 10,

            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 11

        }


        /// <summary>
        /// Indicates the state of the message through the message lifecycle including: new, queued, rejected, sending, sent, failed, received, undelivered, expired, deleted, and unknown
        /// </summary>
        /// <value>Indicates the state of the message through the message lifecycle including: new, queued, rejected, sending, sent, failed, received, undelivered, expired, deleted, and unknown</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageResultAllOf" /> class.
        /// </summary>
        /// <param name="accountId">String that uniquely identifies this account resource..</param>
        /// <param name="messageId">String that uniquely identifies this message resource.</param>
        /// <param name="status">Indicates the state of the message through the message lifecycle including: new, queued, rejected, sending, sent, failed, received, undelivered, expired, deleted, and unknown.</param>
        /// <param name="from">Phone number in E.164 format that sent the message..</param>
        /// <param name="to">Phone number in E.164 format that received the message..</param>
        /// <param name="text">Message contents.</param>
        /// <param name="direction">Noting whether the message was inbound or outbound.</param>
        /// <param name="notificationUrl">URL invoked when message sent.</param>
        public MessageResultAllOf(string accountId = default(string), string messageId = default(string), StatusEnum? status = default(StatusEnum?), string from = default(string), string to = default(string), string text = default(string), string direction = default(string), string notificationUrl = default(string))
        {
            this.AccountId = accountId;
            this.MessageId = messageId;
            this.Status = status;
            this.From = from;
            this.To = to;
            this.Text = text;
            this.Direction = direction;
            this.NotificationUrl = notificationUrl;
        }

        /// <summary>
        /// String that uniquely identifies this account resource.
        /// </summary>
        /// <value>String that uniquely identifies this account resource.</value>
        [DataMember(Name = "accountId", EmitDefaultValue = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// String that uniquely identifies this message resource
        /// </summary>
        /// <value>String that uniquely identifies this message resource</value>
        [DataMember(Name = "messageId", EmitDefaultValue = true)]
        public string MessageId { get; set; }

        /// <summary>
        /// Phone number in E.164 format that sent the message.
        /// </summary>
        /// <value>Phone number in E.164 format that sent the message.</value>
        [DataMember(Name = "from", EmitDefaultValue = true)]
        public string From { get; set; }

        /// <summary>
        /// Phone number in E.164 format that received the message.
        /// </summary>
        /// <value>Phone number in E.164 format that received the message.</value>
        [DataMember(Name = "to", EmitDefaultValue = true)]
        public string To { get; set; }

        /// <summary>
        /// Message contents
        /// </summary>
        /// <value>Message contents</value>
        [DataMember(Name = "text", EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// Noting whether the message was inbound or outbound
        /// </summary>
        /// <value>Noting whether the message was inbound or outbound</value>
        [DataMember(Name = "direction", EmitDefaultValue = true)]
        public string Direction { get; set; }

        /// <summary>
        /// URL invoked when message sent
        /// </summary>
        /// <value>URL invoked when message sent</value>
        [DataMember(Name = "notificationUrl", EmitDefaultValue = true)]
        public string NotificationUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MessageResultAllOf {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  NotificationUrl: ").Append(NotificationUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Retrieve the KVP Dictionary for the MessageResultAllOf instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public virtual IDictionary<string, object> ToKvp()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("accountId", AccountId);          
            props.Add("messageId", MessageId);          
            props.Add("status", Status);          
            props.Add("from", From);          
            props.Add("to", To);          
            props.Add("text", Text);          
            props.Add("direction", Direction);          
            props.Add("notificationUrl", NotificationUrl);          
            return props;
        }
        
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MessageResultAllOf);
        }

        /// <summary>
        /// Returns true if MessageResultAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageResultAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageResultAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.NotificationUrl == input.NotificationUrl ||
                    (this.NotificationUrl != null &&
                    this.NotificationUrl.Equals(input.NotificationUrl))
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
                int hashCode = 41;
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.MessageId != null)
                {
                    hashCode = (hashCode * 59) + this.MessageId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.Text != null)
                {
                    hashCode = (hashCode * 59) + this.Text.GetHashCode();
                }
                if (this.Direction != null)
                {
                    hashCode = (hashCode * 59) + this.Direction.GetHashCode();
                }
                if (this.NotificationUrl != null)
                {
                    hashCode = (hashCode * 59) + this.NotificationUrl.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}