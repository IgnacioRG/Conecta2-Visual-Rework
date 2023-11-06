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

#### Nivel 5
- [x] Diamante
- [ ] Pentágono
- [ ] Casa
- [ ] Pirámide
- [ ] Árbol

#### Nivel 6
- [ ] Rectángulo Triángulo
- [ ] Flecha Derecha
- [ ] Hexágono
- [ ] Doble Triángulo
- [ ] Check

#### Nivel 7
- [ ] Diamante
- [ ] Pentágono
- [ ] Pirámide
- [ ] Árbol
- [ ] Caballo

#### Nivel 8
- [ ] Doble Triángulo
- [ ] Tren
- [ ] Check
- [ ] Árbol Aplanado
- [ ] Moto Acuatica

#### Nivel 9
- [ ] Techo
- [ ] Piso
- [ ] Tejas
- [ ] Corbata
- [ ] Barco

#### Nivel 10
- [ ] Patas
- [ ] Estrella
- [ ] Charco
- [ ] Canoa
- [ ] Tortuga

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
