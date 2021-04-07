# Cars

Example application launch:

1. Launch cmd and change directory to your project

2. Build:
docker build -t carsappimage .    

3. Once u have built your application you can run it:
docker run -d -p 8080:80 --name cars carsappimage

4. Launch browser under http://localhost:8080 url