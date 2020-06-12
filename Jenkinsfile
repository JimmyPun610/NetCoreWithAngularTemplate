pipeline {
  agent {
    dockerfile {
      filename 'DotNetNodeJS.Dockerfile'
    }

  }
  stages {
    stage('Restore') {
      steps {
        sh 'dotnet restore'
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

    stage('Check') {
      steps {
        sh 'ls NetCoreWithAngularTemplate/bin/Release/netcoreapp3.1/publish/'
      }
    }

  }
  environment {
    HOME = '/tmp'
  }
}