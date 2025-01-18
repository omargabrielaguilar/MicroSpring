# Prueba Técnica: Sistema de Gestión de Pedidos de una Tienda Online (Microservicios)

## **Objetivo**
Crear una API backend utilizando .NET Core, siguiendo principios sólidos de arquitectura de software, patrones de diseño y buenas prácticas. Implementar microservicios, pruebas unitarias y contenedores Docker. El sistema debe permitir la creación y gestión de pedidos, con un enfoque en la escalabilidad y el mantenimiento.

---

## **Requerimientos Funcionales**

### **Microservicios**
1. **Servicio de Clientes:**
    - Manejo de datos de los clientes (nombre, dirección, teléfono, etc.).

2. **Servicio de Productos:**
    - Manejo de productos disponibles en la tienda (nombre, descripción, precio, stock).

3. **Servicio de Pedidos:**
    - Crear, ver y actualizar pedidos, asociando productos y clientes.

4. **Servicio de Pagos:**
    - Manejo de pagos, integrando una API externa simulada para la validación de pagos.

5. **API de Comunicación:**
    - Los microservicios deben comunicarse mediante APIs RESTful y mensajería asíncrona (puedes usar **RabbitMQ** o **Kafka**).
    - El servicio de pedidos debe notificar al servicio de pagos cuando se crea un pedido.

---

### **Persistencia**
1. Utilizar bases de datos **SQL** o **NoSQL** según el servicio.
2. Cada servicio debe ser autónomo y no depender de una base de datos compartida.
3. Implementar patrones como **Event Sourcing** o **CQRS** para garantizar consistencia de datos.

---

### **Seguridad**
1. Implementar **autenticación y autorización** usando **JWT** (JSON Web Token).
2. Encriptar información sensible, como los datos del cliente y del pago.

---

### **Pruebas Unitarias**
1. Implementar pruebas unitarias para las funciones críticas de cada microservicio.
2. Usar **xUnit** o **NUnit** para las pruebas unitarias.
3. Crear mocks de dependencias utilizando bibliotecas como **Moq**.

---

### **Dockerización**
1. Cada microservicio debe estar contenido en su propio contenedor Docker.
2. Utilizar **Docker Compose** para orquestar los contenedores de todos los microservicios y la base de datos.
3. Implementar un contenedor para el sistema de mensajería (**RabbitMQ** o **Kafka**).
4. Documentar cómo levantar el sistema utilizando Docker.

---

### **Patrones de Diseño**
1. **Repository Pattern** para la abstracción de la base de datos.
2. **Factory Pattern** para la creación de objetos de negocio.
3. **Singleton Pattern** para la gestión de configuraciones globales.
4. **Observer Pattern** para la comunicación entre microservicios mediante eventos o colas.

---

### **Escalabilidad**
1. El sistema debe ser **escalable horizontalmente**.
2. Asegúrate de que el sistema pueda manejar múltiples instancias de los microservicios sin afectar el rendimiento.

---

## **Documentación**
1. Proporcionar documentación clara para:
    - Ejecutar el sistema.
    - Probar el sistema.
2. Incluir ejemplos de cómo consumir las APIs.
3. Explicar la arquitectura, los patrones utilizados y justificar las decisiones tomadas.

---

## **Requerimientos Técnicos**
- **Backend:** .NET Core 6 o superior.
- **Base de Datos:** SQL o NoSQL (puedes elegir según el servicio).
- **Docker:** Cada microservicio debe ser ejecutado en su propio contenedor Docker.
- **Mensajería:** RabbitMQ o Kafka (elige uno para la comunicación entre microservicios).
- **Pruebas:** Unitarias con xUnit/NUnit y Moq.
- **Patrones de Diseño:** Repository, Factory, Singleton, Observer.

---

## **Entrega**
1. **Repositorio en GitHub:**
    - Incluir el código fuente del proyecto.
    - Añadir un archivo `README.md` con instrucciones de instalación y uso.
2. **Documentación de Arquitectura:**
    - Crear un archivo en formato Markdown explicando:
        - La arquitectura del sistema.
        - La elección de patrones de diseño.
        - La justificación de las decisiones tomadas.

---

## **Desafíos Adicionales**
1. **Escalabilidad y Tolerancia a Fallos:**
    - Implementar estrategias como **Circuit Breakers** o **Retries** para manejar fallos en los microservicios.

2. **Consistencia Eventual:**
    - Si decides usar **CQRS** o **Event Sourcing**, explicar cómo manejas la consistencia eventual entre los microservicios.

3. **Despliegue y Monitoreo:**
    - Proponer cómo desplegar y monitorizar el sistema en un entorno de producción real.

---

## **Tiempo Estimado**
- **Tiempo mínimo:** 2-3 días para la implementación básica.
- **Tiempo máximo:** 1 semana para una implementación completa con optimizaciones avanzadas, pruebas exhaustivas y documentación detallada.

---

