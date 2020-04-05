build:
	dotnet build
clean:
	dotnet clean
restore:
	dotnet restore
run:
	dotnet run --project src/FluffyDoodle.Client
run-client:
	dotnet run --project src/FluffyDoodle.Client
run-client-no-tls:
	dotnet run ---project src/FluffyDoodle.Client -- --no-tls
run-client-help:
	dotnet run --project src/FluffyDoodle.Client -- --help
watch-run-client:
	dotnet watch --project src/FluffyDoodle.Client/ run
watch-run-client-no-tls:
	dotnet watch --project src/FluffyDoodle.Client/ run --no-tls


run-server:
	dotnet run --project src/FluffyDoodle.Server
run-server-no-tls:
	dotnet run --project src/FluffyDoodle.Server -- --no-tls
run-server-help:
	dotnet run --project src/FluffyDoodle.Server -- --help
watch-run-server:
	dotnet watch --project src/FluffyDoodle.Server/ run
watch-run-server-no-tls:
	dotnet watch --project src/FluffyDoodle.Server/ run --no-tls

test:
	dotnet test
watch-test:
	dotnet watch --project fluffy-doodle.sln test

