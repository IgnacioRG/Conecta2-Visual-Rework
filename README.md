# Proyecto de Servicio Social [REWORK Visual Conecta2]

## Introducción
El juego Conectados presenta al jugador una secuencia de aparición de líneas que este debe replicar en el orden especificado para formar la figura final.

## Proyecto
Para el rework visual aumentaremos el tamaño de las líneas que forman las figuras, ya que actualmente son muy pequeñas y dificultan su control. También se modifican otros parámetros que van de la mano con el tamaño, como el Box Collider, la posición de las figuras desplegadas, las zonas de spawn, etc.

### Estructura del Juego
El juego se compone de 12 niveles, cada uno de ellos tiene un número de figuras posibles (contando con sus respectivos moldes guía). Además, contamos con distractores en algunos de estos niveles que solo contienen líneas falsas para aumentar la dificultad. Se presenta la lista de figuras y cuáles de ellas ya han sido modificadas con un tamaño mas optimo:

#### Nivel 1 (COMPLETADO :D)
- [x] Triángulo
- [x] Triángulo Rectángulo
- [x] Banco
- [x] Flecha Derecha
- [x] Sombrero

#### Nivel 2 (COMPLETADO :D)
- [x] Cuadrado
- [x] Rombo
- [x] Rectángulo Inclinado
- [x] Trapecio
- [x] Bandera

#### Nivel 3 (COMPLETADO :D)
- [x] Triángulo
- [x] Triángulo Rectángulo
- [x] Banco
- [x] Flecha Derecha
- [x] Sombrero

#### Nivel 4 (COMPLETADO :D)
- [x] Trapecio
- [x] Bandera
- [x] Triángulo Partido
- [x] Cristal
- [x] Montaña

#### Nivel 5 (COMPLETADO :D)
- [x] Diamante
- [x] Pentágono
- [x] Casa
- [x] Pirámide
- [x] Árbol

#### Nivel 6 (COMPLETADO :D)
- [x] Rectángulo Triángulo
- [x] Flecha Derecha
- [x] Hexágono
- [x] Doble Triángulo
- [x] Check

#### Nivel 7 (COMPLETADO :D)
- [x] Diamante
- [x] Pentágono
- [x] Pirámide
- [x] Árbol
- [x] Caballo

#### Nivel 8 (COMPLETADO :D)
- [x] Doble Triángulo
- [x] Tren
- [x] Check
- [x] Árbol Aplanado
- [x] Moto Acuatica

#### Nivel 9 (COMPLETADO :D)
- [x] Techo
- [x] Piso
- [x] Tejas
- [x] Corbata
- [x] Barco

#### Nivel 10
- [x] Patas
- [x] Estrella
- [x] Charco
- [x] Canoa
- [x] Tortuga

#### Nivel 11
- [ ] Tri-Triángulo
- [ ] Sombrilla
- [ ] Corbata
- [ ] Barco
- [ ] Interruptor

#### Nivel 12
- [ ] Charco
- [ ] Canoa
- [ ] Megáfono
- [ ] Trompo
- [ ] Tortuga

#### Distractores
- [ ] Nivel 4
- [ ] Nivel 5 y 6
- [ ] Nivel 7 y 8
- [ ] Nivel 9 y 10
- [ ] Nivel 11 y 12

## Registro de Actividades

### 31-10-23
Se empezó a realizar el redimensionamiento para los niveles 1,2,3 y 4. Algunas figuras parecen tener un problema con el Box Collider, por lo que es posible que se restaure la escena a la versión del Archive. Se volverán a redimensionar las figuras.

### 6-11-23
Se realizaron los cambios deseados a los niveles 1,2,3 y 4. Se probó la ejecución correcta del juego con los nuevos cambios. Se decidió por cambiar cada figura manualmente en lugar de usar el Script ya que muchas figuras presentaban errores al cambiar automáticamente la BoxCollider.

### 7-11-23
Se realizaron los cambios deseados satisfactoriamente a los niveles 5,6 y 7. Se terminó casi el nivel 8, sin embargo, este parece tener un bug con las figuras de lancha y árbol aplanado, se confirmó que en la versión Archive también está presente este error.

### 8-11-23
Se relaizaron los cambios deseados satisfactoriamente a los nivles 8,9 y 10, se corrigio el error antes docuemntado caambiando la posicion de los elementos de la escena en la coordenada z.
