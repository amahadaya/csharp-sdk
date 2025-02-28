# freeclimb.Api.DefaultApi

All URIs are relative to *https://www.freeclimb.com/apiserver*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BuyAPhoneNumber**](DefaultApi.md#buyaphonenumber) | **POST** /Accounts/{accountId}/IncomingPhoneNumbers | Buy a Phone Number
[**CreateAConference**](DefaultApi.md#createaconference) | **POST** /Accounts/{accountId}/Conferences | Create a Conference
[**CreateAQueue**](DefaultApi.md#createaqueue) | **POST** /Accounts/{accountId}/Queues | Create a Queue
[**CreateAnApplication**](DefaultApi.md#createanapplication) | **POST** /Accounts/{accountId}/Applications | Create an application
[**DeleteARecording**](DefaultApi.md#deletearecording) | **DELETE** /Accounts/{accountId}/Recordings/{recordingId} | Delete a Recording
[**DeleteAnApplication**](DefaultApi.md#deleteanapplication) | **DELETE** /Accounts/{accountId}/Applications/{applicationId} | Delete an application
[**DeleteAnIncomingNumber**](DefaultApi.md#deleteanincomingnumber) | **DELETE** /Accounts/{accountId}/IncomingPhoneNumbers/{phoneNumberId} | Delete an Incoming Number
[**DequeueAMember**](DefaultApi.md#dequeueamember) | **POST** /Accounts/{accountId}/Queues/{queueId}/Members/{callId} | Dequeue a Member
[**DequeueHeadMember**](DefaultApi.md#dequeueheadmember) | **POST** /Accounts/{accountId}/Queues/{queueId}/Members/Front | Dequeue Head Member
[**DownloadARecordingFile**](DefaultApi.md#downloadarecordingfile) | **GET** /Accounts/{accountId}/Recordings/{recordingId}/Download | Download a Recording File
[**FilterLogs**](DefaultApi.md#filterlogs) | **POST** /Accounts/{accountId}/Logs | Filter Logs
[**GetACall**](DefaultApi.md#getacall) | **GET** /Accounts/{accountId}/Calls/{callId} | Get a Call
[**GetAConference**](DefaultApi.md#getaconference) | **GET** /Accounts/{accountId}/Conferences/{conferenceId} | Get a Conference
[**GetAMember**](DefaultApi.md#getamember) | **GET** /Accounts/{accountId}/Queues/{queueId}/Members/{callId} | Get a Member
[**GetAParticipant**](DefaultApi.md#getaparticipant) | **GET** /Accounts/{accountId}/Conferences/{conferenceId}/Participants/{callId} | Get a Participant
[**GetAQueue**](DefaultApi.md#getaqueue) | **GET** /Accounts/{accountId}/Queues/{queueId} | Get a Queue
[**GetARecording**](DefaultApi.md#getarecording) | **GET** /Accounts/{accountId}/Recordings/{recordingId} | Get a Recording
[**GetAnAccount**](DefaultApi.md#getanaccount) | **GET** /Accounts/{accountId} | Get an Account
[**GetAnApplication**](DefaultApi.md#getanapplication) | **GET** /Accounts/{accountId}/Applications/{applicationId} | Get an Application
[**GetAnIncomingNumber**](DefaultApi.md#getanincomingnumber) | **GET** /Accounts/{accountId}/IncomingPhoneNumbers/{phoneNumberId} | Get an Incoming Number
[**GetAnSmsMessage**](DefaultApi.md#getansmsmessage) | **GET** /Accounts/{accountId}/Messages/{messageId} | Get an SMS Message
[**GetHeadMember**](DefaultApi.md#getheadmember) | **GET** /Accounts/{accountId}/Queues/{queueId}/Members/Front | Get Head Member
[**ListActiveQueues**](DefaultApi.md#listactivequeues) | **GET** /Accounts/{accountId}/Queues | List Active Queues
[**ListAllAccountLogs**](DefaultApi.md#listallaccountlogs) | **GET** /Accounts/{accountId}/Logs | List All Account Logs
[**ListApplications**](DefaultApi.md#listapplications) | **GET** /Accounts/{accountId}/Applications | List applications
[**ListAvailableNumbers**](DefaultApi.md#listavailablenumbers) | **GET** /AvailablePhoneNumbers | List available numbers
[**ListCallLogs**](DefaultApi.md#listcalllogs) | **GET** /Accounts/{accountId}/Calls/{callId}/Logs | List Call Logs
[**ListCallRecordings**](DefaultApi.md#listcallrecordings) | **GET** /Accounts/{accountId}/Calls/{callId}/Recordings | List Call Recordings
[**ListCalls**](DefaultApi.md#listcalls) | **GET** /Accounts/{accountId}/Calls | List Calls
[**ListConferences**](DefaultApi.md#listconferences) | **GET** /Accounts/{accountId}/Conferences | List Conferences
[**ListIncomingNumbers**](DefaultApi.md#listincomingnumbers) | **GET** /Accounts/{accountId}/IncomingPhoneNumbers | List Incoming Numbers
[**ListMembers**](DefaultApi.md#listmembers) | **GET** /Accounts/{accountId}/Queues/{queueId}/Members | List Members
[**ListParticipants**](DefaultApi.md#listparticipants) | **GET** /Accounts/{accountId}/Conferences/{conferenceId}/Participants | List Participants
[**ListRecordings**](DefaultApi.md#listrecordings) | **GET** /Accounts/{accountId}/Recordings | List Recordings
[**ListSmsMessages**](DefaultApi.md#listsmsmessages) | **GET** /Accounts/{accountId}/Messages | List SMS Messages
[**MakeACall**](DefaultApi.md#makeacall) | **POST** /Accounts/{accountId}/Calls | Make a Call
[**RemoveAParticipant**](DefaultApi.md#removeaparticipant) | **DELETE** /Accounts/{accountId}/Conferences/{conferenceId}/Participants/{callId} | Remove a Participant
[**SendAnSmsMessage**](DefaultApi.md#sendansmsmessage) | **POST** /Accounts/{accountId}/Messages | Send an SMS Message
[**StreamARecordingFile**](DefaultApi.md#streamarecordingfile) | **GET** /Accounts/{accountId}/Recordings/{recordingId}/Stream | Stream a Recording File
[**UpdateAConference**](DefaultApi.md#updateaconference) | **POST** /Accounts/{accountId}/Conferences/{conferenceId} | Update a Conference
[**UpdateALiveCall**](DefaultApi.md#updatealivecall) | **POST** /Accounts/{accountId}/Calls/{callId} | Update a Live Call
[**UpdateAParticipant**](DefaultApi.md#updateaparticipant) | **POST** /Accounts/{accountId}/Conferences/{conferenceId}/Participants/{callId} | Update a Participant
[**UpdateAQueue**](DefaultApi.md#updateaqueue) | **POST** /Accounts/{accountId}/Queues/{queueId} | Update a Queue
[**UpdateAnAccount**](DefaultApi.md#updateanaccount) | **POST** /Accounts/{accountId} | Manage an account
[**UpdateAnApplication**](DefaultApi.md#updateanapplication) | **POST** /Accounts/{accountId}/Applications/{applicationId} | Update an application
[**UpdateAnIncomingNumber**](DefaultApi.md#updateanincomingnumber) | **POST** /Accounts/{accountId}/IncomingPhoneNumbers/{phoneNumberId} | Update an Incoming Number


<a name="buyaphonenumber"></a>
# **BuyAPhoneNumber**
> IncomingNumberResult BuyAPhoneNumber (BuyIncomingNumberRequest buyIncomingNumberRequest)

Buy a Phone Number

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class BuyAPhoneNumberExample
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
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.BuyAPhoneNumber: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **buyIncomingNumberRequest** | [**BuyIncomingNumberRequest**](BuyIncomingNumberRequest.md)| Incoming Number transaction details | 


### Return type

[**IncomingNumberResult**](IncomingNumberResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Incoming Number transaction |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createaconference"></a>
# **CreateAConference**
> ConferenceResult CreateAConference (CreateConferenceRequest createConferenceRequest = null)

Create a Conference

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class CreateAConferenceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            

            var createConferenceRequest = new CreateConferenceRequest(); // CreateConferenceRequest | Conference to create (optional) 

            try
            {
                // Create a Conference
                ConferenceResult result = apiInstance.CreateAConference(createConferenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateAConference: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createConferenceRequest** | [**CreateConferenceRequest**](CreateConferenceRequest.md)| Conference to create | [optional] 


### Return type

[**ConferenceResult**](ConferenceResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Details of created conference |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createaqueue"></a>
# **CreateAQueue**
> QueueResult CreateAQueue (QueueRequest queueRequest = null)

Create a Queue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class CreateAQueueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            

            var queueRequest = new QueueRequest(); // QueueRequest | Queue details used to create a queue (optional) 

            try
            {
                // Create a Queue
                QueueResult result = apiInstance.CreateAQueue(queueRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateAQueue: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueRequest** | [**QueueRequest**](QueueRequest.md)| Queue details used to create a queue | [optional] 


### Return type

[**QueueResult**](QueueResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfuly created queue |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createanapplication"></a>
# **CreateAnApplication**
> ApplicationResult CreateAnApplication (ApplicationRequest applicationRequest = null)

Create an application

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class CreateAnApplicationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            

            var applicationRequest = new ApplicationRequest(); // ApplicationRequest | Application Details (optional) 

            try
            {
                // Create an application
                ApplicationResult result = apiInstance.CreateAnApplication(applicationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateAnApplication: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationRequest** | [**ApplicationRequest**](ApplicationRequest.md)| Application Details | [optional] 


### Return type

[**ApplicationResult**](ApplicationResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Application successfuly created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletearecording"></a>
# **DeleteARecording**
> void DeleteARecording (string recordingId)

Delete a Recording

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class DeleteARecordingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var recordingId = "recordingId_example";  // string | String that uniquely identifies this recording resource.


            try
            {
                // Delete a Recording
                apiInstance.DeleteARecording(recordingId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteARecording: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recordingId** | **string**| String that uniquely identifies this recording resource. | 


### Return type

void (empty response body)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Recording Deleted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteanapplication"></a>
# **DeleteAnApplication**
> void DeleteAnApplication (string applicationId)

Delete an application

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class DeleteAnApplicationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var applicationId = "applicationId_example";  // string | String that uniquely identifies this application resource.


            try
            {
                // Delete an application
                apiInstance.DeleteAnApplication(applicationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteAnApplication: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**| String that uniquely identifies this application resource. | 


### Return type

void (empty response body)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Successful application deletion |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteanincomingnumber"></a>
# **DeleteAnIncomingNumber**
> void DeleteAnIncomingNumber (string phoneNumberId)

Delete an Incoming Number

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class DeleteAnIncomingNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var phoneNumberId = "phoneNumberId_example";  // string | String that uniquely identifies this phone number resource.


            try
            {
                // Delete an Incoming Number
                apiInstance.DeleteAnIncomingNumber(phoneNumberId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteAnIncomingNumber: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **phoneNumberId** | **string**| String that uniquely identifies this phone number resource. | 


### Return type

void (empty response body)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Successful Incoming Number deletion. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dequeueamember"></a>
# **DequeueAMember**
> QueueMember DequeueAMember (string queueId, string callId)

Dequeue a Member

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class DequeueAMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var queueId = "queueId_example";  // string | String that uniquely identifies the Queue that the Member belongs to.

            var callId = "callId_example";  // string | ID if the Call that the Member belongs to


            try
            {
                // Dequeue a Member
                QueueMember result = apiInstance.DequeueAMember(queueId, callId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DequeueAMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueId** | **string**| String that uniquely identifies the Queue that the Member belongs to. | 
 **callId** | **string**| ID if the Call that the Member belongs to | 


### Return type

[**QueueMember**](QueueMember.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted dequeue request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dequeueheadmember"></a>
# **DequeueHeadMember**
> QueueMember DequeueHeadMember (string queueId)

Dequeue Head Member

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class DequeueHeadMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var queueId = "queueId_example";  // string | String that uniquely identifies this queue resource.


            try
            {
                // Dequeue Head Member
                QueueMember result = apiInstance.DequeueHeadMember(queueId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DequeueHeadMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueId** | **string**| String that uniquely identifies this queue resource. | 


### Return type

[**QueueMember**](QueueMember.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted dequeue request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadarecordingfile"></a>
# **DownloadARecordingFile**
> System.IO.Stream DownloadARecordingFile (string recordingId)

Download a Recording File

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class DownloadARecordingFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var recordingId = "recordingId_example";  // string | String that uniquely identifies this recording resource.


            try
            {
                // Download a Recording File
                System.IO.Stream result = apiInstance.DownloadARecordingFile(recordingId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DownloadARecordingFile: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recordingId** | **string**| String that uniquely identifies this recording resource. | 


### Return type

**System.IO.Stream**

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: audio/x-wav


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Download a Recording file represented with audio/x-wav mime-type |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filterlogs"></a>
# **FilterLogs**
> LogList FilterLogs (FilterLogsRequest filterLogsRequest)

Filter Logs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class FilterLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            

            var filterLogsRequest = new FilterLogsRequest(); // FilterLogsRequest | Filter logs request paramters

            try
            {
                // Filter Logs
                LogList result = apiInstance.FilterLogs(filterLogsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.FilterLogs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterLogsRequest** | [**FilterLogsRequest**](FilterLogsRequest.md)| Filter logs request paramters | 


### Return type

[**LogList**](LogList.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved log list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getacall"></a>
# **GetACall**
> CallResult GetACall (string callId)

Get a Call

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetACallExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var callId = "callId_example";  // string | String that uniquely identifies this call resource.


            try
            {
                // Get a Call
                CallResult result = apiInstance.GetACall(callId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetACall: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **callId** | **string**| String that uniquely identifies this call resource. | 


### Return type

[**CallResult**](CallResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Call Resource |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaconference"></a>
# **GetAConference**
> ConferenceResult GetAConference (string conferenceId)

Get a Conference

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetAConferenceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var conferenceId = "conferenceId_example";  // string | A string that uniquely identifies this conference resource.


            try
            {
                // Get a Conference
                ConferenceResult result = apiInstance.GetAConference(conferenceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAConference: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conferenceId** | **string**| A string that uniquely identifies this conference resource. | 


### Return type

[**ConferenceResult**](ConferenceResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved conference |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getamember"></a>
# **GetAMember**
> QueueMember GetAMember (string queueId, string callId)

Get a Member

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetAMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var queueId = "queueId_example";  // string | String that uniquely identifies the Queue that the Member belongs to.

            var callId = "callId_example";  // string | ID of the Call that the Member belongs to


            try
            {
                // Get a Member
                QueueMember result = apiInstance.GetAMember(queueId, callId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueId** | **string**| String that uniquely identifies the Queue that the Member belongs to. | 
 **callId** | **string**| ID of the Call that the Member belongs to | 


### Return type

[**QueueMember**](QueueMember.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved a queue member |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaparticipant"></a>
# **GetAParticipant**
> ConferenceParticipantResult GetAParticipant (string conferenceId, string callId)

Get a Participant

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetAParticipantExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var conferenceId = "conferenceId_example";  // string | ID of the conference this participant is in.

            var callId = "callId_example";  // string | ID of the Call associated with this participant.


            try
            {
                // Get a Participant
                ConferenceParticipantResult result = apiInstance.GetAParticipant(conferenceId, callId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAParticipant: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conferenceId** | **string**| ID of the conference this participant is in. | 
 **callId** | **string**| ID of the Call associated with this participant. | 


### Return type

[**ConferenceParticipantResult**](ConferenceParticipantResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved conference participant |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaqueue"></a>
# **GetAQueue**
> QueueResult GetAQueue (string queueId)

Get a Queue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetAQueueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var queueId = "queueId_example";  // string | A string that uniquely identifies this queue resource.


            try
            {
                // Get a Queue
                QueueResult result = apiInstance.GetAQueue(queueId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAQueue: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueId** | **string**| A string that uniquely identifies this queue resource. | 


### Return type

[**QueueResult**](QueueResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved queue |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getarecording"></a>
# **GetARecording**
> RecordingResult GetARecording (string recordingId)

Get a Recording

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetARecordingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var recordingId = "recordingId_example";  // string | String that uniquely identifies this recording resource.


            try
            {
                // Get a Recording
                RecordingResult result = apiInstance.GetARecording(recordingId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetARecording: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recordingId** | **string**| String that uniquely identifies this recording resource. | 


### Return type

[**RecordingResult**](RecordingResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getanaccount"></a>
# **GetAnAccount**
> AccountResult GetAnAccount ()

Get an Account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetAnAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            

            try
            {
                // Get an Account
                AccountResult result = apiInstance.GetAnAccount();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAnAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters



### Return type

[**AccountResult**](AccountResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Account Details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getanapplication"></a>
# **GetAnApplication**
> ApplicationResult GetAnApplication (string applicationId)

Get an Application

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetAnApplicationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var applicationId = "applicationId_example";  // string | A string that uniquely identifies this application resource.


            try
            {
                // Get an Application
                ApplicationResult result = apiInstance.GetAnApplication(applicationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAnApplication: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**| A string that uniquely identifies this application resource. | 


### Return type

[**ApplicationResult**](ApplicationResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Application Details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getanincomingnumber"></a>
# **GetAnIncomingNumber**
> IncomingNumberResult GetAnIncomingNumber (string phoneNumberId)

Get an Incoming Number

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetAnIncomingNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var phoneNumberId = "phoneNumberId_example";  // string | String that uniquely identifies this phone number resource.


            try
            {
                // Get an Incoming Number
                IncomingNumberResult result = apiInstance.GetAnIncomingNumber(phoneNumberId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAnIncomingNumber: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **phoneNumberId** | **string**| String that uniquely identifies this phone number resource. | 


### Return type

[**IncomingNumberResult**](IncomingNumberResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Incoming Phone Number result. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getansmsmessage"></a>
# **GetAnSmsMessage**
> MessageResult GetAnSmsMessage (string messageId)

Get an SMS Message

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetAnSmsMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var messageId = "messageId_example";  // string | String that uniquely identifies this Message resource.


            try
            {
                // Get an SMS Message
                MessageResult result = apiInstance.GetAnSmsMessage(messageId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAnSmsMessage: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageId** | **string**| String that uniquely identifies this Message resource. | 


### Return type

[**MessageResult**](MessageResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The specific SMS message that’s been processed by FreeClimb |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getheadmember"></a>
# **GetHeadMember**
> QueueMember GetHeadMember (string queueId)

Get Head Member

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetHeadMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var queueId = "queueId_example";  // string | String that uniquely identifies the Queue that the Member belongs to.


            try
            {
                // Get Head Member
                QueueMember result = apiInstance.GetHeadMember(queueId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetHeadMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueId** | **string**| String that uniquely identifies the Queue that the Member belongs to. | 


### Return type

[**QueueMember**](QueueMember.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved queue member |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listactivequeues"></a>
# **ListActiveQueues**
> QueueList ListActiveQueues (string alias = null)

List Active Queues

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class ListActiveQueuesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var alias = "alias_example";  // string | Return only the Queue resources with aliases that exactly match this name. (optional) 


            try
            {
                // List Active Queues
                QueueList result = apiInstance.ListActiveQueues(alias);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListActiveQueues: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **alias** | **string**| Return only the Queue resources with aliases that exactly match this name. | [optional] 


### Return type

[**QueueList**](QueueList.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfuly retrieved queue list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listallaccountlogs"></a>
# **ListAllAccountLogs**
> LogList ListAllAccountLogs ()

List All Account Logs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class ListAllAccountLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            

            try
            {
                // List All Account Logs
                LogList result = apiInstance.ListAllAccountLogs();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListAllAccountLogs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters



### Return type

[**LogList**](LogList.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved log list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listapplications"></a>
# **ListApplications**
> ApplicationList ListApplications (string alias = null)

List applications

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class ListApplicationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var alias = "alias_example";  // string | Return only applications with aliases that exactly match this value. (optional) 


            try
            {
                // List applications
                ApplicationList result = apiInstance.ListApplications(alias);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListApplications: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **alias** | **string**| Return only applications with aliases that exactly match this value. | [optional] 


### Return type

[**ApplicationList**](ApplicationList.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of Applications |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listavailablenumbers"></a>
# **ListAvailableNumbers**
> AvailableNumberList ListAvailableNumbers (string phoneNumber = null, string region = null, string country = null, bool? voiceEnabled = null, bool? smsEnabled = null, bool? capabilitiesVoice = null, bool? capabilitiesSms = null, bool? capabilitiesTollFree = null, bool? capabilitiesTenDLC = null, bool? capabilitiesShortCode = null)

List available numbers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class ListAvailableNumbersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var phoneNumber = "phoneNumber_example";  // string | PCRE-compatible regular expression to filter against `phoneNumber` field, which is in E.164 format. (optional) 

            var region = "region_example";  // string | State or province of this phone number. (optional) 

            var country = "country_example";  // string | Country of this phone number. (optional) 

            var voiceEnabled = true;  // bool? | Indicates whether the phone number can handle Calls. Typically set to true for all numbers. (optional)  (default to true)

            var smsEnabled = true;  // bool? | Indication of whether the phone number can handle sending and receiving SMS messages. Typically set to true for all numbers. (optional)  (default to true)

            var capabilitiesVoice = true;  // bool? |  (optional) 

            var capabilitiesSms = true;  // bool? |  (optional) 

            var capabilitiesTollFree = true;  // bool? |  (optional) 

            var capabilitiesTenDLC = true;  // bool? |  (optional) 

            var capabilitiesShortCode = true;  // bool? |  (optional) 


            try
            {
                // List available numbers
                AvailableNumberList result = apiInstance.ListAvailableNumbers(phoneNumber, region, country, voiceEnabled, smsEnabled, capabilitiesVoice, capabilitiesSms, capabilitiesTollFree, capabilitiesTenDLC, capabilitiesShortCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListAvailableNumbers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **phoneNumber** | **string**| PCRE-compatible regular expression to filter against &#x60;phoneNumber&#x60; field, which is in E.164 format. | [optional] 
 **region** | **string**| State or province of this phone number. | [optional] 
 **country** | **string**| Country of this phone number. | [optional] 
 **voiceEnabled** | **bool?**| Indicates whether the phone number can handle Calls. Typically set to true for all numbers. | [optional] [default to true]
 **smsEnabled** | **bool?**| Indication of whether the phone number can handle sending and receiving SMS messages. Typically set to true for all numbers. | [optional] [default to true]
 **capabilitiesVoice** | **bool?**|  | [optional] 
 **capabilitiesSms** | **bool?**|  | [optional] 
 **capabilitiesTollFree** | **bool?**|  | [optional] 
 **capabilitiesTenDLC** | **bool?**|  | [optional] 
 **capabilitiesShortCode** | **bool?**|  | [optional] 


### Return type

[**AvailableNumberList**](AvailableNumberList.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Available Numbers List |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcalllogs"></a>
# **ListCallLogs**
> LogList ListCallLogs (string callId)

List Call Logs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class ListCallLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var callId = "callId_example";  // string | String that uniquely identifies this call resource.


            try
            {
                // List Call Logs
                LogList result = apiInstance.ListCallLogs(callId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListCallLogs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **callId** | **string**| String that uniquely identifies this call resource. | 


### Return type

[**LogList**](LogList.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Logs for this call |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcallrecordings"></a>
# **ListCallRecordings**
> RecordingList ListCallRecordings (string callId, string dateCreated = null)

List Call Recordings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class ListCallRecordingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var callId = "callId_example";  // string | String that uniquely identifies this call resource.

            var dateCreated = "dateCreated_example";  // string | Only show recordings created on the specified date, in the form *YYYY-MM-DD*. (optional) 


            try
            {
                // List Call Recordings
                RecordingList result = apiInstance.ListCallRecordings(callId, dateCreated);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListCallRecordings: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **callId** | **string**| String that uniquely identifies this call resource. | 
 **dateCreated** | **string**| Only show recordings created on the specified date, in the form *YYYY-MM-DD*. | [optional] 


### Return type

[**RecordingList**](RecordingList.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of recordings for a call |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcalls"></a>
# **ListCalls**
> CallList ListCalls (bool? active = null, string to = null, string from = null, CallStatus? status = null, string startTime = null, string endTime = null, string parentCallId = null)

List Calls

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class ListCallsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var active = false;  // bool? | If active is set to true then all calls of the nature queued, ringing, inProgress are returned in the query. (optional)  (default to false)

            var to = "to_example";  // string | Only show Calls to this phone number. (optional) 

            var from = "from_example";  // string | Only show Calls from this phone number. (optional) 

            var status = (CallStatus) "queued";  // CallStatus? | Only show Calls currently in this status. May be `queued`, `ringing`, `inProgress`, `canceled`, `completed`, `failed`, `busy`, or `noAnswer`. (optional) 

            var startTime = "startTime_example";  // string | Only show Calls that started at or after this time, given as YYYY-MM-DD hh:mm:ss. (optional) 

            var endTime = "endTime_example";  // string | Only show Calls that ended at or before this time, given as YYYY-MM- DD hh:mm:ss. (optional) 

            var parentCallId = "parentCallId_example";  // string | Only show Calls spawned by the call with this ID. (optional) 


            try
            {
                // List Calls
                CallList result = apiInstance.ListCalls(active, to, from, status, startTime, endTime, parentCallId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListCalls: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **active** | **bool?**| If active is set to true then all calls of the nature queued, ringing, inProgress are returned in the query. | [optional] [default to false]
 **to** | **string**| Only show Calls to this phone number. | [optional] 
 **from** | **string**| Only show Calls from this phone number. | [optional] 
 **status** | **CallStatus?**| Only show Calls currently in this status. May be &#x60;queued&#x60;, &#x60;ringing&#x60;, &#x60;inProgress&#x60;, &#x60;canceled&#x60;, &#x60;completed&#x60;, &#x60;failed&#x60;, &#x60;busy&#x60;, or &#x60;noAnswer&#x60;. | [optional] 
 **startTime** | **string**| Only show Calls that started at or after this time, given as YYYY-MM-DD hh:mm:ss. | [optional] 
 **endTime** | **string**| Only show Calls that ended at or before this time, given as YYYY-MM- DD hh:mm:ss. | [optional] 
 **parentCallId** | **string**| Only show Calls spawned by the call with this ID. | [optional] 


### Return type

[**CallList**](CallList.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful retrieved call list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listconferences"></a>
# **ListConferences**
> ConferenceList ListConferences (string status = null, string alias = null, string dateCreated = null, string dateUpdated = null)

List Conferences

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class ListConferencesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var status = "status_example";  // string | Only show conferences that currently have the specified status. Valid values: `empty`, `populated`, `inProgress`, or `terminated`. (optional) 

            var alias = "alias_example";  // string | List Conferences whose alias exactly matches this string. (optional) 

            var dateCreated = "dateCreated_example";  // string | Only show Conferences that were created on the specified date, in the form *YYYY-MM-DD*. (optional) 

            var dateUpdated = "dateUpdated_example";  // string | Only show Conferences that were last updated on the specified date, in the form *YYYY-MM-DD*. (optional) 


            try
            {
                // List Conferences
                ConferenceList result = apiInstance.ListConferences(status, alias, dateCreated, dateUpdated);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListConferences: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **status** | **string**| Only show conferences that currently have the specified status. Valid values: &#x60;empty&#x60;, &#x60;populated&#x60;, &#x60;inProgress&#x60;, or &#x60;terminated&#x60;. | [optional] 
 **alias** | **string**| List Conferences whose alias exactly matches this string. | [optional] 
 **dateCreated** | **string**| Only show Conferences that were created on the specified date, in the form *YYYY-MM-DD*. | [optional] 
 **dateUpdated** | **string**| Only show Conferences that were last updated on the specified date, in the form *YYYY-MM-DD*. | [optional] 


### Return type

[**ConferenceList**](ConferenceList.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of Conferences |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listincomingnumbers"></a>
# **ListIncomingNumbers**
> IncomingNumberList ListIncomingNumbers (string phoneNumber = null, string alias = null, string region = null, string country = null, string applicationId = null, bool? hasApplication = null, bool? voiceEnabled = null, bool? smsEnabled = null, bool? capabilitiesVoice = null, bool? capabilitiesSms = null, bool? capabilitiesTollFree = null, bool? capabilitiesTenDLC = null, bool? capabilitiesShortCode = null, bool? offnet = null)

List Incoming Numbers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class ListIncomingNumbersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var phoneNumber = "phoneNumber_example";  // string | Only show incoming phone number resources that match this PCRE-compatible regular expression. (optional) 

            var alias = "alias_example";  // string | Only show incoming phone numbers with aliases that exactly match this value. (optional) 

            var region = "region_example";  // string | State or province of this phone number. (optional) 

            var country = "country_example";  // string | Country of this phone number. (optional) 

            var applicationId = "applicationId_example";  // string | ID of the Application that FreeClimb should contact if a Call or SMS arrives for this phone number or a Call from this number is placed. An incoming phone number is not useful until associated with an applicationId. (optional) 

            var hasApplication = false;  // bool? | Indication of whether the phone number has an application linked to it. (optional)  (default to false)

            var voiceEnabled = true;  // bool? | Indicates whether the phone number can handle Calls. Typically set to true for all numbers. (optional)  (default to true)

            var smsEnabled = true;  // bool? | Indication of whether the phone number can handle sending and receiving SMS messages. Typically set to true for all numbers. (optional)  (default to true)

            var capabilitiesVoice = true;  // bool? |  (optional) 

            var capabilitiesSms = true;  // bool? |  (optional) 

            var capabilitiesTollFree = true;  // bool? |  (optional) 

            var capabilitiesTenDLC = true;  // bool? |  (optional) 

            var capabilitiesShortCode = true;  // bool? |  (optional) 

            var offnet = true;  // bool? | Indication of whether the phone number was registered as an offnet number. This field will be rendered only for requests to the IncomingPhone number resource. (optional) 


            try
            {
                // List Incoming Numbers
                IncomingNumberList result = apiInstance.ListIncomingNumbers(phoneNumber, alias, region, country, applicationId, hasApplication, voiceEnabled, smsEnabled, capabilitiesVoice, capabilitiesSms, capabilitiesTollFree, capabilitiesTenDLC, capabilitiesShortCode, offnet);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListIncomingNumbers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **phoneNumber** | **string**| Only show incoming phone number resources that match this PCRE-compatible regular expression. | [optional] 
 **alias** | **string**| Only show incoming phone numbers with aliases that exactly match this value. | [optional] 
 **region** | **string**| State or province of this phone number. | [optional] 
 **country** | **string**| Country of this phone number. | [optional] 
 **applicationId** | **string**| ID of the Application that FreeClimb should contact if a Call or SMS arrives for this phone number or a Call from this number is placed. An incoming phone number is not useful until associated with an applicationId. | [optional] 
 **hasApplication** | **bool?**| Indication of whether the phone number has an application linked to it. | [optional] [default to false]
 **voiceEnabled** | **bool?**| Indicates whether the phone number can handle Calls. Typically set to true for all numbers. | [optional] [default to true]
 **smsEnabled** | **bool?**| Indication of whether the phone number can handle sending and receiving SMS messages. Typically set to true for all numbers. | [optional] [default to true]
 **capabilitiesVoice** | **bool?**|  | [optional] 
 **capabilitiesSms** | **bool?**|  | [optional] 
 **capabilitiesTollFree** | **bool?**|  | [optional] 
 **capabilitiesTenDLC** | **bool?**|  | [optional] 
 **capabilitiesShortCode** | **bool?**|  | [optional] 
 **offnet** | **bool?**| Indication of whether the phone number was registered as an offnet number. This field will be rendered only for requests to the IncomingPhone number resource. | [optional] 


### Return type

[**IncomingNumberList**](IncomingNumberList.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of Incoming Phone Numbers |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listmembers"></a>
# **ListMembers**
> QueueMemberList ListMembers (string queueId)

List Members

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class ListMembersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var queueId = "queueId_example";  // string | String that uniquely identifies the Queue that the Member belongs to.


            try
            {
                // List Members
                QueueMemberList result = apiInstance.ListMembers(queueId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListMembers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueId** | **string**| String that uniquely identifies the Queue that the Member belongs to. | 


### Return type

[**QueueMemberList**](QueueMemberList.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved queue member list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listparticipants"></a>
# **ListParticipants**
> ConferenceParticipantList ListParticipants (string conferenceId, bool? talk = null, bool? listen = null)

List Participants

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class ListParticipantsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var conferenceId = "conferenceId_example";  // string | ID of the conference this participant is in.

            var talk = true;  // bool? | Only show Participants with the talk privilege. (optional) 

            var listen = true;  // bool? | Only show Participants with the listen privilege. (optional) 


            try
            {
                // List Participants
                ConferenceParticipantList result = apiInstance.ListParticipants(conferenceId, talk, listen);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListParticipants: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conferenceId** | **string**| ID of the conference this participant is in. | 
 **talk** | **bool?**| Only show Participants with the talk privilege. | [optional] 
 **listen** | **bool?**| Only show Participants with the listen privilege. | [optional] 


### Return type

[**ConferenceParticipantList**](ConferenceParticipantList.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved conference participant list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listrecordings"></a>
# **ListRecordings**
> RecordingList ListRecordings (string callId = null, string conferenceId = null, string dateCreated = null)

List Recordings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class ListRecordingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var callId = "callId_example";  // string | Show only Recordings made during the Call with this ID. (optional) 

            var conferenceId = "conferenceId_example";  // string | Show only Recordings made during the conference with this ID. (optional) 

            var dateCreated = "dateCreated_example";  // string | Only show Recordings created on this date, formatted as *YYYY-MM-DD*. (optional) 


            try
            {
                // List Recordings
                RecordingList result = apiInstance.ListRecordings(callId, conferenceId, dateCreated);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListRecordings: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **callId** | **string**| Show only Recordings made during the Call with this ID. | [optional] 
 **conferenceId** | **string**| Show only Recordings made during the conference with this ID. | [optional] 
 **dateCreated** | **string**| Only show Recordings created on this date, formatted as *YYYY-MM-DD*. | [optional] 


### Return type

[**RecordingList**](RecordingList.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of Recordings |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsmsmessages"></a>
# **ListSmsMessages**
> MessagesList ListSmsMessages (string to = null, string from = null, string beginTime = null, string endTime = null, MessageDirection? direction = null)

List SMS Messages

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class ListSmsMessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var to = "to_example";  // string | Only show Messages to this phone number. (optional) 

            var from = "from_example";  // string | Only show Messages from this phone number. (optional) 

            var beginTime = "beginTime_example";  // string | Only show Messages sent at or after this time (GMT), given as *YYYY-MM-DD hh:mm:ss*. (optional) 

            var endTime = "endTime_example";  // string | Only show messages sent at or before this time (GMT), given as *YYYY-MM-DD hh:mm*.. (optional) 

            var direction = (MessageDirection) "inbound";  // MessageDirection? | Either `inbound` or `outbound`. Only show Messages that were either *sent from* or *received by* FreeClimb. (optional) 


            try
            {
                // List SMS Messages
                MessagesList result = apiInstance.ListSmsMessages(to, from, beginTime, endTime, direction);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListSmsMessages: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **to** | **string**| Only show Messages to this phone number. | [optional] 
 **from** | **string**| Only show Messages from this phone number. | [optional] 
 **beginTime** | **string**| Only show Messages sent at or after this time (GMT), given as *YYYY-MM-DD hh:mm:ss*. | [optional] 
 **endTime** | **string**| Only show messages sent at or before this time (GMT), given as *YYYY-MM-DD hh:mm*.. | [optional] 
 **direction** | **MessageDirection?**| Either &#x60;inbound&#x60; or &#x60;outbound&#x60;. Only show Messages that were either *sent from* or *received by* FreeClimb. | [optional] 


### Return type

[**MessagesList**](MessagesList.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of messages |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="makeacall"></a>
# **MakeACall**
> CallResult MakeACall (MakeCallRequest makeCallRequest = null)

Make a Call

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class MakeACallExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            

            var makeCallRequest = new MakeCallRequest(); // MakeCallRequest | Call details for making a call (optional) 

            try
            {
                // Make a Call
                CallResult result = apiInstance.MakeACall(makeCallRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.MakeACall: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **makeCallRequest** | [**MakeCallRequest**](MakeCallRequest.md)| Call details for making a call | [optional] 


### Return type

[**CallResult**](CallResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Call that was created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeaparticipant"></a>
# **RemoveAParticipant**
> void RemoveAParticipant (string conferenceId, string callId)

Remove a Participant

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class RemoveAParticipantExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var conferenceId = "conferenceId_example";  // string | ID of the conference this participant is in.

            var callId = "callId_example";  // string | ID of the Call associated with this participant.


            try
            {
                // Remove a Participant
                apiInstance.RemoveAParticipant(conferenceId, callId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.RemoveAParticipant: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conferenceId** | **string**| ID of the conference this participant is in. | 
 **callId** | **string**| ID of the Call associated with this participant. | 


### Return type

void (empty response body)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Successfully deleted conference participant |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendansmsmessage"></a>
# **SendAnSmsMessage**
> MessageResult SendAnSmsMessage (MessageRequest messageRequest)

Send an SMS Message

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class SendAnSmsMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            

            var messageRequest = new MessageRequest(); // MessageRequest | Details to create a message

            try
            {
                // Send an SMS Message
                MessageResult result = apiInstance.SendAnSmsMessage(messageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.SendAnSmsMessage: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageRequest** | [**MessageRequest**](MessageRequest.md)| Details to create a message | 


### Return type

[**MessageResult**](MessageResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | The message has been accepted. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="streamarecordingfile"></a>
# **StreamARecordingFile**
> System.IO.Stream StreamARecordingFile (string recordingId)

Stream a Recording File

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class StreamARecordingFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var recordingId = "recordingId_example";  // string | String that uniquely identifies this recording resource.


            try
            {
                // Stream a Recording File
                System.IO.Stream result = apiInstance.StreamARecordingFile(recordingId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.StreamARecordingFile: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recordingId** | **string**| String that uniquely identifies this recording resource. | 


### Return type

**System.IO.Stream**

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: audio/x-wav


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Streaming a Recording represented with audio/x-wav mime-type |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateaconference"></a>
# **UpdateAConference**
> ConferenceResult UpdateAConference (string conferenceId, UpdateConferenceRequest updateConferenceRequest = null)

Update a Conference

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class UpdateAConferenceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var conferenceId = "conferenceId_example";  // string | String that uniquely identifies this conference resource.


            var updateConferenceRequest = new UpdateConferenceRequest(); // UpdateConferenceRequest | Conference Details to update (optional) 

            try
            {
                // Update a Conference
                ConferenceResult result = apiInstance.UpdateAConference(conferenceId, updateConferenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateAConference: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conferenceId** | **string**| String that uniquely identifies this conference resource. | 
 **updateConferenceRequest** | [**UpdateConferenceRequest**](UpdateConferenceRequest.md)| Conference Details to update | [optional] 


### Return type

[**ConferenceResult**](ConferenceResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Conference Details to Update |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatealivecall"></a>
# **UpdateALiveCall**
> void UpdateALiveCall (string callId, UpdateCallRequest updateCallRequest)

Update a Live Call

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class UpdateALiveCallExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var callId = "callId_example";  // string | String that uniquely identifies this call resource.


            var updateCallRequest = new UpdateCallRequest(); // UpdateCallRequest | Call details to update

            try
            {
                // Update a Live Call
                apiInstance.UpdateALiveCall(callId, updateCallRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateALiveCall: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **callId** | **string**| String that uniquely identifies this call resource. | 
 **updateCallRequest** | [**UpdateCallRequest**](UpdateCallRequest.md)| Call details to update | 


### Return type

void (empty response body)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Successfully queued call |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateaparticipant"></a>
# **UpdateAParticipant**
> ConferenceParticipantResult UpdateAParticipant (string conferenceId, string callId, UpdateConferenceParticipantRequest updateConferenceParticipantRequest = null)

Update a Participant

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class UpdateAParticipantExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var conferenceId = "conferenceId_example";  // string | ID of the conference this participant is in.

            var callId = "callId_example";  // string | ID of the Call associated with this participant.


            var updateConferenceParticipantRequest = new UpdateConferenceParticipantRequest(); // UpdateConferenceParticipantRequest | Conference participant details to update (optional) 

            try
            {
                // Update a Participant
                ConferenceParticipantResult result = apiInstance.UpdateAParticipant(conferenceId, callId, updateConferenceParticipantRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateAParticipant: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conferenceId** | **string**| ID of the conference this participant is in. | 
 **callId** | **string**| ID of the Call associated with this participant. | 
 **updateConferenceParticipantRequest** | [**UpdateConferenceParticipantRequest**](UpdateConferenceParticipantRequest.md)| Conference participant details to update | [optional] 


### Return type

[**ConferenceParticipantResult**](ConferenceParticipantResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved conference participant |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateaqueue"></a>
# **UpdateAQueue**
> QueueResult UpdateAQueue (string queueId, QueueRequest queueRequest = null)

Update a Queue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class UpdateAQueueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var queueId = "queueId_example";  // string | A string that uniquely identifies this Queue resource.


            var queueRequest = new QueueRequest(); // QueueRequest | Queue Details to update (optional) 

            try
            {
                // Update a Queue
                QueueResult result = apiInstance.UpdateAQueue(queueId, queueRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateAQueue: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueId** | **string**| A string that uniquely identifies this Queue resource. | 
 **queueRequest** | [**QueueRequest**](QueueRequest.md)| Queue Details to update | [optional] 


### Return type

[**QueueResult**](QueueResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully updated queue |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateanaccount"></a>
# **UpdateAnAccount**
> void UpdateAnAccount (AccountRequest accountRequest = null)

Manage an account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class UpdateAnAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            

            var accountRequest = new AccountRequest(); // AccountRequest | Account details to update (optional) 

            try
            {
                // Manage an account
                apiInstance.UpdateAnAccount(accountRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateAnAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountRequest** | [**AccountRequest**](AccountRequest.md)| Account details to update | [optional] 


### Return type

void (empty response body)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Successful Account update |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateanapplication"></a>
# **UpdateAnApplication**
> ApplicationResult UpdateAnApplication (string applicationId, ApplicationRequest applicationRequest = null)

Update an application

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class UpdateAnApplicationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var applicationId = "applicationId_example";  // string | A string that uniquely identifies this application resource.


            var applicationRequest = new ApplicationRequest(); // ApplicationRequest | Application details to update. (optional) 

            try
            {
                // Update an application
                ApplicationResult result = apiInstance.UpdateAnApplication(applicationId, applicationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateAnApplication: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**| A string that uniquely identifies this application resource. | 
 **applicationRequest** | [**ApplicationRequest**](ApplicationRequest.md)| Application details to update. | [optional] 


### Return type

[**ApplicationResult**](ApplicationResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Update Application |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateanincomingnumber"></a>
# **UpdateAnIncomingNumber**
> IncomingNumberResult UpdateAnIncomingNumber (string phoneNumberId, IncomingNumberRequest incomingNumberRequest = null)

Update an Incoming Number

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class UpdateAnIncomingNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_ACCOUNT_ID";
            config.Password = "YOUR_API_KEY";

            var apiInstance = new DefaultApi(config);
            
            var phoneNumberId = "phoneNumberId_example";  // string | String that uniquely identifies this phone number resource.


            var incomingNumberRequest = new IncomingNumberRequest(); // IncomingNumberRequest | Incoming Number details to update (optional) 

            try
            {
                // Update an Incoming Number
                IncomingNumberResult result = apiInstance.UpdateAnIncomingNumber(phoneNumberId, incomingNumberRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateAnIncomingNumber: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **phoneNumberId** | **string**| String that uniquely identifies this phone number resource. | 
 **incomingNumberRequest** | [**IncomingNumberRequest**](IncomingNumberRequest.md)| Incoming Number details to update | [optional] 


### Return type

[**IncomingNumberResult**](IncomingNumberResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated Incoming Phone Number |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

