CMCS1 HR Management System
CMCS1 (Claims Management and Control System 1) is a WPF (Windows Presentation Foundation) application built in C# to streamline HR processes such as employee claims, registrations, and document management. This tool is designed to improve efficiency in managing HR operations by providing an intuitive interface for claim submissions, employee registration, and file uploads.

Features
Claims Management

Submit claims with details like employee ID, hours worked, hourly rate, and notes.
Attach supporting documents to each claim.
View and update pending claims directly within the app.
Employee Management

Register new employees by providing necessary information, including name, surname, employee ID, password, and role.
Track employee data easily in a structured format.
Document Upload

Upload documents associated with claims or employee files.
Specify file paths and view upload status messages to confirm success.
Technologies Used
C# and WPF: Provides the core application structure and a modern, interactive user interface.
XAML: Used for designing the layout and styling of the WPF components.
Microsoft SQL Server: Manages the backend database for storing claims, employee records, and documents.
Microsoft.Data.SqlClient: Facilitates SQL Server connectivity.
DataGrid Control: Presents tabular data for claims and employee management.
Prerequisites
Visual Studio (with .NET desktop development and SQL Server Data Tools installed)
SQL Server or SQL Server Express instance
.NET Framework 4.7.2 or higher
Installation
Clone the Repository:

bash
Copy code
git clone https://github.com/your-repo/CMCS1.git
cd CMCS1
Open in Visual Studio:

Open the CMCS1 solution file (CMCS1.sln) in Visual Studio.
Configure Database Connection:

Open the App.config file.
Update the connection string in <connectionStrings> with your SQL Server details:
xml
Copy code
<connectionStrings>
  <add name="CMCS1Database" connectionString="Data Source=YOUR_SERVER;Initial Catalog=YOUR_DATABASE;Integrated Security=True" providerName="System.Data.SqlClient"/>
</connectionStrings>
Replace YOUR_SERVER with your SQL Server instance name and YOUR_DATABASE with your database name.
Build and Run the Application:

In Visual Studio, select Build > Build Solution.
After a successful build, run the application by selecting Start or pressing F5.
Usage
Claims Management: Go to the "Claims" tab to submit or view claims. Enter details for a new claim, attach a document if necessary, and submit.
Employee Management: Go to the "Employee Management" tab to register new employees by filling out their information.
Document Upload: Use the "Document Upload" tab to upload files relevant to claims or employee records.
Important Note
Before using CMCS1 on a different machine or database, make sure to update the connection string in App.config to reflect your environment's SQL Server details. This is essential for the application to function properly and connect to the database.

Troubleshooting
Common Issues
Connection Errors:

Ensure that your SQL Server instance is running.
Verify that the connection string in App.config is correct.
Make sure your SQL Server accepts connections from your application.
Database Schema Issues:

If you encounter errors about missing columns (e.g., Invalid column name 'DateSubmitted'), check your database schema to ensure it matches the application’s data structure.
License
This project is licensed under the MIT License. See the LICENSE file for more details.

Contact
For questions or assistance, please reach out to Kgosi Sebako.

