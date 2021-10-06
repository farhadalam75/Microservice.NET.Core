# Microservice.NET.Core
Create a micro service using ASP.NET Core  // EF Core DbContext, Repository, Docker



### Microservices
The term microservices portrays a software development style that has grown from contemporary trends to set up practices that are meant to increase the speed and efficiency of developing and managing software solutions at scale. Microservices is more about applying a certain number of principles and architectural patterns as architecture. Each microservice lives independently, but on the other hand, also all rely on each other. All microservices in a project get deployed in production at their own pace, on-premise on the cloud, independently, living side by side. In this tutorial, learn how to build a microservice using ASP.NET and build, deploy, and test it using a docker container.

### Microservices Architecture

There are various components in a microservices architecture apart from microservices themselves.

**Management** Maintains the nodes for the service.

**Identity Provider** Manages the identity information and provides authentication services within a distributed network.

**Service Discovery** Keeps track of services and service addresses and endpoints.

**API Gateway** Serves as client’s entry point. Single point of contact from the client which in turn returns responses from underlying microservices and sometimes an aggregated response from multiple underlying microservices.

**CDN** A content delivery network to serve static resources for e.g. pages and web content in a distributed network

**Static Content** The static resources like pages and web content

Microservices are deployed independently with their own database per service so the underlying microservices look like >>> (Model, Business Logic, and Repositories + Database) as a service

### Docker Containers and Docker installation
Containers like Dockers and others slice the operating system resources, for e.g. the network stack, processes namespace, file system hierarchy and the storage stack. Dockers are more like virtualizing the operating system. Learn more about dockers [here](https://www.docker.com/resources/what-container). Open [this ](https://docs.docker.com/docker-for-windows/install/)URL and click on Download from Docker hub. Once downloaded, login to the Docker and follow instructions to install Docker for Windows.

### Monolithic vs Microservices Architecture
_Monolithic applications_ are more of a single complete package having all the related needed components and services encapsulated in one package.
_Microservice_ is an approach to create small services each running in their own space and can communicate via messaging. These are independent services directly calling their own database.
