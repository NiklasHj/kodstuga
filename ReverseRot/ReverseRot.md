# Reverse Rot

## Uppgift

### https://open.kattis.com/problems/reverserot

### Dock ej flera rader!
</br>

## Kända Värden/Krav
</br>

### Input

Raden skall bestå av ett tal och ett meddelande separerat med ett mellanslag. </br>
Talet ska vara mellan 1 och 27. </br>
Meddelandet ska vara mellan 1 och 40. </br>
Meddelandet får endast bestå av dessa tecken"ABCDEFGHIJKLMNOPQRSTUVWXYZ_." </br>

### Output

Output ska vara meddelandet med dess tecken förflyttade så många steg som är angivet.
Innan man skriver ut meddelandet skall det vändas på.

## Algoritm

1. Läs in en rad från användaren
2. Kontrollera input
3. Separera talet och meddelandet
4. Se till att talet är ett tal
5. Leta upp positionen för varje tecken i meddelandet
    5a. Beräkna den nya positionen
    5b. Byt ut tecknet mot tecknet på nya position
    5c. Spara i ett resultat
6. Vänd på resultatet
7. Skriv ut resultatet