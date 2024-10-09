# 1. Statikus tömbök

- Azonos típusú elemek sorozata
- Indexelhető (0-tól)
- Mérete fix (fordítási időben tudni kell)

## Deklaráció
```cs
int[] tomb = new int[5];
// vagy
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
```

## Feladatok

0. **Gyümölcsök.** Tárold el 3 gyümölcs nevét egy tömbben, majd írasd ki őket a konzolra
   
   a. egyesével

   b. ciklus használatával

1. **Jegyek.** Deklarálj egy 16 elemű tömböt, majd generálj bele random osztályzatokat! Utána írasd is ki őket egymás mellé!

2. **Paraméter.** Fogadjon a program paramétereket parancssorból. Írja ki őket a konzolra!

3. **Csapadék.** Tároljunk napi csapadékmennyiségeket egy tömbben.

    a. Deklarálj egy 18 elemű tömböt, majd generálj bele csapadék értékeket `1.80` és `2.20` között véletlenszerűen, két tizedesjegy pontossággal!

    b. Írasd ki a generált értékeket egymás mellé szóközzel elválasztva!

    c. Határozd meg, hogy az egymást követő napok között milyen irányban változott a csapadékmennyiség.

    **Minta:**
    ```
    1,82 2,1 2,15 2,06 1,93 2,18 2,05 1,81 2,12 1,97 1,83 1,83 2,06 2,09 2,15 1,8 1,94 1,87
    01 - 02. változás: növekszik 0,28
    02 - 03. változás: növekszik 0,05
    03 - 04. változás: csökken 0,09
    04 - 05. változás: csökken 0,13
    05 - 06. változás: növekszik 0,25
    06 - 07. változás: csökken 0,13
    07 - 08. változás: csökken 0,24
    08 - 09. változás: növekszik 0,31
    09 - 10. változás: csökken 0,15
    10 - 11. változás: csökken 0,14
    11 - 12. változás: változatlan
    12 - 13. változás: növekszik 0,23
    13 - 14. változás: növekszik 0,03
    14 - 15. változás: növekszik 0,06
    15 - 16. változás: csökken 0,35
    16 - 17. változás: növekszik 0,14
    17 - 18. változás: csökken 0,07
    ```
