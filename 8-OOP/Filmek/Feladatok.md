1. A `Film.cs` osztályban készíts egy `Ertekel(int)` metódust, amelynek egy egész számot megadva értékelhetjük az adott filmet.

    Pl.: ha korábban `4.4` volt az értékelése és a nézők száma `30`, akkor `Ertekel(10)` hívás hatására `4.580645...` lesz az új imdb pontszáma.

    Ügyelj rá, hogy értékelésnél csak 0 és 10 közötti értékeket fogadj el!

2. Készíts az `imdb` mezőhöz tartozó property-t, amelynek getterje az imdb pontszámot adja vissza 2 tizedesre kerekítve!

3. Hozz létre új osztályt `Televizio` néven, amelynek egyetlen, privát adattagja egy `filmek` nevű, `Film` objektumokat tartalmazó lista!

4. A `Televizio` osztály egyetlen konstruktorral rendelkezzen, amely egy fájl nevét várja paraméterként. A kapott fájlból olvassa be az adatokat, majd tárolja el a listában.

5. Definiálj egy `Legregebbi()` metódust a `Televizio` osztályban, ami megadja azt a filmet (a teljes objektumot), ami a legkorábban készült.

6. Készíts `Rendez()` néven privát metódust, amely buborékos rendezést használva imdb pontszám szerint csökkenő sorrendbe rendezi a filmek lista elemeit!

7. Hozz létre `Kiir(string, int)` metódust, amely paraméterként kap egy fájlnevet és egy darabszámot. A függvény először rendezi az adatokat a korábbi metódus meghívásával, majd a darabszámnak megfelelő mennyiségű adatot kiírja a kapott fájlba. A fájlba írásnál használd a `Film` osztály `ToString()` metódusát!
