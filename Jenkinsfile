pipeline {
  agent {
    docker {
      image 'mcr.microsoft.com/dotnet/core/sdk:3.1'
    }

  }
  stages {
    stage('Restore') {
      parallel {
        stage('Restore') {
          steps {
            sh 'dotnet restore'
          }
        }

        stage('install nodejs') {
          steps {
            sh 'apt-get install nodejs'
          }
        }

      }
    }

    stage('Clean') {
      steps {
        sh 'dotnet clean'
      }
    }

    stage('Build') {
      steps {
        sh 'dotnet build -c Release'
      }
    }

    stage('Publish') {
      steps {
        sh 'dotnet publish -c Release'
      }
    }

    stage('error') {
      steps {
        sh 'ls NetCoreWithAngularTemplate/bin/release/netcoreapp3.1/publish'
      }
    }

  }
  environment {
    HOME = '/tmp'
  }
}