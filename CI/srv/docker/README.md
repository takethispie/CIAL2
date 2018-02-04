#all the steps needed to get the CI server working
sudo systemctl start docker

sudo docker-compose up -d

open localhost:8080

proceed through first install (choose integrated database, accept licence and create an admin account)

create a now project

choose github and follow the instructions to add an oauth
identification on github

let teamcity auto detect build step 
there should be restore, build steps for AgendManager
and restore, test for AgendaManagerTest

go to agent -> authorize all agents

