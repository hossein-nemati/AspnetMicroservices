# AspnetMicroservices
AspnetMicroservices


#run 
docker pull mongo  # in solution directory

#run
docker run -d -p 27017:27017 --name shopping-mongo mongo  # for create shopping-mongo container

or  check it with this command  => docker ps => docker ps -a    => then  => docker start (4 first letter)


#stop #remove   docker stop "4 digit"   docker rm "4 digit"

#run docker compose
docker-compose -f .\docker-compose.yml -f .\docker-compose.override.yml up -d

#check it 
docker ps # show running items

#run
docker exec -it shopping-mongo /bin/bash   # open a bash command line to mongodb container # for run mongodb command and access to mongodb 
   => then in opened bash run mongo command to access mongodb 

