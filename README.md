# Carsties

## 🏗 Architecture Overview

<img width="1258" alt="image" src="https://github.com/user-attachments/assets/9d03f2dd-1fb5-464a-9ded-5b2aec1b75b5" />

---

## 🧰 Tech Stack

- **.NET Core** – Backend APIs & services
- **Docker** – Containerization  
- **Kubernetes** – Orchestration (production)  
- **Nginx** – Reverse proxy & load balancing  
- **RabbitMQ** – Messaging broker  
- **gRPC** – High-performance RPC communication  
- **Duende IdentityServer** – Authentication & authorization
- **SignalR** - For Push Notifications
- **NextJS** 
- **Zustand**
- **PostgreSQL**
- **MongoDB**

---

## 🚀 Getting Started (Local Development)

### 1. Clone the Repository

```bash
git clone https://github.com/a-ghanem1/Cars-Auctions-Microservices.git
cd Carsties-2024
```

---

### 2. Prerequisites

- [Docker Desktop](https://www.docker.com/products/docker-desktop)
- [mkcert](https://github.com/FiloSottile/mkcert)

---

### 3. Build Docker Services

```bash
docker compose build
```

---

### 4. Run the Application

```bash
docker compose up -d
```

---

### 5. Configure Local SSL Certificates

#### Install mkcert CA

```bash
mkcert -install
```

#### Generate Certificates

```bash
cd devcerts
mkcert -key-file carsties.local.key -cert-file carsties.local.crt app.carsties.local api.carsties.local id.carsties.local
```

---

### 6. Update Your Hosts File

Add the following line:

```
127.0.0.1 id.carsties.local app.carsties.local api.carsties.local
```
---

### 7. Access the Application

Open [https://app.carsties.local](https://app.carsties.local) in your browser.
