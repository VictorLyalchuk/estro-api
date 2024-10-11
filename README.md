# Estro

Create docker hub repository - publish
```
docker build -t estro-api . 
docker run -it --rm -p 5088:8080 --name estro_container estro-api
docker run -d --restart=always --name estro_container -p 5088:8080 estro-api
docker run -d --restart=always -v d:/volumes/estro/uploads:/app/wwwroot/uploads -v d:/volumes/estro/email:/app/wwwroot/email --name estro_container -p 5088:8080 estro-api
docker run -d --restart=always -v /volumes/estro/uploads:/app/wwwroot/uploads -v /volumes/estro/email:/app/wwwroot/email --name estro_container -p 5088:8080 estro-api
docker ps -a
docker stop estro_container
docker rm estro_container

docker images --all
docker rmi estro-api

docker login
docker tag estro-api:latest novakvova/estro-api:latest
docker push novakvova/estro-api:latest

docker pull novakvova/estro-api:latest
docker ps -a
docker run -d --restart=always --name estro_container -p 5088:8080 novakvova/estro-api

docker run -d --restart=always -v /volumes/estro/uploads:/app/wwwroot/uploads -v /volumes/estro/email:/app/wwwroot/email --name estro_container -p 5088:8080 novakvova/estro-api


docker pull novakvova/estro-api:latest
docker images --all
docker ps -a
docker stop estro_container
docker rm estro_container
docker run -d --restart=always --name estro_container -p 5088:8080 novakvova/estro-api
```

```nginx options /etc/nginx/sites-available/default
server {
    server_name   api-estro.itstep.click *.api-estro.itstep.click;
    location / {
       proxy_pass         http://localhost:5088;
       proxy_http_version 1.1;
       proxy_set_header   Upgrade $http_upgrade;
       proxy_set_header   Connection keep-alive;
       proxy_set_header   Host $host;
       proxy_cache_bypass $http_upgrade;
       proxy_set_header   X-Forwarded-For $proxy_add_x_forwarded_for;
       proxy_set_header   X-Forwarded-Proto $scheme;
    }
}

server {
		server_name   qubix.itstep.click *.qubix.itstep.click;
		root /var/dist;
		index index.html;

		location / {
			try_files $uri /index.html;
			#try_files $uri $uri/ =404;
		}
}

server {
		server_name   admin-qubix.itstep.click *.admin-qubix.itstep.click;
		root /var/admin-qubix.itstep.click;
		index index.html;

		location / {
			try_files $uri /index.html;
			#try_files $uri $uri/ =404;
		}
}

sudo systemctl restart nginx
certbot
```

/var/api-qubix.itstep.click/