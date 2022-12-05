# freeclimb - the C# library for the FreeClimb API

FreeClimb is a cloud-based application programming interface (API) that puts the power of the Vail platform in your hands. FreeClimb simplifies the process of creating applications that can use a full range of telephony features without requiring specialized or on-site telephony equipment. Using the FreeClimb REST API to write applications is easy! You have the option to use the language of your choice or hit the API directly. Your application can execute a command by issuing a RESTful request to the FreeClimb API. The base URL to send HTTP requests to the FreeClimb REST API is: /apiserver. FreeClimb authenticates and processes your request.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0.0
- SDK version: 4.1.1
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://www.freeclimb.com/support/](https://www.freeclimb.com/support/)

<a name="frameworks-supported"></a>
## Frameworks supported

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out freeclimb.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var buyIncomingNumberRequest = new BuyIncomingNumberRequest(); // BuyIncomingNumberRequest | Incoming Number transaction details

            try
            {
                // Buy a Phone Number
                IncomingNumberResult result = apiInstance.BuyAPhoneNumber(buyIncomingNumberRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.BuyAPhoneNumber: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://www.freeclimb.com/apiserver*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DefaultApi* | [**BuyAPhoneNumber**](docs/DefaultApi.md#buyaphonenumber) | **POST** /Accounts/{accountId}/IncomingPhoneNumbers | Buy a Phone Number
*DefaultApi* | [**CreateAConference**](docs/DefaultApi.md#createaconference) | **POST** /Accounts/{accountId}/Conferences | Create a Conference
*DefaultApi* | [**CreateAQueue**](docs/DefaultApi.md#createaqueue) | **POST** /Accounts/{accountId}/Queues | Create a Queue
*DefaultApi* | [**CreateAnApplication**](docs/DefaultApi.md#createanapplication) | **POST** /Accounts/{accountId}/Applications | Create an application
*DefaultApi* | [**DeleteARecording**](docs/DefaultApi.md#deletearecording) | **DELETE** /Accounts/{accountId}/Recordings/{recordingId} | Delete a Recording
*DefaultApi* | [**DeleteAnApplication**](docs/DefaultApi.md#deleteanapplication) | **DELETE** /Accounts/{accountId}/Applications/{applicationId} | Delete an application
*DefaultApi* | [**DeleteAnIncomingNumber**](docs/DefaultApi.md#deleteanincomingnumber) | **DELETE** /Accounts/{accountId}/IncomingPhoneNumbers/{phoneNumberId} | Delete an Incoming Number
*DefaultApi* | [**DequeueAMember**](docs/DefaultApi.md#dequeueamember) | **POST** /Accounts/{accountId}/Queues/{queueId}/Members/{callId} | Dequeue a Member
*DefaultApi* | [**DequeueHeadMember**](docs/DefaultApi.md#dequeueheadmember) | **POST** /Accounts/{accountId}/Queues/{queueId}/Members/Front | Dequeue Head Member
*DefaultApi* | [**DownloadARecordingFile**](docs/DefaultApi.md#downloadarecordingfile) | **GET** /Accounts/{accountId}/Recordings/{recordingId}/Download | Download a Recording File
*DefaultApi* | [**FilterLogs**](docs/DefaultApi.md#filterlogs) | **POST** /Accounts/{accountId}/Logs | Filter Logs
*DefaultApi* | [**GetACall**](docs/DefaultApi.md#getacall) | **GET** /Accounts/{accountId}/Calls/{callId} | Get a Call
*DefaultApi* | [**GetAConference**](docs/DefaultApi.md#getaconference) | **GET** /Accounts/{accountId}/Conferences/{conferenceId} | Get a Conference
*DefaultApi* | [**GetAMember**](docs/DefaultApi.md#getamember) | **GET** /Accounts/{accountId}/Queues/{queueId}/Members/{callId} | Get a Member
*DefaultApi* | [**GetAParticipant**](docs/DefaultApi.md#getaparticipant) | **GET** /Accounts/{accountId}/Conferences/{conferenceId}/Participants/{callId} | Get a Participant
*DefaultApi* | [**GetAQueue**](docs/DefaultApi.md#getaqueue) | **GET** /Accounts/{accountId}/Queues/{queueId} | Get a Queue
*DefaultApi* | [**GetARecording**](docs/DefaultApi.md#getarecording) | **GET** /Accounts/{accountId}/Recordings/{recordingId} | Get a Recording
*DefaultApi* | [**GetAnAccount**](docs/DefaultApi.md#getanaccount) | **GET** /Accounts/{accountId} | Get an Account
*DefaultApi* | [**GetAnApplication**](docs/DefaultApi.md#getanapplication) | **GET** /Accounts/{accountId}/Applications/{applicationId} | Get an Application
*DefaultApi* | [**GetAnIncomingNumber**](docs/DefaultApi.md#getanincomingnumber) | **GET** /Accounts/{accountId}/IncomingPhoneNumbers/{phoneNumberId} | Get an Incoming Number
*DefaultApi* | [**GetAnSmsMessage**](docs/DefaultApi.md#getansmsmessage) | **GET** /Accounts/{accountId}/Messages/{messageId} | Get an SMS Message
*DefaultApi* | [**GetHeadMember**](docs/DefaultApi.md#getheadmember) | **GET** /Accounts/{accountId}/Queues/{queueId}/Members/Front | Get Head Member
*DefaultApi* | [**ListActiveQueues**](docs/DefaultApi.md#listactivequeues) | **GET** /Accounts/{accountId}/Queues | List Active Queues
*DefaultApi* | [**ListAllAccountLogs**](docs/DefaultApi.md#listallaccountlogs) | **GET** /Accounts/{accountId}/Logs | List All Account Logs
*DefaultApi* | [**ListApplications**](docs/DefaultApi.md#listapplications) | **GET** /Accounts/{accountId}/Applications | List applications
*DefaultApi* | [**ListAvailableNumbers**](docs/DefaultApi.md#listavailablenumbers) | **GET** /AvailablePhoneNumbers | List available numbers
*DefaultApi* | [**ListCallLogs**](docs/DefaultApi.md#listcalllogs) | **GET** /Accounts/{accountId}/Calls/{callId}/Logs | List Call Logs
*DefaultApi* | [**ListCallRecordings**](docs/DefaultApi.md#listcallrecordings) | **GET** /Accounts/{accountId}/Calls/{callId}/Recordings | List Call Recordings
*DefaultApi* | [**ListCalls**](docs/DefaultApi.md#listcalls) | **GET** /Accounts/{accountId}/Calls | List Calls
*DefaultApi* | [**ListConferences**](docs/DefaultApi.md#listconferences) | **GET** /Accounts/{accountId}/Conferences | List Conferences
*DefaultApi* | [**ListIncomingNumbers**](docs/DefaultApi.md#listincomingnumbers) | **GET** /Accounts/{accountId}/IncomingPhoneNumbers | List Incoming Numbers
*DefaultApi* | [**ListMembers**](docs/DefaultApi.md#listmembers) | **GET** /Accounts/{accountId}/Queues/{queueId}/Members | List Members
*DefaultApi* | [**ListParticipants**](docs/DefaultApi.md#listparticipants) | **GET** /Accounts/{accountId}/Conferences/{conferenceId}/Participants | List Participants
*DefaultApi* | [**ListRecordings**](docs/DefaultApi.md#listrecordings) | **GET** /Accounts/{accountId}/Recordings | List Recordings
*DefaultApi* | [**ListSmsMessages**](docs/DefaultApi.md#listsmsmessages) | **GET** /Accounts/{accountId}/Messages | List SMS Messages
*DefaultApi* | [**MakeACall**](docs/DefaultApi.md#makeacall) | **POST** /Accounts/{accountId}/Calls | Make a Call
*DefaultApi* | [**RemoveAParticipant**](docs/DefaultApi.md#removeaparticipant) | **DELETE** /Accounts/{accountId}/Conferences/{conferenceId}/Participants/{callId} | Remove a Participant
*DefaultApi* | [**SendAnSmsMessage**](docs/DefaultApi.md#sendansmsmessage) | **POST** /Accounts/{accountId}/Messages | Send an SMS Message
*DefaultApi* | [**StreamARecordingFile**](docs/DefaultApi.md#streamarecordingfile) | **GET** /Accounts/{accountId}/Recordings/{recordingId}/Stream | Stream a Recording File
*DefaultApi* | [**UpdateAConference**](docs/DefaultApi.md#updateaconference) | **POST** /Accounts/{accountId}/Conferences/{conferenceId} | Update a Conference
*DefaultApi* | [**UpdateALiveCall**](docs/DefaultApi.md#updatealivecall) | **POST** /Accounts/{accountId}/Calls/{callId} | Update a Live Call
*DefaultApi* | [**UpdateAParticipant**](docs/DefaultApi.md#updateaparticipant) | **POST** /Accounts/{accountId}/Conferences/{conferenceId}/Participants/{callId} | Update a Participant
*DefaultApi* | [**UpdateAQueue**](docs/DefaultApi.md#updateaqueue) | **POST** /Accounts/{accountId}/Queues/{queueId} | Update a Queue
*DefaultApi* | [**UpdateAnAccount**](docs/DefaultApi.md#updateanaccount) | **POST** /Accounts/{accountId} | Manage an account
*DefaultApi* | [**UpdateAnApplication**](docs/DefaultApi.md#updateanapplication) | **POST** /Accounts/{accountId}/Applications/{applicationId} | Update an application
*DefaultApi* | [**UpdateAnIncomingNumber**](docs/DefaultApi.md#updateanincomingnumber) | **POST** /Accounts/{accountId}/IncomingPhoneNumbers/{phoneNumberId} | Update an Incoming Number


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AccountRequest](docs/AccountRequest.md)
 - [Model.AccountResult](docs/AccountResult.md)
 - [Model.AccountResultAllOf](docs/AccountResultAllOf.md)
 - [Model.AddToConference](docs/AddToConference.md)
 - [Model.AddToConferenceAllOf](docs/AddToConferenceAllOf.md)
 - [Model.ApplicationList](docs/ApplicationList.md)
 - [Model.ApplicationListAllOf](docs/ApplicationListAllOf.md)
 - [Model.ApplicationRequest](docs/ApplicationRequest.md)
 - [Model.ApplicationResult](docs/ApplicationResult.md)
 - [Model.ApplicationResultAllOf](docs/ApplicationResultAllOf.md)
 - [Model.AvailableNumber](docs/AvailableNumber.md)
 - [Model.AvailableNumberList](docs/AvailableNumberList.md)
 - [Model.AvailableNumberListAllOf](docs/AvailableNumberListAllOf.md)
 - [Model.BuyIncomingNumberRequest](docs/BuyIncomingNumberRequest.md)
 - [Model.CallList](docs/CallList.md)
 - [Model.CallListAllOf](docs/CallListAllOf.md)
 - [Model.CallResult](docs/CallResult.md)
 - [Model.CallResultAllOf](docs/CallResultAllOf.md)
 - [Model.Capabilities](docs/Capabilities.md)
 - [Model.ConferenceList](docs/ConferenceList.md)
 - [Model.ConferenceListAllOf](docs/ConferenceListAllOf.md)
 - [Model.ConferenceParticipantList](docs/ConferenceParticipantList.md)
 - [Model.ConferenceParticipantListAllOf](docs/ConferenceParticipantListAllOf.md)
 - [Model.ConferenceParticipantResult](docs/ConferenceParticipantResult.md)
 - [Model.ConferenceParticipantResultAllOf](docs/ConferenceParticipantResultAllOf.md)
 - [Model.ConferenceResult](docs/ConferenceResult.md)
 - [Model.ConferenceResultAllOf](docs/ConferenceResultAllOf.md)
 - [Model.CreateConference](docs/CreateConference.md)
 - [Model.CreateConferenceAllOf](docs/CreateConferenceAllOf.md)
 - [Model.CreateConferenceRequest](docs/CreateConferenceRequest.md)
 - [Model.Dequeue](docs/Dequeue.md)
 - [Model.Enqueue](docs/Enqueue.md)
 - [Model.EnqueueAllOf](docs/EnqueueAllOf.md)
 - [Model.FilterLogsRequest](docs/FilterLogsRequest.md)
 - [Model.GetDigits](docs/GetDigits.md)
 - [Model.GetDigitsAllOf](docs/GetDigitsAllOf.md)
 - [Model.GetSpeech](docs/GetSpeech.md)
 - [Model.GetSpeechAllOf](docs/GetSpeechAllOf.md)
 - [Model.Hangup](docs/Hangup.md)
 - [Model.HangupAllOf](docs/HangupAllOf.md)
 - [Model.IncomingNumberList](docs/IncomingNumberList.md)
 - [Model.IncomingNumberListAllOf](docs/IncomingNumberListAllOf.md)
 - [Model.IncomingNumberRequest](docs/IncomingNumberRequest.md)
 - [Model.IncomingNumberResult](docs/IncomingNumberResult.md)
 - [Model.IncomingNumberResultAllOf](docs/IncomingNumberResultAllOf.md)
 - [Model.LogList](docs/LogList.md)
 - [Model.LogListAllOf](docs/LogListAllOf.md)
 - [Model.LogResult](docs/LogResult.md)
 - [Model.MakeCallRequest](docs/MakeCallRequest.md)
 - [Model.MessageRequest](docs/MessageRequest.md)
 - [Model.MessageRequestAllOf](docs/MessageRequestAllOf.md)
 - [Model.MessageResult](docs/MessageResult.md)
 - [Model.MessageResultAllOf](docs/MessageResultAllOf.md)
 - [Model.MessagesList](docs/MessagesList.md)
 - [Model.MessagesListAllOf](docs/MessagesListAllOf.md)
 - [Model.MutableResourceModel](docs/MutableResourceModel.md)
 - [Model.OutDial](docs/OutDial.md)
 - [Model.OutDialAllOf](docs/OutDialAllOf.md)
 - [Model.PaginationModel](docs/PaginationModel.md)
 - [Model.Park](docs/Park.md)
 - [Model.ParkAllOf](docs/ParkAllOf.md)
 - [Model.Pause](docs/Pause.md)
 - [Model.PauseAllOf](docs/PauseAllOf.md)
 - [Model.PerclCommand](docs/PerclCommand.md)
 - [Model.PerclScript](docs/PerclScript.md)
 - [Model.Play](docs/Play.md)
 - [Model.PlayAllOf](docs/PlayAllOf.md)
 - [Model.PlayEarlyMedia](docs/PlayEarlyMedia.md)
 - [Model.PlayEarlyMediaAllOf](docs/PlayEarlyMediaAllOf.md)
 - [Model.QueueList](docs/QueueList.md)
 - [Model.QueueListAllOf](docs/QueueListAllOf.md)
 - [Model.QueueMember](docs/QueueMember.md)
 - [Model.QueueMemberList](docs/QueueMemberList.md)
 - [Model.QueueMemberListAllOf](docs/QueueMemberListAllOf.md)
 - [Model.QueueRequest](docs/QueueRequest.md)
 - [Model.QueueResult](docs/QueueResult.md)
 - [Model.QueueResultAllOf](docs/QueueResultAllOf.md)
 - [Model.RecordUtterance](docs/RecordUtterance.md)
 - [Model.RecordUtteranceAllOf](docs/RecordUtteranceAllOf.md)
 - [Model.RecordingList](docs/RecordingList.md)
 - [Model.RecordingListAllOf](docs/RecordingListAllOf.md)
 - [Model.RecordingResult](docs/RecordingResult.md)
 - [Model.RecordingResultAllOf](docs/RecordingResultAllOf.md)
 - [Model.Redirect](docs/Redirect.md)
 - [Model.RedirectAllOf](docs/RedirectAllOf.md)
 - [Model.Reject](docs/Reject.md)
 - [Model.RejectAllOf](docs/RejectAllOf.md)
 - [Model.RemoveFromConference](docs/RemoveFromConference.md)
 - [Model.RemoveFromConferenceAllOf](docs/RemoveFromConferenceAllOf.md)
 - [Model.Say](docs/Say.md)
 - [Model.SayAllOf](docs/SayAllOf.md)
 - [Model.SendDigits](docs/SendDigits.md)
 - [Model.SendDigitsAllOf](docs/SendDigitsAllOf.md)
 - [Model.SetListen](docs/SetListen.md)
 - [Model.SetListenAllOf](docs/SetListenAllOf.md)
 - [Model.SetTalk](docs/SetTalk.md)
 - [Model.SetTalkAllOf](docs/SetTalkAllOf.md)
 - [Model.Sms](docs/Sms.md)
 - [Model.SmsAllOf](docs/SmsAllOf.md)
 - [Model.StartRecordCall](docs/StartRecordCall.md)
 - [Model.TerminateConference](docs/TerminateConference.md)
 - [Model.TerminateConferenceAllOf](docs/TerminateConferenceAllOf.md)
 - [Model.Unpark](docs/Unpark.md)
 - [Model.UpdateCallRequest](docs/UpdateCallRequest.md)
 - [Model.UpdateConferenceParticipantRequest](docs/UpdateConferenceParticipantRequest.md)
 - [Model.UpdateConferenceRequest](docs/UpdateConferenceRequest.md)


<a name="documentation-for-enums"></a>
## Documentation for Enums

 - [Enums.AccountStatus](docs/AccountStatus.md)
 - [Enums.AccountType](docs/AccountType.md)
 - [Enums.AnsweredBy](docs/AnsweredBy.md)
 - [Enums.CallDirection](docs/CallDirection.md)
 - [Enums.CallStatus](docs/CallStatus.md)
 - [Enums.ConferenceStatus](docs/ConferenceStatus.md)
 - [Enums.GetSpeechReason](docs/GetSpeechReason.md)
 - [Enums.GrammarFileBuiltIn](docs/GrammarFileBuiltIn.md)
 - [Enums.GrammarType](docs/GrammarType.md)
 - [Enums.IfMachine](docs/IfMachine.md)
 - [Enums.Language](docs/Language.md)
 - [Enums.LogLevel](docs/LogLevel.md)
 - [Enums.MachineType](docs/MachineType.md)
 - [Enums.MessageDirection](docs/MessageDirection.md)
 - [Enums.MessageStatus](docs/MessageStatus.md)
 - [Enums.PlayBeep](docs/PlayBeep.md)
 - [Enums.QueueResultStatus](docs/QueueResultStatus.md)
 - [Enums.RecordUtteranceTermReason](docs/RecordUtteranceTermReason.md)
 - [Enums.RequestType](docs/RequestType.md)
 - [Enums.UpdateCallRequestStatus](docs/UpdateCallRequestStatus.md)
 - [Enums.UpdateConferenceRequestStatus](docs/UpdateConferenceRequestStatus.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="fc"></a>
### fc

- **Type**: HTTP basic authentication


<a name="documentation-for-serialization-deserialization"></a>
## Documentation for Serialization/Deserialization for Enums

###These methods are not required unless being used for debugging/logging purposes

- To serialize (turn value into enum), we would need to use the reflection method GetEnumByValue where you pass the enum as a type and value into the method to get the associated enum.
  
  GetMemberValue
  
  This is an extension method, so you can turn an enum directly into a value

  Get a value from an enum

  ```csharp
    using System.Collections.Generic;
    using System.Diagnostics;
    using System;
    using System.Linq;
    using System.IO;
    using freeclimb.Api;
    using freeclimb.Client;
    using freeclimb.Model;
    using System.Reflection;
    using Newtonsoft.Json;

    using freeclimb.Enums;

    namespace Example
    {
    public class GetMemberValueExample
    {
        public static void Main()
        {
            AccountStatus status = AccountStatus.ACTIVE;
            string expectedValue = StringValueAccountStatusTestValue();
            string calculatedValue = status.GetMemberValue();
            Assert.Equal(expectedValue, calculatedValue);
        }
        private string StringValueAccountStatusTestValue()
        {
            return "active";
        }
    }

    }
    ```
    
- To deserialize a value (turn enum into value), we would need to use the extension method GetMemberValue where you pass the enum as a parameter into the method to get the associated value.

  GetEnumByValue
  
  Reflection.GetEnumByValue<EnumType>(expectedValue)

  Get an Enum value from string

  ```csharp
    using System.Collections.Generic;
    using System.Diagnostics;
    using System;
    using System.Linq;
    using System.IO;
    using freeclimb.Api;
    using freeclimb.Client;
    using freeclimb.Model;
    using System.Reflection;
    using Newtonsoft.Json;

    using freeclimb.Enums;

    namespace Example
    {
    public class GetEnumByValueExample
    {
        public static void Main()
        {
            string stringToConvertToEnum = "active";
            AccountStatus calculatedEnumValue = Reflection.GetEnumByValue<AccountStatus>(expectedValue);
            AccountStatus expectedValue = AccountStatus.ACTIVE;
            Assert.Equal(expectedValue, calculatedEnumValue);
        }
    }

    }
    ```