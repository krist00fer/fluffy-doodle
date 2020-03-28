build:
	dotnet build
clean:
	dotnet clean
restore:
	dotnet restore
run:
	dotnet run --project src/FluffyDoodle
run-help:
	dotnet run --project src/FluffyDoodle -- --help
run-server:
	dotnet run --project src/FluffyDoodle -- --server
run-server-no-tls:
	dotnet run --project src/FluffyDoodle -- --server --no-tls
watch-run:
	dotnet watch --project src/FluffyDoodle/ run
test:
	dotnet test
watch-test:
	dotnet watch --project fluffy-doodle.sln test

