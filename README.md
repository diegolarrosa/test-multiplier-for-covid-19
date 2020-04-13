# test-multiplier-for-covid-19


Es un método para multiplicar los test del virus Covid-19




Los test para el Covid-19 están tomando una gran importancia a nivel mundial, sobre todo cuando tenemos un caso de éxito como el de Corea del Sur, el cual realizó test masivos consiguiendo detener la propagación del virus, sin embargo no todos los países están preparados para realizar tantos test, y cuando lo realizan no es en forma óptima.
El Covit-19 se propaga tan velozmente por dos motivos, el primero es la capacidad de contagio, y el otro es gracias a la gran cantidad de casos asintomáticos, los que son portadores y no reportan síntomas.
En general, como los test son escasos, terminan tomando la decisión de testear solo a los que presentan síntomas graves, con lo cual dejan sin testear los casos asintomáticos,  que son realmente los que propagan el virus.
El método de multiplicador de test sirve especialmente para detectar los casos asintomáticos, así detener la propagación, ya que un caso detectado a tiempo lograría que esa persona no siga propagando el virus, si es que se toman las medidas correspondientes. Se puede multiplicar por cien o más veces dependiendo del nivel de contagio general de la población afectada y la estrategia de test elegida.




## Multiplicando por 100 la cantidad de test

Se toman tres muestras independientes por cada persona testeada (teniendo en cuenta como una muestra como un test estándar, en caso de que el protocolo normal requiera más de una muestra) en la primera muestra se usa como muestra estándar, la cual no se utiliza hasta el final del procedimiento. La segunda muestra se utiliza para contaminar un recipiente con diez muestras de otras personas, de ésta forma estamos testeando diez personas al mismo tiempo, tampoco se utiliza hasta terminar el primer procedimiento.  La tercera muestra es el primer procedimiento, y consiste en contaminar un recipiente con cien muestras de otras personas, y a esto realizar el testeo correspondiente.
El primer paso es contaminar un recipiente con cien muestras, y realizar el test correspondiente, si el testeo da negativo, no se realizan los siguientes testeos, y las muestras se desechan, con lo cual da una ganancia o ahorro de 99 test, en cambio si el test da positivo se realiza el siguiente paso, que consiste en realizar diez testeos con las diez segundas muestras correspondientes a los cien test anteriores. Si en alguno de esos diez test da positivo, se pasa al siguiente paso, el cual consiste en realizar el testeo correspondiente al grupo de diez test que dieron positivo con la primera muestra. De ésta forma se podría ahorrar muchos testeos, con el inconveniente de la prolongación del tiempo del test, sin embargo en la práctica esto no es del todo cierto, ya que los tiempos de testeos generalmente se prolongan gracias a la saturación por la gran cantidad de testeos en cola de espera, y si se resuelven en grupos, podría incluso ser mucho más rápido aplicar el método de testeos por multiplicación.




## Tiempos de testeo

Teniendo en cuenta un caso a testear, el tiempo es el triple que un método estándar, sin tener en cuenta el tiempo de transporte, además se agrega el tiempo de contaminación en un recipiente por cada etapa, para la multiplicación de cien test se requieren dos etapas de contaminación en recipiente.




## Efectividad de la multiplicación

El método es muy efectivo con cierto grupo de gente, que son especialmente los que no presentan síntomas, ya que cuanto menor sea el número de infectados, más eficiente va a ser el método. En caso de encontrar una población muy infectada, es necesario disminuir la multiplicación de las muestras de diez a cinco, de esa forma mejorar la eficiencia. También se puede optar por aumentar el número de etapas para lograr abarcar mayor cantidad de casos testeados.




## Experimentación de la contaminación de muestras

Se requiere una técnica que permita contaminar un recipiente con los hisopos correspondientes a las muestras de cada individuo. En la experimentación se requiere saber el tiempo requerido para que la contaminación haga efecto, y también la sustancia necesaria para hacer de base y recibir tal contaminación.




## Datos importantes a tener en cuenta

1-	Es importante hacer éste tipo de test a todos los que circulan, y especialmente a los encargados de distribuir suministros, de ésta forma se puede frenar la propagación de los asintomáticos.

2-	Elegir un número de multiplicación acorde a la cantidad de infectados que se presume en esa región, a muchos infectados menor el número de multiplicación.

3-	Elegir la cantidad de etapas de multiplicación, si se requieren muchos test, hay que tener más etapas, teniendo en cuenta que cuanto más etapas exista mayor será la complejidad del sistema, además del aumento del tiempo de testeo.

4-	Reservar un porcentaje de test de multiplicación, por ejemplo un 30% de test para multiplicación, el resto de test se puede utilizar de la misma forma que  se viene utilizando hasta ahora.




## Test rápidos

El tipo de test utilizados para aplicar el método de multiplicación, no necesariamente tiene que ser del tipo rápido, si es necesario que cuente con un porcentaje de efectividad bueno.




## Conclusiones

Al aumentar la cantidad de test no solo se aumenta la eficiencia, sino que en algunos casos se puede atacar el efecto de los asintomáticos por primera vez. En muchos países se opta por confinamientos sociales muy estrictos, lo que lleva a una caía económica, al poder identificar los casos asintomáticos se podría disminuir el confinamiento social.





## Simulación de búsqueda de contagios mediante test:

Es un programa de computadora de código abierto, en el cual se pueden simular distintos escenarios de contagio y de estrategias de multiplicación de test. Se puede optar por ejecutar el programa ya compilado, o compilar el código.
Primero se tiene que determinar cuántos casos asintomáticos podrían existir por millón de habitantes. También existe la posibilidad de modificar la cantidad de simulaciones, que por defecto es 1000.
Por último se determina la multiplicación de test, por ejemplo 10x10, 20x20, 30x30, etc.





## Análisis de resultados de la simulación:

Los resultados varían de acuerdo a la cantidad de infectados por millón de habitantes, que en el caso de la Argentina a la fecha 13/04/2020 tiene 2200 contagiados probados, con eso se puede deducir que existen 220 casos por millón de habitantes (sumados los posibles asintomáticos).
El cálculo es el siguiente:
(2200 x 1.5 x 3 x 1000000) / 45000000 = 220
Donde 1.5 es el factor no detectado, 3 es por el porcentaje de asintomáticos, 1000000 es para tener la cifra en función del millón de habitantes, y 45 millones es la cantidad de habitantes de la Argentina.
En base a esto tomando como ejemplo tres pruebas, cada una con 10 mil simulaciones, obtuve los siguientes resultados:

10 x 10 -> Eficiencia:  98,56%

20 x 20 -> Eficiencia:  98,82%

30 x 30 -> Eficiencia:  98,66%

Por lo tanto 20 x 20 parece ser la configuración de test más eficiente, sin embargo se tendrían que combinar 400 muestras, esto puede resultar un inconveniente, ya que no difiere demasiado con el resultado que dio 10 x 10, el cual solo se tienen que combinar 100 muestras.





## Poner en funcionamiento el testeo:

Para llevar a cabo el testeo masivo por multiplicación,  se tienen que tomar al menos tres muestras por persona, esas muestras tienen que estar identificadas, para poder contactar a la persona afectada una vez que se tiene el resultado, esto ya se realiza con el testeo común.
Cuando las muestras llegan al laboratorio, se toma la decisión de los factores de multiplicación, se puede adoptar una política común, como por ejemplo 10 x 10. Luego se realiza el procedimiento ya descripto.



