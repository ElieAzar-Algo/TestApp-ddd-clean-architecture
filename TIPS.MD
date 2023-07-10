Migrations:
1. go to CcssApi project directory
2. dotnet ef --project ../QCS.Domain/QCS.Domain.csproj database drop
3. dotnet ef --project ../QCS.Domain/QCS.Domain.csproj migrations remove
4. dotnet ef --project ../QCS.Domain/QCS.Domain.csproj migrations add InitialCreate
5. dotnet ef --project ../QCS.Domain/QCS.Domain.csproj database update
6. From CcssApi root project run "dotnet run seeddata"

Common Errors
The Body inferred error: means some services are not registered in the dependency injection class under Startup folder
project CcssApi.Core specifically either in RegisterServices or in RegisterValidators

If you get the below error or similar means there is no permission for the user granted on the API resource "Roles" and Policy
Error: Error serializing `.data` returned from `getServerSideProps` in "/admin/users".
Reason: `undefined` cannot be serialized as JSON. Please use `null` or omit this value.

Publish to IIS
dotnet publish --configuration Release
Then copy the content under the below to IIS ccssapi folder 
CcssApi -> /Users/ismatayash/Projects/ContactCenter/CcssApiProjects/CcssApi/bin/Release/net7.0/publish/
The folder Attachments must exist on the ccssapi folder on IIS and Modify permission should be given to it for the IISUSERS user

Logs
Log file logged daily and saved on the server under C:/ccss/logs delete from time to time

Repository FOlder in the Core project
It is not used and may be deleted only kept as a sample on how to write Generic Repos and unit of work.