build:
	dotnet build
clean:
	dotnet clean
restore:
	dotnet restore
run:
	dotnet run --project src/FluffyDoodle
watch-run:
	dotnet watch --project src/FluffyDoodle/ run
test:
	dotnet test
watch-test:
	dotnet watch --project fluffy-doodle.sln test
	
