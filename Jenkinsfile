pipeline {
    agent any

    stages {
        stage('Database Migrate') {
            steps {
                bat 'cd database && rh.exe --s localhost --d EmployeeDB --u sa --p YourStrong!Passw0rd --f .'
            }
        }

        stage('Build .NET App') {
            steps {
                bat 'dotnet build src/EmployeeApp/EmployeeApp.csproj'
            }
        }

        stage('Run App') {
            steps {
                bat 'dotnet run --project src/EmployeeApp/EmployeeApp.csproj'
            }
        }
    }
}
