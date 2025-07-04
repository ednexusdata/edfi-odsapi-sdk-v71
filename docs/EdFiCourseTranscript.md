# EdFi.OdsApi.Sdk.v71.Models.All.EdFiCourseTranscript

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**CourseAttemptResultDescriptor** | **string** | The result from the student&#39;s attempt to take the course. | 
**CourseReference** | [**EdFiCourseReference**](EdFiCourseReference.md) |  | 
**ExternalEducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | [optional] 
**ResponsibleTeacherStaffReference** | [**EdFiStaffReference**](EdFiStaffReference.md) |  | [optional] 
**StudentAcademicRecordReference** | [**EdFiStudentAcademicRecordReference**](EdFiStudentAcademicRecordReference.md) |  | 
**AcademicSubjects** | [**List&lt;EdFiCourseTranscriptAcademicSubject&gt;**](EdFiCourseTranscriptAcademicSubject.md) | An unordered collection of courseTranscriptAcademicSubjects. The subject area for the course transcript credits awarded in the course transcript. | [optional] 
**AlternativeCourseIdentificationCodes** | [**List&lt;EdFiCourseTranscriptAlternativeCourseIdentificationCode&gt;**](EdFiCourseTranscriptAlternativeCourseIdentificationCode.md) | An unordered collection of courseTranscriptAlternativeCourseIdentificationCodes. The code that identifies the course, course offering, the code from an external educational organization, or other alternate course code. | [optional] 
**AlternativeCourseTitle** | **string** | The descriptive name given to a course of study offered in the school, if different from the CourseTitle. | [optional] 
**AssigningOrganizationIdentificationCode** | **string** | The organization code or name assigning the course identification code. | [optional] 
**AttemptedCreditConversion** | **double?** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional] 
**AttemptedCredits** | **double?** | The value of credits or units of value awarded for the completion of a course. | [optional] 
**AttemptedCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional] 
**CourseCatalogURL** | **string** | The URL for the course catalog that defines the course identification code. | [optional] 
**CoursePrograms** | [**List&lt;EdFiCourseTranscriptCourseProgram&gt;**](EdFiCourseTranscriptCourseProgram.md) | An unordered collection of courseTranscriptCoursePrograms. The program(s) that the student participated in the context of the course. | [optional] 
**CourseRepeatCodeDescriptor** | **string** | Indicates that an academic course has been repeated by a student and how that repeat is to be computed in the student&#39;s academic grade average. | [optional] 
**CourseTitle** | **string** | The descriptive name given to a course of study offered in a school or other institution or organization. In departmentalized classes at the elementary, secondary, and postsecondary levels (and for staff development activities), this refers to the name by which a course is identified (e.g., American History, English III). For elementary and other non-departmentalized classes, it refers to any portion of the instruction for which a grade or report is assigned (e.g., reading, composition, spelling, language arts). | [optional] 
**CreditCategories** | [**List&lt;EdFiCourseTranscriptCreditCategory&gt;**](EdFiCourseTranscriptCreditCategory.md) | An unordered collection of courseTranscriptCreditCategories. A categorization for the course transcript credits awarded in the course transcript. | [optional] 
**EarnedAdditionalCredits** | [**List&lt;EdFiCourseTranscriptEarnedAdditionalCredits&gt;**](EdFiCourseTranscriptEarnedAdditionalCredits.md) | An unordered collection of courseTranscriptEarnedAdditionalCredits. The number of additional credits a student attempted and could earn for successfully completing a given course. | [optional] 
**EarnedCreditConversion** | **double?** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional] 
**EarnedCredits** | **double?** | The value of credits or units of value awarded for the completion of a course. | [optional] 
**EarnedCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional] 
**ExternalEducationOrganizationNameOfInstitution** | **string** | Name of the external institution where the student completed the course; to be used only when the reference external education organization is not available. | [optional] 
**FinalLetterGradeEarned** | **string** | The final indicator of student performance in a class as submitted by the instructor. | [optional] 
**FinalNumericGradeEarned** | **double?** | The final indicator of student performance in a class as submitted by the instructor. | [optional] 
**MethodCreditEarnedDescriptor** | **string** | The method the credits were earned. | [optional] 
**PartialCourseTranscriptAwards** | [**List&lt;EdFiCourseTranscriptPartialCourseTranscriptAwards&gt;**](EdFiCourseTranscriptPartialCourseTranscriptAwards.md) | An unordered collection of courseTranscriptPartialCourseTranscriptAwards. A collection of partial credits and/or grades a student earned against the course over the session, used when awards of credit are incremental. | [optional] 
**Sections** | [**List&lt;EdFiCourseTranscriptSection&gt;**](EdFiCourseTranscriptSection.md) | An unordered collection of courseTranscriptSections. The section(s) associated with the course transcript. | [optional] 
**WhenTakenGradeLevelDescriptor** | **string** | Student&#39;s grade level at time of course. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**LastModifiedDate** | **DateTime** | The date and time the resource was last modified. | [optional] 
**Ext** | **Object** | Extensions to the CourseTranscript entity. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

