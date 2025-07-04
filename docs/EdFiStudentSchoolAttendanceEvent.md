# EdFi.OdsApi.Sdk.v71.Models.All.EdFiStudentSchoolAttendanceEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**AttendanceEventCategoryDescriptor** | **string** | A code describing the attendance event, for example:         Present         Unexcused absence         Excused absence         Tardy. | 
**EventDate** | **DateOnly** | Date for this attendance event. | 
**SchoolReference** | [**EdFiSchoolReference**](EdFiSchoolReference.md) |  | 
**SessionReference** | [**EdFiSessionReference**](EdFiSessionReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**ArrivalTime** | **string** | The time of day the student arrived for the attendance event in ISO 8601 format. | [optional] 
**AttendanceEventReason** | **string** | The reported reason for a student&#39;s absence. | [optional] 
**DepartureTime** | **string** | The time of day the student departed for the attendance event in ISO 8601 format. | [optional] 
**EducationalEnvironmentDescriptor** | **string** | The setting in which a child receives education and related services. This attribute is only used if it differs from the EducationalEnvironment of the Section. This is only used in the AttendanceEvent if different from the associated Section. | [optional] 
**EventDuration** | **double?** | The amount of time for the event as recognized by the school: 1 day &#x3D; 1, 1/2 day &#x3D; 0.5, 1/3 day &#x3D; 0.33. | [optional] 
**SchoolAttendanceDuration** | **int?** | The duration in minutes of the school attendance event. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the StudentSchoolAttendanceEvent entity. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

