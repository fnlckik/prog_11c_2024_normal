# Függvények, eljárások

## Függvények

1. Hozz létre egy függvényt, amely kiszámolja egy téglalap kerületét a két oldalából!

    Példa:
    ```cs
    Kerulet(3, 5) == 16
    Kerulet(1.25, 4) == 10.5
    ```

2. A `ParosE(n)` függvény döntse el, hogy a paraméterként kapott `n` egész szám páros vagy páratlan!

    Példa:
    ```cs
    ParosE(5) == false
    ParosE(162) == true
    ```

3. Írj függvényt, amely megadja egy egész számokat tartalmazó tömb elmeinek maximumát!
    
    Példa:
    ``` cs
    Max(new int[] {4, 7, -3, 12, 7, 14, -1}) == 14
    ```

---

## Eljárások

**Paraméterek típusai:**
<div align="center">

| Kulcsszó |      Név       | Kezdőérték? | Új érték?  |
| :------: | :------------: | :---------: | :--------: |
|    -     | érték szerinti | Kötelező ❗  |  Nincs ❌   |
|  `out`   |    kimeneti    |   Lehet ✅   | Kötelező ❗ |
|  `ref`   |  cím szerinti  | Kötelező ❗  |  Lehet ✅   |

</div>

4. Készíts `Kiir(s)` néven eljárást, amely paraméterként kap egy szöveget, majd sorsol egy random számot 3 és 9 között, és a szöveget annak megfelelő mennyiségű alkalommal jeleníti meg a konzolon!

5. Írj `Beolvas(n)` nevű eljárást, ami beolvassa az `n` egész típusú változó értékét, majd eltárolja azt! A fő program ezután kiírja a beolvasott érték négyzetgyökét a konzolra!

6. A `Duplaz(a)` eljárás megváltoztatja az `a` paramétere értékét a duplájára amennyiben az páratlan! (Páros esetén marad az eredeti érték.)

7. A `Novel(t)` eljárás a `t` tömb minden elemét növelje meg egyel! Programozd le!

---

## Számelmélet

8. Írj függvényt, amely egy `p` pozitív egész számról eldönti, hogy prímszám-e! Használd fel a függvényt arra, hogy egy számokat tartalmazó tömbből kiválogasd a prímszámokat!

    Példa:
    ``` cs
    Primszamok(new int[] {7, 23, 6, 42, 73, 2, 3, 9, 1, 5}) == {7, 23, 73, 2, 3, 5}
    ```

9. Adott egy egész számokat tartalmazó tömb. Készíts függvényt, amely megadja az első olyan elemét, amelynek legalább 20 osztója van!

    Példa:
    ```cs
    SokOsztos(new int[] {6, 1001, 48, 360, 75}) == 360
    ```