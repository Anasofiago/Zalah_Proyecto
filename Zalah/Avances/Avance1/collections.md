# Justificación de Colecciones – Proyecto Zalah

## Colecciones implementadas

---

### 1. `List<Cliente>` — Listado general de clientes

**¿Dónde se usa?**  
En el método `GetAll()` del `ClienteRepository`, el cual retorna todos los clientes de la base de datos como una lista en memoria.

**¿Por qué `List`?**  
- Permite acceso indexado (`lista[i]`) y es compatible con `DataGridView` mediante `DataSource`.  
- Admite operaciones de búsqueda y filtrado con LINQ (`.Where()`, `.FirstOrDefault()`, etc.).  
- Su tamaño es dinámico, por lo que no necesitamos saber de antemano cuántos clientes hay.  
- Es la estructura más natural para representar un conjunto de registros de base de datos en C#.

---

### 2. `Stack<string>` — Historial de acciones / Deshacer

**¿Dónde se usa?**  
En `ClienteRepository`, cada vez que se ejecuta un `Insert`, `Update` o `Delete`, la acción se apila en el `Stack`. Los métodos `VerUltimaAccion()` y `DeshacerUltimaAccion()` permiten consultar y revertir el historial.

**¿Por qué `Stack`?**  
- El Stack sigue la política **LIFO (Last In, First Out)**: la última acción realizada es la primera en deshacerse, que es exactamente el comportamiento esperado en un sistema de deshacer (Ctrl+Z).  
- `Push()` agrega en O(1), `Pop()` elimina el tope en O(1) y `Peek()` consulta sin modificar en O(1): todas las operaciones críticas son eficientes.  
- Refleja naturalmente una "pila de historial" donde el pasado más reciente está encima.

**Ejemplo de flujo:**
```
Acción 1: INSERT Juan   → Stack: [INSERT Juan]
Acción 2: UPDATE Juan   → Stack: [UPDATE Juan | INSERT Juan]
Deshacer                → Stack: [INSERT Juan]  (UPDATE Juan fue retirado)
```

---

### 3. `Queue<Cliente>` — Fila de atención al cliente

**¿Dónde se usa?**  
En `ClienteRepository`, los métodos `AgregarAFila()` y `AtenderSiguienteCliente()` gestionan la fila de atención. El cliente que llega primero es el primero en ser atendido.

**¿Por qué `Queue`?**  
- La Queue sigue la política **FIFO (First In, First Out)**: el primero en llegar es el primero en ser atendido, que es la lógica correcta para cualquier sistema de filas o turnos.  
- `Enqueue()` agrega al final en O(1) y `Dequeue()` retira el frente en O(1), lo que la hace eficiente para sistemas de alta concurrencia.  
- `Peek()` permite ver quién es el próximo sin modificar la fila, útil para pantallas de "turno actual".

**Ejemplo de flujo:**
```
Llega María   → Fila: [María]
Llega Pedro   → Fila: [María, Pedro]
Llega Ana     → Fila: [María, Pedro, Ana]
Atender       → Fila: [Pedro, Ana]   (María fue atendida)
```

---

## Resumen comparativo

| Colección       | Política | Uso en el proyecto               | Operaciones clave            |
|-----------------|----------|----------------------------------|------------------------------|
| `List<Cliente>` | Índice   | Resultados de consultas (GetAll) | Add, [], LINQ                |
| `Stack<string>` | LIFO     | Historial / Deshacer acciones    | Push, Pop, Peek              |
| `Queue<Cliente>`| FIFO     | Fila de atención al cliente      | Enqueue, Dequeue, Peek       |

Cada colección fue elegida porque su comportamiento inherente coincide exactamente con el problema que resuelve, sin necesidad de lógica adicional para mantener el orden correcto de los elementos.
