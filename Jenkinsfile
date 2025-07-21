pipeline {
    agent any

    stages {
        stage('Clone Repository') {
            steps {
                git branch: 'master', url: 'https://github.com/Sanju2605/jenkinsass1.git'
            }
        }

        stage('Build .NET Project') {
            steps {
                dir('src') {
                    bat 'dotnet build'
                }
            }
        }

        stage('Apply DB Migrations') {
            steps {
                bat 'cd database && rh.exe --s localhost --d EmployeeDB --u sa --p YourStrong!Passw0rd --a SQL --f .'
            }
        }
    }

    post {
        success {
            echo '✅ Pipeline completed successfully.'
        }
        failure {
            echo '❌ Pipeline failed. Check console logs for errors.'
        }
    }
}
