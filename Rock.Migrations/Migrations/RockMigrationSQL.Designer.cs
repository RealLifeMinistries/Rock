﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rock.Migrations.Migrations {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class RockMigrationSQL {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal RockMigrationSQL() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Rock.Migrations.Migrations.RockMigrationSQL", typeof(RockMigrationSQL).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /* Pointer used for text / image updates. */
        ///DECLARE @pv binary(16)
        ///
        ///alter table [Attendance] nocheck constraint all
        ///alter table [AttendanceCode] nocheck constraint all
        ///alter table [Attribute] nocheck constraint all
        ///alter table [AttributeCategory] nocheck constraint all
        ///alter table [AttributeQualifier] nocheck constraint all
        ///alter table [AttributeValue] nocheck constraint all
        ///alter table [Audit] nocheck constraint all
        ///alter table [Auth] nocheck constraint all
        ///alter table [BinaryFile] nocheck cons [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _201311251734059_CreateDatabase_PopulateData {
            get {
                return ResourceManager.GetString("_201311251734059_CreateDatabase_PopulateData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///DECLARE @MergeTemplateEntityTypeId int = (SELECT TOP 1 [Id] FROM [EntityType] WHERE [Name] = &apos;Rock.MergeTemplates.WordDocumentMergeTemplateType&apos;)
        ///DECLARE @GeneralCategoryId int = (SELECT TOP 1 [Id] FROM [Category] WHERE [Guid] = &apos;CAA86576-901B-C4A6-4F62-70EB0A2B32A8&apos;)
        ///
        ///
        ///-- envelope
        ///INSERT INTO [dbo].[BinaryFile] ([IsTemporary], [IsSystem], [BinaryFileTypeId], [Path], [FileName], [MimeType], [Description], [StorageEntityTypeId], [Guid]) 
        ///        VALUES 
        ///        (0, 0, 3, N&apos;~/GetFile.ashx?guid=425298 [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _201506051749054_AddSampleMergeDocs {
            get {
                return ResourceManager.GetString("_201506051749054_AddSampleMergeDocs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BEGIN TRY
        ///    ALTER TABLE Person
        ///
        ///    DROP COLUMN DaysUntilBirthday
        ///END TRY
        ///
        ///BEGIN CATCH
        ///END CATCH
        ///
        ///ALTER TABLE Person ADD DaysUntilBirthday AS (
        ///    CASE 
        ///        -- if there birthday is Feb 29 and their next birthday is this year and it isn&apos;t a leap year, set their birthday to Feb 28 (this year)
        ///        WHEN (
        ///                BirthMonth = 2
        ///                AND BirthDay = 29
        ///                AND datepart(month, sysdatetime()) &lt; 3
        ///                AND (isdate(convert(VARCHAR(4), datepart(year, [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _201506112030400_PersonDaysUntilBirthday {
            get {
                return ResourceManager.GetString("_201506112030400_PersonDaysUntilBirthday", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///&lt;doc&gt;
        ///	&lt;summary&gt;
        ///		This stored procedure returns data used by the pledge analytics block
        ///	&lt;/summary&gt;
        ///&lt;/doc&gt;
        ///*/
        ///CREATE PROCEDURE [dbo].[spFinance_PledgeAnalyticsQuery]
        ///	  @AccountId int
        ///	, @StartDate datetime = NULL
        ///	, @EndDate datetime = NULL
        ///	, @MinAmountPledged decimal(18,2) = NULL
        ///	, @MaxAmountPledged decimal(18,2) = NULL
        ///	, @MinComplete decimal(18,2) = NULL
        ///	, @MaxComplete decimal(18,2) = NULL
        ///	, @MinAmountGiven decimal(18,2) = NULL
        ///	, @MaxAmountGiven decimal(18,2) = NULL
        ///	, @Include [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _201506121300596_FinancialAnalyticsProcs_1 {
            get {
                return ResourceManager.GetString("_201506121300596_FinancialAnalyticsProcs_1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///&lt;doc&gt;
        ///	&lt;summary&gt;
        ///		This stored procedure returns data used by the giving analytics block
        ///	&lt;/summary&gt;
        ///&lt;/doc&gt;
        ///*/
        ///CREATE PROCEDURE [dbo].[spFinance_GivingAnalyticsQuery]
        ///	  @StartDate datetime = NULL
        ///	, @EndDate datetime = NULL
        ///	, @MinAmount decimal(18,2) = NULL
        ///	, @MaxAmount decimal(18,2) = NULL
        ///	, @AccountIds varchar(max) = NULL
        ///	, @CurrencyTypeIds varchar(max) = NULL
        ///	, @SourceTypeIds varchar(max) = NULL
        ///	, @ViewBy varchar(1) = &apos;G&apos;		-- G = Giving Leader, A = Adults, C = Children, F = Famil [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _201506121300596_FinancialAnalyticsProcs_2 {
            get {
                return ResourceManager.GetString("_201506121300596_FinancialAnalyticsProcs_2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE AttributeValue DROP COLUMN ValueAsNumeric
        ///
        ///ALTER TABLE AttributeValue ADD [ValueAsNumeric] AS (
        ///    CASE 
        ///        WHEN len([value]) &lt; (100)
        ///            AND isnumeric([value]) = (1)
        ///            AND NOT [value] LIKE &apos;%[^0-9.]%&apos;
        ///            AND NOT [value] LIKE &apos;%[.]%&apos;
        ///            THEN TRY_CONVERT([numeric](38, 10), [value])
        ///        END
        ///    ) persisted
        ///
        ///CREATE INDEX IX_ValueAsNumeric on AttributeValue (ValueAsNumeric)
        ///
        ///
        ///ALTER TABLE AttributeValue DROP COLUMN ValueAsDateTime
        ///ALTER TA [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _201506130028565_AttributeValueAsDateTimeIndex_CreateColumns {
            get {
                return ResourceManager.GetString("_201506130028565_AttributeValueAsDateTimeIndex_CreateColumns", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TRIGGER [dbo].[tgrAttributeValue_InsertUpdate]
        ///   ON  [dbo].[AttributeValue]
        ///   AFTER INSERT, UPDATE
        ///AS 
        ///BEGIN
        ///    update [AttributeValue] set ValueAsDateTime = CASE WHEN len(value) &lt; 50 and isnull(value,&apos;&apos;) != &apos;&apos; and isnumeric([value]) = 0 THEN
        ///        ISNULL(TRY_CONVERT([datetime], TRY_CONVERT([datetimeoffset], left([value], (19)), 126)), TRY_CONVERT(DATETIME, [value], 101))
        ///    END where Id in (select Id from inserted)
        ///END.
        /// </summary>
        public static string _201506130028565_AttributeValueAsDateTimeIndex_CreateTrigger {
            get {
                return ResourceManager.GetString("_201506130028565_AttributeValueAsDateTimeIndex_CreateTrigger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to update AttributeValue set Value = Value WHERE CASE WHEN len(value) &lt; 50 and isnull(value,&apos;&apos;) != &apos;&apos; and isnumeric([value]) = 0 THEN
        ///        ISNULL(TRY_CONVERT([datetime], TRY_CONVERT([datetimeoffset], left([value], (19)), 126)), TRY_CONVERT(DATETIME, [value], 101))
        ///    END is not NULL
        ///
        ///.
        /// </summary>
        public static string _201506130028565_AttributeValueAsDateTimeIndex_UpdateValues {
            get {
                return ResourceManager.GetString("_201506130028565_AttributeValueAsDateTimeIndex_UpdateValues", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- child label w/ icons
        ///  UPDATE [BinaryFileData]
        ///	SET [Content] = 0xEFBBBF1043547E7E43442C7E43435E7E43547E0D0A5E58417E54413030307E4A534E5E4C54305E4D4E575E4D54445E504F4E5E504D4E5E4C48302C305E4A4D415E5052362C367E534432345E4A55535E4C524E5E4349305E585A0D0A5E58410D0A5E4D4D540D0A5E50573831320D0A5E4C4C303430360D0A5E4C53300D0A5E46543435322C3131395E41304E2C3133352C3133345E46423333332C312C302C525E46485C5E46445757575E46530D0A5E465431322C3235345E41304E2C3133352C3134365E46485C5E4644355E46530D0A5E465431342C3330395E413 [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _201506162223455_EnsurePersonAlias_UpdateCheckinLabels {
            get {
                return ResourceManager.GetString("_201506162223455_EnsurePersonAlias_UpdateCheckinLabels", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- Calendar Detail Page
        ///UPDATE [Page] SET 
        ///    [InternalName] = &apos;Event Calendar&apos;,
        ///    [PageTitle] = &apos;Event Calendar&apos;,
        ///    [BrowserTitle] = &apos;Event Calendar&apos;,
        ///    [IconCssClass] = &apos;fa fa-calendar&apos;,
        ///    [BreadCrumbDisplayName] = 0 
        ///WHERE [GUID] = &apos;B54725E1-3640-4419-B580-2AF77DAF6568&apos;
        ///
        ///-- Calendar Item Detail Page
        ///UPDATE [Page] SET 
        ///    [InternalName] = &apos;Calendar Item&apos;,
        ///    [PageTitle] = &apos;Calendar Item&apos;,
        ///    [BrowserTitle] = &apos;Calendar Item&apos;,
        ///    [IconCssClass] = &apos;fa fa-calendar-o&apos;,
        ///    [BreadCru [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _201506170003272_UpdateCalendarBlocks {
            get {
                return ResourceManager.GetString("_201506170003272_UpdateCalendarBlocks", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DECLARE @CategoryId int = (SELECT TOP 1 [Id] FROM [Category] WHERE [Guid] = &apos;B31064D2-F2EF-43AA-8BEA-14DF257CBC59&apos;)
        ///        IF @CategoryId IS NOT NULL
        ///        BEGIN     
        ///            INSERT INTO [SystemEmail]
        ///	        ([IsSystem], [Title], [Subject], [Body], [Guid], [CategoryId])
        ///            VALUES
        ///	            (0, &apos;Pending Group Members Notification&apos;, &apos;New Pending Group Members | {{ GlobalAttribute.OrganizationName}}&apos;, &apos;{{ &apos;&apos;Global&apos;&apos; | Attribute:&apos;&apos;EmailHeader&apos;&apos; }}
        ///
        ///
        ///&lt;p&gt;
        ///    {{ Person.NickName }},        /// [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _201506242325188_GeoSpatialIndexes_AddSystemEmail {
            get {
                return ResourceManager.GetString("_201506242325188_GeoSpatialIndexes_AddSystemEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///&lt;doc&gt;
        ///	&lt;summary&gt;
        ///		This stored procedure returns data used by the pledge analytics block
        ///	&lt;/summary&gt;
        ///&lt;/doc&gt;
        ///*/
        ///ALTER PROCEDURE [dbo].[spFinance_PledgeAnalyticsQuery]
        ///	  @AccountId int
        ///	, @StartDate datetime = NULL
        ///	, @EndDate datetime = NULL
        ///	, @MinAmountPledged decimal(18,2) = NULL
        ///	, @MaxAmountPledged decimal(18,2) = NULL
        ///	, @MinComplete decimal(18,2) = NULL
        ///	, @MaxComplete decimal(18,2) = NULL
        ///	, @MinAmountGiven decimal(18,2) = NULL
        ///	, @MaxAmountGiven decimal(18,2) = NULL
        ///	, @IncludeP [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _201506281615197_GivingAnalyticsEmail_1 {
            get {
                return ResourceManager.GetString("_201506281615197_GivingAnalyticsEmail_1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///&lt;doc&gt;
        ///	&lt;summary&gt;
        ///		This stored procedure returns data used by the giving analytics block
        ///	&lt;/summary&gt;
        ///&lt;/doc&gt;
        ///*/
        ///ALTER PROCEDURE [dbo].[spFinance_GivingAnalyticsQuery]
        ///	  @StartDate datetime = NULL
        ///	, @EndDate datetime = NULL
        ///	, @MinAmount decimal(18,2) = NULL
        ///	, @MaxAmount decimal(18,2) = NULL
        ///	, @AccountIds varchar(max) = NULL
        ///	, @CurrencyTypeIds varchar(max) = NULL
        ///	, @SourceTypeIds varchar(max) = NULL
        ///	, @ViewBy varchar(1) = &apos;G&apos;		-- G = Giving Leader, A = Adults, C = Children, F = Family [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _201506281615197_GivingAnalyticsEmail_2 {
            get {
                return ResourceManager.GetString("_201506281615197_GivingAnalyticsEmail_2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DECLARE @CategoryId int = (SELECT TOP 1 [Id] FROM [Category] WHERE [Guid] = &apos;B31064D2-F2EF-43AA-8BEA-14DF257CBC59&apos;)
        ///        IF @CategoryId IS NOT NULL
        ///        BEGIN     
        ///            INSERT INTO [SystemEmail]
        ///	        ([IsSystem], [Title], [Subject], [Body], [Guid], [CategoryId])
        ///            VALUES
        ///	            (0, &apos;Group Requirements Notification&apos;, &apos;Group Requirements Report | {{ &apos;&apos;Global&apos;&apos; | Attribute:&apos;&apos;OrganizationName&apos;&apos; }}&apos;, &apos;{{ &apos;&apos;Global&apos;&apos; | Attribute:&apos;&apos;EmailHeader&apos;&apos; }}
        ///
        ///&lt;p&gt;
        ///    {{ Person.NickNa [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _201507062330051_GroupRequirementsNotificationEmail {
            get {
                return ResourceManager.GetString("_201507062330051_GroupRequirementsNotificationEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT [dbo].[EventCalendar] ( [Name], [Description], [IconCssClass], [IsActive],  [Guid], [ForeignId]) 
        ///    VALUES ( N&apos;Internal&apos;, N&apos;A calendar for church staff and staff-like users.&apos;, N&apos;fa fa-lock&apos;, 1, N&apos;8c7f7f4e-1c51-41d3-9ac3-02b3f4054798&apos;, NULL)
        ///DECLARE @InternalCalendarId int = SCOPE_IDENTITY()
        ///
        ///DECLARE @PublicCalendarId int = (SELECT TOP 1 [Id] FROM [EventCalendar] WHERE [Guid] = &apos;8A444668-19AF-4417-9C74-09F842572974&apos;)
        ///DECLARE @CarPhotoId int = (SELECT TOP 1 [Id] FROM [BinaryFile] WHERE [Guid] =  [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _201507081827047_SampleCalendarEvents {
            get {
                return ResourceManager.GetString("_201507081827047_SampleCalendarEvents", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to     DECLARE @CategoryId int = ( SELECT TOP 1 [Id] FROM [Category] WHERE [Guid] = &apos;4A7D0D1F-E160-445E-9D29-AEBD140DA242&apos; )
        ///    IF @CategoryId IS NOT NULL
        ///    BEGIN     
        ///
        ///        INSERT INTO [SystemEmail] ([IsSystem], [Title], [Subject], [Body], [Guid], [CategoryId])
        ///        VALUES
        ///	        (0, &apos;Registration Notification&apos;, &apos;{{ RegistrationInstance.Name }} Registration&apos;, &apos;{{ &apos;&apos;Global&apos;&apos; | Attribute:&apos;&apos;EmailHeader&apos;&apos; }}
        ///{% assign registrantCount = Registration.Registrants | Size %}
        ///&lt;p&gt;
        ///    The following { [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _201507121943445_RegistrationEmails {
            get {
                return ResourceManager.GetString("_201507121943445_RegistrationEmails", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DECLARE @PageId int = ( SELECT TOP 1 [Id] FROM [Page] WHERE [Guid] = &apos;F7CA6E0F-C319-47AB-9A6D-247C5716D846&apos; )
        ///DELETE [PageRoute] WHERE [PageId] = @PageId
        ///
        ///UPDATE [Page] SET [BreadCrumbDisplayName] = 0 
        ///WHERE [GUID] = &apos;F7CA6E0F-C319-47AB-9A6D-247C5716D846&apos;
        ///
        ///UPDATE [Page] SET 
        ///    [InternalName] = &apos;Registration&apos;,
        ///    [PageTitle] = &apos;Registration&apos;,
        ///    [BrowserTitle] = &apos;Registration&apos;,
        ///    [BreadCrumbDisplayName] = 1
        ///WHERE [GUID] = &apos;FC81099A-2F98-4EBA-AC5A-8300B2FE46C4&apos;
        ///
        ///DECLARE @TemplateEntityTypeI [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _201507171137229_RegistrationInstanceContactPhone {
            get {
                return ResourceManager.GetString("_201507171137229_RegistrationInstanceContactPhone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --Existing Variables
        ///DECLARE @Date DATETIME = GETDATE()
        ///
        ///DECLARE @PersonAliasId int = ( SELECT TOP 1 [Id] FROM [PersonAlias] ORDER BY [Id] )
        ///
        ///DECLARE @CampusId int = ( SELECT TOP 1 [Id] FROM [Campus] ORDER BY [Id] )
        ///
        ///DECLARE @ConnectionAdministrationGroupId int = ( SELECT TOP 1 [Id] FROM [Group] WHERE [Guid] = N&apos;060971D2-EAF9-4C0D-B6F6-F01725CAA5AC&apos;)
        ///
        ///DECLARE @ServingTeamGroupTypeId int = ( SELECT TOP 1 [Id] FROM [GroupType] WHERE [Guid] = N&apos;2C42B2D4-1C5F-4AD5-A9AD-08631B872AC4&apos;)
        ///DECLARE @GeneralG [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _201507181918494_ConnectionChangesAndSampleData {
            get {
                return ResourceManager.GetString("_201507181918494_ConnectionChangesAndSampleData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- JE: Reorder the Communication List on the Person Profile Page
        ///  UPDATE [Block] SET [Order] = 0
        ///  WHERE [Guid] = &apos;27F84ADB-AA13-439E-A130-FBF73698B172&apos;
        ///
        ///  UPDATE [Block] SET [Order] = 1
        ///  WHERE [Guid] = &apos;2D99AB97-4B9C-4D72-B207-8F36AE90D495&apos;
        ///
        ///  UPDATE [Block] SET [Order] = 2
        ///  WHERE [Guid] = &apos;F98649D7-E522-46CB-8F67-01DB7F59E3AA&apos;
        ///
        ///-- JE: Make Involvement Connection Type &quot;Enable Full Activity List&quot; = true
        ///UPDATE [ConnectionType]
        ///  SET [EnableFullActivityList] = 1
        ///  WHERE [Guid] = &apos;DD565087-A4B [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _201507281546100_CalendarContentChannel {
            get {
                return ResourceManager.GetString("_201507281546100_CalendarContentChannel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- Create root DataViewFilter for DataView: Background check about to expire
        ///IF NOT EXISTS (SELECT * FROM DataViewFilter where [Guid] = &apos;F924B369-FF1B-4254-AEB0-48BF89647205&apos;) BEGIN    
        ///    DECLARE
        ///        @ParentDataViewFilterId int = null,
        ///        @DataViewFilterEntityTypeId int = null
        ///
        ///    INSERT INTO [DataViewFilter] (ExpressionType, ParentId, EntityTypeId, Selection, [Guid]) 
        ///    values (1,@ParentDataViewFilterId,@DataViewFilterEntityTypeId,&apos;&apos;,&apos;F924B369-FF1B-4254-AEB0-48BF89647205&apos;)
        ///END
        ///go
        ///
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _201508010008536_BackgroundCheckExpiringSoon {
            get {
                return ResourceManager.GetString("_201508010008536_BackgroundCheckExpiringSoon", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to   -- JE: Change name and icon of the event detail page
        ///  UPDATE [Page]	SET 
        ///    [InternalName] = &apos;Event Detail&apos;, 
        ///    [BrowserTitle] = &apos;Event Detail&apos;, 
        ///    [PageTitle] = &apos;Event Detail&apos;, 
        ///    [IconCssClass] = &apos;fa fa-calendar-check-o&apos;
        ///  WHERE [Guid] = &apos;7FB33834-F40A-4221-8849-BB8C06903B04&apos;
        ///
        /// -- JE: Fix Mime Type on Check-in Labels
        /// UPDATE [BinaryFile] SET [MimeType] = &apos;text/plain&apos;
        /// WHERE [BinaryFileTypeId] = (SELECT TOP 1 [Id] FROM [BinaryFileType] WHERE [Guid] = &apos;DE0E5C50-234B-474C-940C-C571F385E65 [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _201508041124356_RegistrationContact {
            get {
                return ResourceManager.GetString("_201508041124356_RegistrationContact", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///&lt;doc&gt;
        ///	&lt;summary&gt;
        ///		This stored procedure returns the Mailing Addresses and any CustomMessages for the Contribution Statement, but not the actual transactions
        ///		The StatementGenerator utility uses this procedure along with querying transactions thru REST to generate statements
        ///	&lt;/summary&gt;
        ///
        ///	&lt;returns&gt;
        ///		* PersonId
        ///		* GroupId
        ///		* AddressPersonNames
        ///		* Street1
        ///		* Street2
        ///		* City
        ///		* State
        ///		* PostalCode
        ///		* StartDate
        ///		* EndDate
        ///		* CustomMessage1
        ///		* CustomMessage2
        ///	&lt;/returns&gt;
        ///	&lt;par [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _201508111253454_SiteMobilePage {
            get {
                return ResourceManager.GetString("_201508111253454_SiteMobilePage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- FinancialTransaction
        ///INSERT INTO [FinancialPaymentDetail] ( [CurrencyTypeValueId], [CreditCardTypeValueId], [Guid], [ForeignId] )
        ///SELECT [CurrencyTypeValueId], [CreditCardTypeValueId], NEWID(), CAST( [Id] AS VARCHAR )
        ///FROM [FinancialTransaction]
        ///
        ///UPDATE F
        ///SET [FinancialPaymentDetailId] = D.[Id]
        ///FROM [FinancialPaymentDetail] D
        ///INNER JOIN [FinancialTransaction] F ON CAST( F.[ID] AS VARCHAR ) = D.[ForeignId]
        ///WHERE D.[ForeignId] IS NOT NULL
        ///
        ///UPDATE [FinancialPaymentDetail]
        ///SET [ForeignId] = NULL        /// [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _201508111636214_FinancialPaymentDetails {
            get {
                return ResourceManager.GetString("_201508111636214_FinancialPaymentDetails", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- Update the Homepage and Error layouts on RockRMS site to be system
        ///DECLARE @SiteId int = ( SELECT TOP 1 [Id] FROM [Site] WHERE [Guid] = &apos;C2D29296-6A87-47A9-A753-EE4E9159C4C4&apos; )
        ///UPDATE [Layout] SET 
        ///	 [IsSystem] = 1
        ///	,[Guid] = &apos;CABD576F-C700-4690-835A-1BFBDD7DCBE6&apos;
        ///WHERE [SiteId] = @SiteId
        ///AND [FileName] = &apos;HomePage&apos;
        ///
        ///UPDATE [Layout] SET 
        ///	 [IsSystem] = 1
        ///	,[Guid] = &apos;7E816087-6A8C-498E-BFE7-D0B684A9DD45&apos;
        ///WHERE [SiteId] = @SiteId
        ///AND [FileName] = &apos;Error&apos;
        ///
        ///-- Update the Blank layout on externa [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _201508162108504_FollowingEventsSuggestions {
            get {
                return ResourceManager.GetString("_201508162108504_FollowingEventsSuggestions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DECLARE @PersonAliasEntityTypeId int = ( SELECT TOP 1 [Id] FROM [EntityType] WHERE [Name] = &apos;Rock.Model.PersonAlias&apos; )
        ///IF @PersonAliasEntityTypeId IS NOT NULL
        ///BEGIN
        ///
        ///    DECLARE @EntityTypeId int 
        ///    DECLARE @AttributeId int 
        ///    DECLARE @EntityId int
        ///
        ///    SET @EntityTypeId = ( SELECT TOP 1 [Id] FROM [EntityType] WHERE [Guid] = &apos;17DFDE21-0C1E-426F-8516-4BBA9ED28385&apos; )
        ///	INSERT INTO [FollowingEventType] ( [Name], [Description], [EntityTypeId], [FollowedEntityTypeId], [IsActive], [SendOnWeekends], [I [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _201508171751190_FollowingEventNotification {
            get {
                return ResourceManager.GetString("_201508171751190_FollowingEventNotification", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///&lt;doc&gt;
        ///	&lt;summary&gt;
        ///		This stored procedure returns data used by the pledge analytics block
        ///	&lt;/summary&gt;
        ///&lt;/doc&gt;
        ///*/
        ///ALTER PROCEDURE [dbo].[spFinance_PledgeAnalyticsQuery]
        ///	  @AccountId int
        ///	, @StartDate datetime = NULL
        ///	, @EndDate datetime = NULL
        ///	, @MinAmountPledged decimal(18,2) = NULL
        ///	, @MaxAmountPledged decimal(18,2) = NULL
        ///	, @MinComplete decimal(18,2) = NULL
        ///	, @MaxComplete decimal(18,2) = NULL
        ///	, @MinAmountGiven decimal(18,2) = NULL
        ///	, @MaxAmountGiven decimal(18,2) = NULL
        ///	, @IncludeP [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _201508241735382_RegistrationPersonNote {
            get {
                return ResourceManager.GetString("_201508241735382_RegistrationPersonNote", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- MP: Fix FinancialTransactionImage wrong BinaryFileType
        ///DECLARE @binaryFileTypeContributionId INT = (
        ///        SELECT TOP 1 Id
        ///        FROM BinaryFileType
        ///        WHERE [Guid] = &apos;6D18A9C4-34AB-444A-B95B-C644019465AC&apos;
        ///        )
        ///
        ///DECLARE @binaryFileTypeContributionStorageEntityTypeId INT = (
        ///        SELECT TOP 1 StorageEntityTypeId
        ///        FROM BinaryFileType
        ///        WHERE [Guid] = &apos;6D18A9C4-34AB-444A-B95B-C644019465AC&apos;
        ///        )
        ///
        ///UPDATE BinaryFile
        ///SET BinaryFileTypeId = @binaryFileTypeContribu [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _201509022116398_EntitySetPurpose {
            get {
                return ResourceManager.GetString("_201509022116398_EntitySetPurpose", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///&lt;doc&gt;
        ///	&lt;summary&gt;
        ///		This stored procedure returns the Mailing Addresses and any CustomMessages for the Contribution Statement, but not the actual transactions
        ///		The StatementGenerator utility uses this procedure along with querying transactions thru REST to generate statements
        ///	&lt;/summary&gt;
        ///
        ///	&lt;returns&gt;
        ///		* PersonId
        ///		* GroupId
        ///		* AddressPersonNames
        ///		* Street1
        ///		* Street2
        ///		* City
        ///		* State
        ///		* PostalCode
        ///		* StartDate
        ///		* EndDate
        ///		* CustomMessage1
        ///		* CustomMessage2
        ///	&lt;/returns&gt;
        ///	&lt;par [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _201509022116398_EntitySetPurpose_spFinance_ContributionStatementQuery {
            get {
                return ResourceManager.GetString("_201509022116398_EntitySetPurpose_spFinance_ContributionStatementQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///&lt;doc&gt;
        ///	&lt;summary&gt;
        /// 		This function returns either the FullName of the specified Person or a list of names of family members
        ///        In the case of a group (family), it will return the names of the adults of the family. If there are no adults in the family, the names of the non-adults will be listed
        ///        Example1 (specific person): Bob Smith 
        ///        Example2 (family with kids): Bill and Sally Jones
        ///        Example3 (different lastnames): Jim Jackson and Betty Sanders
        ///        Example4 (just kids [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _201509022116398_EntitySetPurpose_ufnCrm_GetFamilyTitle {
            get {
                return ResourceManager.GetString("_201509022116398_EntitySetPurpose_ufnCrm_GetFamilyTitle", resourceCulture);
            }
        }
    }
}
