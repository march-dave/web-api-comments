# web-api-comments app
A simple web api call comments

## Instructions
1.  Get     /api/comments
2.  Post    /api/comments
3.  Delete  /api/comments{id}

## Deploying the web app to Azure 
1. BackEnd url: https://api-comments.azurewebsites.net/swagger/ui/index
2. FrontEnd url: https://api-commentsfe.herokuapp.com/ 

## Todo 
what will happen if this is used in a scenario where you get millions of requests? 
1. Use Asynchronous which means not block call from service all and also better server as well as use caching service. When service call same as previousily not necessary use service layer.
2. Stored Proceduce is one of the soultions, which is already compiled server side ready to service
