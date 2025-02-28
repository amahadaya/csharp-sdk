# freeclimb.Model.CallResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **string** | The URI for this resource, relative to /apiserver. | [optional] 
**DateCreated** | **string** | The date that this resource was created (GMT) in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT). | [optional] 
**DateUpdated** | **string** | The date that this resource was last updated (GMT) in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT). | [optional] 
**Revision** | **int** | Revision count for the resource. This count is set to 1 on creation and is incremented every time it is updated. | [optional] 
**CallId** | **string** | String that uniquely identifies this Call resource. | [optional] 
**ParentCallId** | **string** | ID of the Call that created this leg (child Call). | [optional] 
**AccountId** | **string** | ID of the account that owns this Call. | [optional] 
**From** | **string** | Phone number that initiated this Call. | [optional] 
**To** | **string** | Phone number that received this Call. | [optional] 
**PhoneNumberId** | **string** | If the Call was inbound, this is the ID of the IncomingPhoneNumber that received the Call (DNIS). If the Call was outbound, this is the ID of the phone number from which the Call was placed (ANI). | [optional] 
**Status** | **CallStatus** |  | [optional] 
**StartTime** | **string** | Start time of the Call (GMT) in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT). Empty if the Call has not yet been dialed. | [optional] 
**ConnectTime** | **string** | Time the Call was answered (GMT) in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT). Empty if the Call has not yet been dialed. | [optional] 
**EndTime** | **string** | End time of the Call (GMT) in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT). Empty if the Call did not complete successfully. | [optional] 
**Duration** | **int?** | Total length of the Call in seconds. Measures time between startTime and endTime. This value is empty for busy, failed, unanswered or ongoing Calls. | [optional] 
**ConnectDuration** | **int?** | Length of time that the Call was connected in seconds. Measures time between connectTime and endTime. This value is empty for busy, failed, unanswered or ongoing Calls. | [optional] 
**Direction** | **CallDirection** |  | [optional] 
**AnsweredBy** | **AnsweredBy** |  | [optional] 
**SubresourceUris** | **Object** | The list of subresources for this Call. These include things like logs and recordings associated with the Call. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

