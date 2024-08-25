pipeline {
	agent any
	environment {
		COMPOSE_FILE = 'docker-compose.yml'
	}
		stage ('Verify') {
			steps {
				sh '''
					docker version
					docker-compose version
				'''
			}
		}
		stage('clean') {
		steps {
		sh 'sh dockerclean.sh'
		}
		}
		stage ('build') {
			steps {
				sh 'docker-compose build'
			}
		}

		stage('Deploy') {
			steps {
				sh 'docker-compose kill'
				sh 'docker-compose up -d --remove-orphans'
			}
		}

	}
}
