param ($version='latest')

$currentFolder = $PSScriptRoot
$slnFolder = Join-Path $currentFolder "../../"

Write-Host "********* BUILDING DbMigrator *********" -ForegroundColor Green
$dbMigratorFolder = Join-Path $slnFolder "src/SmartApp.DbMigrator"
Set-Location $dbMigratorFolder
dotnet publish -c Release
docker build -f Dockerfile.local -t mycompanyname/smartapp-db-migrator:$version .

Write-Host "********* BUILDING Angular Application *********" -ForegroundColor Green
$angularAppFolder = Join-Path $slnFolder "../angular"
Set-Location $angularAppFolder
yarn
npm run build:prod
docker build -f Dockerfile.local -t mycompanyname/smartapp-angular:$version .

Write-Host "********* BUILDING Api.Host Application *********" -ForegroundColor Green
$hostFolder = Join-Path $slnFolder "src/SmartApp.HttpApi.Host"
Set-Location $hostFolder
dotnet publish -c Release
docker build -f Dockerfile.local -t mycompanyname/smartapp-api:$version .

$authServerAppFolder = Join-Path $slnFolder "src/SmartApp.AuthServer"
Set-Location $authServerAppFolder
dotnet publish -c Release
docker build -f Dockerfile.local -t mycompanyname/smartapp-authserver:$version .
Write-Host "********* BUILDING Public Web Application *********" -ForegroundColor Green
$webPublicFolder = Join-Path $slnFolder "src/SmartApp.Web.Public"
Set-Location $webPublicFolder
dotnet publish -c Release
docker build -f Dockerfile.local -t mycompanyname/smartapp-web-public:$version .

### ALL COMPLETED
Write-Host "COMPLETED" -ForegroundColor Green
Set-Location $currentFolder