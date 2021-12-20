# FacadeCoE
Ejercicio: Como ejercicio, vamos a dar los primeros pasos para escribir nuestra propia librería que acceda al servicio OpenWeatherMaps. En caso de que no estés familiarizado con el servicio OpenWeatherMap, es un servicio HTTP que te proporciona información en directo sobre el tiempo, así como datos históricos sobre el mismo. La API HTTP REST es muy fácil de usar, y será un buen ejemplo de cómo crear un patrón Facade para ocultar la complejidad de las conexiones de red detrás del servicio REST.

Criterios de aceptación: La API de OpenWeatherMap ofrece mucha información, así que vamos a centrarnos en obtener datos meteorológicos en una ciudad utilizando sus valores de latitud y longitud. A continuación, se detallan los requisitos y criterios de aceptación de este patrón de diseño:

1.	Proporcionar un tipo único para acceder a los datos. Toda la información recuperada del servicio OpenWeatherMap pasará a través de él.
2.	Crea una forma de obtener los datos meteorológicos de alguna ciudad de algún país.
3.	Crear una forma de obtener los datos meteorológicos para alguna posición de latitud y longitud.
4.	Sólo el segundo y tercer punto deben ser visibles fuera del paquete; todo lo demás debe estar oculto (incluyendo todos los datos relacionados con la conexión).

API: https://openweathermap.org/current/
