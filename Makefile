build:
	dotnet build
clean:
	dotnet clean
restore:
	dotnet restore
run:
	dotnet run --no-build --project src/FluffyDoodle
run-client:
	dotnet run --no-build --project src/FluffyDoodle
run-client-no-tls:
	dotnet run --no-build --project src/FluffyDoodle -- --no-tls
run-help:
	dotnet run --no-build --project src/FluffyDoodle -- --help
run-server:
	dotnet run --no-build --project src/FluffyDoodle -- --server
run-server-no-tls:
	dotnet run --no-build --project src/FluffyDoodle -- --server --no-tls
watch-run:
	dotnet watch --project src/FluffyDoodle/ run
test:
	dotnet test
watch-test:
	dotnet watch --project fluffy-doodle.sln test

