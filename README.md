# ClienteUDP

## Introducción

Bienvenido a **ClienteUDP**, una implementación de un cliente UDP en C# para enviar y recibir mensajes a un servidor UDP.

## Características

- Se conecta a un servidor UDP y envía y recibe mensajes.
- Puede ser utilizado para crear aplicaciones de cliente que requieren comunicación UDP.

## Uso

1. Crea una instancia de la clase `ClienteUDP` y pasa la dirección IP y el puerto del servidor UDP como parámetros.
2. Conecta al servidor llamando al método `ConectarAlServidor`.
3. Envía mensajes al servidor llamando al método `EnviarMensaje`.
4. Recibe mensajes del servidor llamando al método `RecibirMensaje`.

## Ejemplo

```csharp
string direccionIP = "127.0.0.1";
int puerto = 6789;
ClienteUDP clienteUDP = new ClienteUDP(direccionIP, puerto);
clienteUDP.ConectarAlServidor();
clienteUDP.EnviarMensaje("Hola, servidor!");
string mensaje = clienteUDP.RecibirMensaje();
```

## Licencia
Este proyecto está bajo la licencia MIT. ¡Libre de usar y modificar!

## Agradecimientos
¡Muchas gracias por utilizar ClienteUDP! 😊

## Autores
- Carlos Daniel Juarez Castillon
- Eduardo Robles Ruezga
- Emilio Alejandro Morales Bautista
- Aarón Flores Pasos
