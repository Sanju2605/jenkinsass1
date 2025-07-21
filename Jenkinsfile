pipeline {
    agent any

    tools {
        // Assuming you installed .NET SDK in Jenkins
        dotnet 'dotnet6' // Or whatever name you configured in Jenkins global tool settings
    }

    stages {
        stage('Clone Repository') {
            steps {
                git 'https://github.com/Sanju2605/jenkinsass1.git'
            }
        }

        stage('Restore Dependencies') {
            steps {
                dir('src') {
                    bat 'dotnet restore'
                }
            }
        }

        stage('Build Solution') {
            steps {
                dir('src') {
                    bat 'dotnet build --configuration Release'
                }
            }
        }

        stage('Apply DB Migrations') {
            steps {
                bat 'cd database && rh.exe --s localhost --d EmployeeDB --u sa --p YourStrong!Passw0rd --a SQL --f .'
            }
        }
    }
}
