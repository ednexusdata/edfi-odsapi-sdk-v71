# EdFi.OdsApi.Sdk.v71.Models.All.EdFiSession

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**SessionName** | **string** | The identifier for the calendar for the academic session. | 
**SchoolReference** | [**EdFiSchoolReference**](EdFiSchoolReference.md) |  | 
**SchoolYearTypeReference** | [**EdFiSchoolYearTypeReference**](EdFiSchoolYearTypeReference.md) |  | 
**AcademicWeeks** | [**List&lt;EdFiSessionAcademicWeek&gt;**](EdFiSessionAcademicWeek.md) | An unordered collection of sessionAcademicWeeks. The academic weeks associated with the school year. | [optional] 
**BeginDate** | **DateOnly** | Month, day, and year of the first day of the session. | 
**EndDate** | **DateOnly** | Month, day and year of the last day of the session. | 
**GradingPeriods** | [**List&lt;EdFiSessionGradingPeriod&gt;**](EdFiSessionGradingPeriod.md) | An unordered collection of sessionGradingPeriods. Grading periods associated with the session. | [optional] 
**TermDescriptor** | **string** | A descriptor value to indicate the term that the session is associated with. | 
**TotalInstructionalDays** | **int** | The total number of instructional days in the school calendar. | 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the Session entity. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

