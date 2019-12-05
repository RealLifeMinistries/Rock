// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

namespace Rock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    /// <summary>
    ///
    /// </summary>
<<<<<<< HEAD:Rock.Migrations/Migrations/Version 9.0/Version 1.9.0/201905291549561_UpdateSubjectLength.cs
    public partial class UpdateSubjectLength : Rock.Migrations.RockMigration
=======
    public partial class AddDescriptionToRegistrationTemplate1 : Rock.Migrations.RockMigration
>>>>>>> c17a38f8cfc45c368e6f470b636d7425c4142611:Rock.Migrations/Migrations/Version 9.0/Version 1.9.0/201905142021095_AddDescriptionToRegistrationTemplate1.cs
    {
        /// <summary>
        /// Operations to be performed during the upgrade process.
        /// </summary>
        public override void Up()
        {
<<<<<<< HEAD:Rock.Migrations/Migrations/Version 9.0/Version 1.9.0/201905291549561_UpdateSubjectLength.cs
            AlterColumn( "dbo.SystemEmail", "Subject", c => c.String( nullable: false, maxLength: 1000 ) );
            AlterColumn( "dbo.Communication", "Subject", c => c.String( maxLength: 1000 ) );
            AlterColumn( "dbo.CommunicationTemplate", "Subject", c => c.String( maxLength: 1000 ) );
=======
            AddColumn("dbo.RegistrationTemplate", "Description", c => c.String());
            Sql(@"
-- Set values to blank instead of null.
UPDATE [dbo].[RegistrationTemplate] SET [Description] = '';
GO

-- Set NOT NULL flag.
ALTER TABLE [dbo].[RegistrationTemplate] ALTER COLUMN [Description] NVARCHAR(MAX) NOT NULL;
GO
");
>>>>>>> c17a38f8cfc45c368e6f470b636d7425c4142611:Rock.Migrations/Migrations/Version 9.0/Version 1.9.0/201905142021095_AddDescriptionToRegistrationTemplate1.cs
        }

        /// <summary>
        /// Operations to be performed during the downgrade process.
        /// </summary>
        public override void Down()
        {
<<<<<<< HEAD:Rock.Migrations/Migrations/Version 9.0/Version 1.9.0/201905291549561_UpdateSubjectLength.cs
            AlterColumn( "dbo.CommunicationTemplate", "Subject", c => c.String( maxLength: 100 ) );
            AlterColumn( "dbo.Communication", "Subject", c => c.String( maxLength: 100 ) );
            AlterColumn( "dbo.SystemEmail", "Subject", c => c.String( nullable: false, maxLength: 200 ) );
=======
            DropColumn("dbo.RegistrationTemplate", "Description");
>>>>>>> c17a38f8cfc45c368e6f470b636d7425c4142611:Rock.Migrations/Migrations/Version 9.0/Version 1.9.0/201905142021095_AddDescriptionToRegistrationTemplate1.cs
        }
    }
}
