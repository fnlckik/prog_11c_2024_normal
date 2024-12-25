# Gyakorlás (vegyes)

1. Készíts függvényt, amely kiszámolja egy háromszög három oldalából annak területét:
    
    $T = \sqrt{s\cdot(s-a)\cdot(s-b)\cdot(s-c)}$
    ahol $s$ a kerület fele.

2. Válogasd ki egy szavakat tartalmazó tömbből azokat az elemeket, amelyek első és utolsó betűje megegyezik!

    Pl.:
    ```cs
    string[] szavak = {"alma", "korte", "citrom", "sas", "radír", "egér"}
    ```
    esetén az `"alma", "sas", "radír"` szavak.

3. Írj függvényt, ami megmondja egy szövegről, hogy van-e benne `sz` betű!

    Pl.:
    ```cs
    VanSZ("ablak") == false
    VanSZ("szaloncukor") == true
    VanSZ("Reszkessetek betörők!") == true
    VanSZ("darázs") == false
    VanSZ("halász") == true
    ```

4. Generálj kétjegyű számokat véletlenszerűen, ameddig 7-tel oszthatót nem kapsz!

5. Egy $5\times3$-mas `m` mátrix `i.` sorának `j.` oszlopa tárolja, hogy az `i.` típusú szaloncukor a `j.` üzletben mennyibe kerül.

    Pl.:
    ```cs
    int[,] m = {
        {1870, 2300, 3155}, // 1. típus
        {3252, 2720, 3800}, // 2. típus
        {4500, 3879, 3999}, // 3. típus
        {3100, 2999, 2890}, // 4. típus
        {2250, 2100, 3450}  // 5. típus
    };
    ```

    - Add meg a szaloncukrok átlagos árát két tizedesre kerekítve! `3084,27`
    - Add meg minden típus esetében, hogy melyik üzletben kapható a legolcsóbban! `1 2 2 3 2`
    - Add meg minden üzletre, hogy melyik szaloncukor kapható ott legolcsóbban! `1 5 4`