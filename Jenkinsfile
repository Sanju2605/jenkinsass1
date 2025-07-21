pipeline {
    agent any

    tools {
        maven 'Maven 3.3' // Make sure 'maven3' is installed in Jenkins Global Tool Config
        // dotnet 'dotnet6' ❌ Remove or comment this line
    }

    stages {
        stage('Checkout Code') {
            steps {
                git 'https://github.com/Sanju2605/jenkinsass1.git'
            }
        }

        stage('Restore Dependencies') {
            steps {
                bat 'dotnet restore EmployeeApp.csproj'
            }
        }

        stage('Build') {
            steps {
                bat 'dotnet build EmployeeApp.csproj --configuration Release'
            }
        }

        stage('Apply DB Migrations') {
            steps {
                bat 'cd database && rh.exe --connectionstring "Server=localhost;Database=EmployeeDB;User Id=sa;Password=YourStrong!Passw0rd;" --a SQL --f .'
            }
        }
    }
}
