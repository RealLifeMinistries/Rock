using Rock.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.reallifeministries.RockExtensions.Migrations
{
    [MigrationNumber(21, "1.2.0")]
    class _019_DefinedTypesForRECOVERYAttendance : Migration
    {
        Guid guidHARVEST = Guid.NewGuid();        
        Guid guidOption2 = Guid.NewGuid();
        Guid guidOption3 = Guid.NewGuid();
        Guid guidOption4 = Guid.NewGuid();
        Guid guidOption5 = Guid.NewGuid();
        Guid guidOptionPR = Guid.NewGuid();
        static string rlmHARVESTCampusGuid = "76882ae3-1ce8-42a6-a2b6-8c0b29cf8cf8";
        static string rlmHARVESTAttendanceGroupGuid = "abc6d7f0-cd40-4ab1-ad46-952cb17fb584";
        static string harvestPhone = "+12082097979";
        public override void Down()
        {            
            RockMigrationHelper.DeleteDefinedValue(guidOption2.ToString());
            RockMigrationHelper.DeleteDefinedValue(guidOption3.ToString());
            RockMigrationHelper.DeleteDefinedValue(guidOption4.ToString());
            RockMigrationHelper.DeleteDefinedValue(guidOption5.ToString());
            RockMigrationHelper.DeleteDefinedValue(guidOptionPR.ToString());
            RockMigrationHelper.DeleteDefinedValue(guidHARVEST.ToString());
        }                                                                                                   

        public override void Up()
        {            
            // HARVEST Campus Defined Values
            
            RockMigrationHelper.AddDefinedValue("2CACB86F-D811-4483-98E1-272F1FF8FF5D", harvestPhone, "HARVEST - harvest####", guidHARVEST.ToString(), false);            
            RockMigrationHelper.AddDefinedValue("2CACB86F-D811-4483-98E1-272F1FF8FF5D", harvestPhone, "HARVEST: Text Attendance Option (2) - Prayer Request", guidOption2.ToString(), false);
            RockMigrationHelper.AddDefinedValue("2CACB86F-D811-4483-98E1-272F1FF8FF5D", harvestPhone, "HARVEST - Text Attendance Option (3) - Join a Homegroup", guidOption3.ToString(), false);
            RockMigrationHelper.AddDefinedValue("2CACB86F-D811-4483-98E1-272F1FF8FF5D", harvestPhone, "HARVEST: Text Attendance Option (4) - Review Contact Info", guidOption4.ToString(), false);            
            RockMigrationHelper.AddDefinedValue("2CACB86F-D811-4483-98E1-272F1FF8FF5D", harvestPhone, "HARVEST: Text Attendance Option (5) - Remove Last Attendance", guidOption5.ToString(), false);            
            RockMigrationHelper.AddDefinedValue("2CACB86F-D811-4483-98E1-272F1FF8FF5D", harvestPhone, "HARVEST: Text Attendance Prayer Request Final", guidOptionPR.ToString(), false);
            
            RockMigrationHelper.AddDefinedValueAttributeValue(guidHARVEST.ToString(), "0097D00F-1F29-4217-8E67-D37A619A6FA3", @"d8354ea7-7da9-449d-94ee-210c6b9496d8");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidHARVEST.ToString(), "17B0E99E-2D10-442A-9342-1F9F07996C2B", rlmHARVESTAttendanceGroupGuid);
            RockMigrationHelper.AddDefinedValueAttributeValue(guidHARVEST.ToString(), "3A526D6C-06FC-46CD-A447-9A6D9A74BB4F", @"(?i)harvest[0-9]...");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidHARVEST.ToString(), "67E09C64-3558-48B7-9A27-A9499D0826E8", @"HARVEST Message from: {{ FromPerson.FullName }}");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidHARVEST.ToString(), "79E3B97B-A717-45AB-A279-335FCDEA141A", rlmHARVESTCampusGuid);
            RockMigrationHelper.AddDefinedValueAttributeValue(guidHARVEST.ToString(), "836CFC0B-6750-4A93-8309-EAB868B845AF", @"FromPhone^{{ FromPhone }}|ReceivedDateTime^{{ ReceivedDateTime}}|MessageBody^{{ MessageBody }}|ReceivedDate^{{ReceivedDate}}|ReceivedTime^{{ReceivedTime}}|Campus^Post Falls Campus|AttendanceGroup^Harvest Fest 2016|");
            
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption2.ToString(), "0097D00F-1F29-4217-8E67-D37A619A6FA3", @"8722ac70-d178-4306-bf91-eb2fbb11dfa2");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption2.ToString(), "17B0E99E-2D10-442A-9342-1F9F07996C2B", rlmHARVESTAttendanceGroupGuid);
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption2.ToString(), "3A526D6C-06FC-46CD-A447-9A6D9A74BB4F", @"^2$");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption2.ToString(), "67E09C64-3558-48B7-9A27-A9499D0826E8", @"HARVEST Message From: {{ FromPerson.FullName}}");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption2.ToString(), "79E3B97B-A717-45AB-A279-335FCDEA141A", rlmHARVESTCampusGuid);
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption2.ToString(), "836CFC0B-6750-4A93-8309-EAB868B845AF", @"FromPhone^{{FromPhone}}|ReceivedDateTime^{{ReceivedDateTime}}|MessageBody^{{MessageBody}}|");

            RockMigrationHelper.AddDefinedValueAttributeValue(guidOptionPR.ToString(), "0097D00F-1F29-4217-8E67-D37A619A6FA3", @"88978527-0ca4-4c52-8fda-cf915fafa472");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOptionPR.ToString(), "17B0E99E-2D10-442A-9342-1F9F07996C2B", rlmHARVESTAttendanceGroupGuid);
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOptionPR.ToString(), "3A526D6C-06FC-46CD-A447-9A6D9A74BB4F", @"^2.+");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOptionPR.ToString(), "67E09C64-3558-48B7-9A27-A9499D0826E8", @"HARVEST: Prayer Request from {{ FromPerson.FullName }}");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOptionPR.ToString(), "79E3B97B-A717-45AB-A279-335FCDEA141A", rlmHARVESTCampusGuid);
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOptionPR.ToString(), "836CFC0B-6750-4A93-8309-EAB868B845AF", @"FromPhone^{{FromPhone}}|MessageBody^{{MessageBody}}|");

            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption3.ToString(), "0097D00F-1F29-4217-8E67-D37A619A6FA3", @"ca876138-0461-40ad-ab4f-67678b8baeca");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption3.ToString(), "17B0E99E-2D10-442A-9342-1F9F07996C2B", rlmHARVESTAttendanceGroupGuid);
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption3.ToString(), "3A526D6C-06FC-46CD-A447-9A6D9A74BB4F", @"^3.*");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption3.ToString(), "67E09C64-3558-48B7-9A27-A9499D0826E8", @"HARVEST: Message for Joining a homegroup from {{ FromPerson.FullName}}");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption3.ToString(), "79E3B97B-A717-45AB-A279-335FCDEA141A", rlmHARVESTCampusGuid);
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption3.ToString(), "836CFC0B-6750-4A93-8309-EAB868B845AF", @"FromPhone^{{FromPhone}}|ReceivedDateTime^{{ ReceivedDateTime }}|Campus^Post Falls Campus|");

            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption4.ToString(), "0097D00F-1F29-4217-8E67-D37A619A6FA3", @"feb34437-9600-4330-855f-85404ec10018");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption4.ToString(), "17B0E99E-2D10-442A-9342-1F9F07996C2B", rlmHARVESTAttendanceGroupGuid);
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption4.ToString(), "3A526D6C-06FC-46CD-A447-9A6D9A74BB4F", @"^4.*");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption4.ToString(), "67E09C64-3558-48B7-9A27-A9499D0826E8", @"HARVEST Message From: {{ FromPerson.FullName}}");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption4.ToString(), "79E3B97B-A717-45AB-A279-335FCDEA141A", rlmHARVESTCampusGuid);
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption4.ToString(), "836CFC0B-6750-4A93-8309-EAB868B845AF", @"FromPhone^{{FromPhone}}|ReceivedDateTime^{{ReceivedDateTime}}|MessageBody^{{MessageBody}}|");

            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption5.ToString(), "0097D00F-1F29-4217-8E67-D37A619A6FA3", @"a74396b8-4723-4be7-9f4a-14506c921fc8");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption5.ToString(), "17B0E99E-2D10-442A-9342-1F9F07996C2B", rlmHARVESTAttendanceGroupGuid);
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption5.ToString(), "3A526D6C-06FC-46CD-A447-9A6D9A74BB4F", @"^5.*");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption5.ToString(), "67E09C64-3558-48B7-9A27-A9499D0826E8", @"HARVEST Message From: {{ FromPerson.FullName}}");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption5.ToString(), "79E3B97B-A717-45AB-A279-335FCDEA141A", rlmHARVESTCampusGuid);
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption5.ToString(), "836CFC0B-6750-4A93-8309-EAB868B845AF", @"FromPhone^{{FromPhone}}|ReceivedDateTime^{{ReceivedDateTime}}|MessageBody^{{MessageBody}}|");

        }
    }
}
