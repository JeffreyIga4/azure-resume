# **Azure Cloud Resume Challenge** 🚀  

## **Overview**  
This project is a **full-stack, cloud-based resume** built as part of the **Cloud Resume Challenge (Azure Edition)**. It integrates **frontend, backend, cloud services, and CI/CD pipelines**, showcasing practical cloud engineering skills. The goal was to create a **serverless, scalable resume** with a visitor counter, demonstrating expertise in **Azure, .NET, and DevOps practices**.  

---

## **🚀 Technologies & Implementation**  

### **1️⃣ Frontend – Static Website with Visitor Counter**  
🛠 **Tech Used:**  
**HTML, CSS, JavaScript, Azure Blob Storage, Azure CDN**  

📌 **Implementation Details:**  
- Designed and updated the **frontend HTML/CSS** to create a professional resume.  
- Implemented a **visitor counter** using JavaScript, dynamically fetching data from an **Azure Function**.  
- Deployed the **static website to Azure Blob Storage** and optimized performance with **Azure CDN**.  
- Configured **caching** to improve load times and implemented **CDN purge** as part of CI/CD to update changes instantly.  

---

### **2️⃣ Backend – Serverless API with Azure Functions & CosmosDB**  
🛠 **Tech Used:**  
**C#, .NET Core 8.0, Azure Functions, Azure CosmosDB**  

📌 **Implementation Details:**  
- Developed an **Azure Function** in C# to handle visitor count retrieval and updates.  
- Integrated **Azure CosmosDB** as a **fully managed NoSQL database** to store visitor counts.  
- Used **Azure Functions Core Tools** to test the function **locally** before deployment.  

---

### **3️⃣ Cloud Deployment & Infrastructure**  
🛠 **Tech Used:**  
**Azure CLI, Azure Functions, Azure Blob Storage, Azure CDN**  

📌 **Implementation Details:**  
- Deployed the **Azure Function App** for seamless backend execution.  
- Configured **Azure Blob Storage** to host the **static site** and linked it with **Azure CDN** for global content delivery.  
- **Automated CDN purge** to ensure updated content is always served to visitors.  

---

### **4️⃣ CI/CD Pipeline – Automated Testing & Deployment**  
🛠 **Tech Used:**  
**GitHub Actions, Azure CLI, Unit Testing**  

📌 **Implementation Details:**  
- Developed **GitHub Actions workflows** to automate deployments for both **frontend and backend**.  
- Implemented **unit testing for the backend** to ensure API reliability.  
- Configured **CI/CD pipelines** to trigger deployments automatically on **code commits**.  


## **📌 Additional Resources**  
📖 **Cloud Resume Challenge Guide:** [cloudresumechallenge.dev](https://cloudresumechallenge.dev/docs/the-challenge/azure/)  
🎥 **Reference Video:** [Cloud Resume Challenge (Azure Edition)](https://youtu.be/ieYrBWmkfno?si=cc72xZxEcWkNytN0)  
