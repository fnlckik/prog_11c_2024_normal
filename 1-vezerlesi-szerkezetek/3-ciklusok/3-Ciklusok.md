# 3. Ciklusok

1. **Négyzetszám.** Olvass be egy $n$ pozitív egész számot, majd

    a. írd ki az első $n$ négyzetszámot; `0 1 4 9 16`

    b. írd ki $n$-ig a négyzetszámokat! `0 1 4`

2. **Osztók.** Olvass be egy pozitív egész számot, majd határozd meg az osztóit!

    Csinálj **előfeltétel tesztelést**, vagyis ellenőrizd a beolvasott számot! Csak pozitív számokat fogadj el! (Feltehető, hogy egész számot ad meg a felhasználó.)

    ```
    12 => 1 2 3 4 6 12
    ```

3. **Hatvány.** Határozzuk meg egy valós szám pozitív egész kitevős hatványát!

    *Emlék:* $a^n = a\cdot a\cdot \ldots \cdot a$

4. **Csengetés.** Egy iskolában az első tanóra 8:00-kor kezdődik. Minden óra 45 perc és minden szünet 10 perces. Írjuk ki, hogy mikor lesz a diákok első 8 órája!

    ```
    1. óra: 08:00 - 08:45
    2. óra: 08:55 - 09:40
    ...
    8. óra: 14:25 - 15:10
    ```

5. **Kocka.** Szimulálj kocka dobásokat (véletlen számok generálásával)!

    a. Olvasd be a felhasználótól, hogy hányszor dobunk a kockával!

    b. Addig dobj a kockával, amíg 6-ost nem kapunk!

6. **Érme.** Szimuláljunk érme dobásokat!

    a. Az érmét 50-szer dobjuk fel! Írd ki a fej (F) és írás (I) értékeket, majd jelezd azt is, hogy melyikből hány darab volt!

    b. Addig dobáljuk az érmét, amíg nem kapunk egymás után 4 írást! Jelenítsd meg a dobások eredményeit!

7. **Páratlan.** Generáljunk egy 7 számjegyű számot, amelynek minden jegye páratlan! Az összes lehetőség valószínűsége egyforma legyen!

    ```
    Minta: 3191137
    ```

8. **Prímszám.** Döntsd el egy pozitív egész számról, hogy prímszám-e!

9.  **Számrendszer.** Írjunk programot, amely egy 10-es számrendszerben megadott számot 2-es számrendszerbe vált át!

    ```
    5 => 101
    22 => 10110
    1456 => 10110110000
    ```

10. **Euklideszi.** Határozzuk meg Euklideszi-algoritmus segítségével két pozitív egész szám legnagyobb közös osztóját (lnko) és legkisebb közös többszörösét (lkkt)!

    **Euklideszi-algoritmus:**

    | LNKO |
    | :-: |
    | $a = q_1 \cdot b + r_1$ |
    | $b = q_2 \cdot r_1 + r_2$ |
    | $r_1 = q_3 \cdot r_2 + r_3$ |
    | $\ldots$ |
    | $r_{n-2} = q_{n} \cdot r_{n-1} + r_{n}$ |

    Ha $r_n = 0$ akkor $r_{n-1}$ a legnagyobb közös osztó.

    *Vagyis végezzük el maradékos osztások sorozatát, amíg a maradék 0 lesz.*

    ```
    120 108 => 12
    504 6860 => 28
    ```
