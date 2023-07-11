#!/bin/bash

# Run dotnet command 1
dotnet ef --project ../QCS.Domain/QCS.Domain.csproj database drop
echo "Command 1 completed."

# Run dotnet command 2
dotnet ef --project ../QCS.Domain/QCS.Domain.csproj migrations remove
echo "Command 2 completed."

# Run dotnet command 3
dotnet ef --project ../QCS.Domain/QCS.Domain.csproj migrations add InitialCreate
echo "Command 3 completed."

# Run dotnet command 4
dotnet ef --project ../QCS.Domain/QCS.Domain.csproj database update
echo "Command 4 completed."

echo "All dotnet commands completed."
