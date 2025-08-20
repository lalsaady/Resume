<p align="center"><img alt="my-cat-chai" src="chai.png" height="200" /></p>

# Terminal Resume App
This is a dockerized ASP.NET Core web app for displaying my resume in an interactive way.
It is hosted with Render at [https://resume-mvmw.onrender.com](https://resume-mvmw.onrender.com).  
I am waiting on my custom domain [https://laysterminal.site](https://laysterminal.site) to register.

# Technologies Used
- .NET 9
- Entity Framework Core (SQLite)
- Docker
- HTML, CSS, JavaScript

# Running locally
1. Build the docker image from root of this directory
```
docker build -t resume-app .
```
2. Run the container
```
docker run -p 8080:8080 resume-app
```
3. View the website at http://localhost:8080/

