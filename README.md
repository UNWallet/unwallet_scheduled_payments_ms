#  UNWallet Scheduled Payments Microservice
## Fellhipe Lorenzzo Gutierrez Fonseca
- --
## Scheduled Payments Component

A .NET Core microservice using a Mongodb database that handles the registration, update, deletion and querying of scheduled payments in the context of an integrated system called UNWallet, which is an expenses and income tracking app.

Main functions that this service manage:

- Registry of scheduled payments.
- Management of scheduled payments.

# Cloning
1. Clone the repository using:
        https://github.com/FeGutierrez/UNWallet_scheduled_payments_ms.git
    
# Deployment Instructions
1. This microservice is composed of a dockerized MongoDB database and a dockerized .NET Core application. Therefore it will be necessary to first create a Docker network.
        docker network create sp_network
2. Create a Dockerfile in any location you wish and place the following contents inside:
        FROM mongo:latest
        ENV MONGODB_INITDB_ROOT_USERNAME=user
        ENV MONGODB_INITDB_ROOT_PASSWORD=1234
        EXPOSE 27017
3. Build the MongoDB container.
        docker build -t scheduled_payments_mongodb .
4. Run the MongoDB container.
        docker run --network=sp_network -d -t -i -p 27017:27017 --name scheduled_payments_mongodb scheduled_payments_mongodb
5. Build the Dockerfile located in the UNWallet_scheduled_payments_ms folder:
        docker build -t unwallet_scheduled_payments_ms:latest .
6. Run the microservice container:
        docker run --network=sp_network -p 5000:5000 -p 5001:5001 -e ASPNETCORE_HTTP_PORT=https://+:5001 -e ASPNETCORE_URLS=http://+:5000 --name=unwallet_scheduled_payments_ms unwallet-ms
        
# Accessing the microservice
        http://localhost:7051/ScheduledPayment
