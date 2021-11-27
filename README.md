# AspnetMicroservices
AspnetMicroservices


#run 
docker pull mongo  # in solution directory

#run
docker run -d -p 27017:27017 --name shopping-mongo mongo  # for create shopping-mongo container

#check it 
docker ps # show running items

#run
docker exec -it shopping-mongo /bin/bash   # open a bash command line to mongodb container # for run mongodb command and access to mongodb 
   => then in opened bash run mongo command to access mongodb 